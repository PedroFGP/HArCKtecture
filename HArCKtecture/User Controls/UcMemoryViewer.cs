using Binarysharp.MemoryManagement;
using HArCKtecture.Classes;
using HArCKtecture.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WindowsAPI;

namespace HArCKtecture.User_Controls
{
    public partial class UcMemoryViewer : UserControl
    {
        #region Properties

        private Challenge CurrentChallenge { get; set; }

        private WindowsProcess ChallengeProcess { get; set; }

        private uint LastestAddress { get; set; }

        private FrmHelp HelpForm;

        private Stopwatch Watch = new Stopwatch();

        #endregion

        #region Constructor

        public UcMemoryViewer(Challenge challenge)
        {
            CurrentChallenge = challenge;

            HelpForm = new FrmHelp(challenge);

            StartChallengeProcess();

            InitializeComponent();
        }

        #endregion

        #region Events

        private void UcMemoryViewer_Load(object sender, EventArgs e)
        {
            LoadTypeComboboxes();

            RefreshMemoryView((uint)CbxMemoryAddress.SelectedValue);

            LblMemoryView.Text = String.Format(LblMemoryView.Text, ChallengeProcess.Memory.Windows.MainWindow.Title);

            RegisterContainedControlsEvents();

            TmrCheckAnswer.Start();
            TmrCheckProcessAlive.Start();

            while (ChallengeProcess.Memory.Windows.MainWindowHandle == IntPtr.Zero)
            {
                Thread.Sleep(100);
            }

            HelpForm.StartPosition = FormStartPosition.CenterScreen;
            HelpForm.TopMost = true;
            HelpForm.ShowDialog();
            HelpForm.Focus();
            HelpForm.TopMost = false;

            Watch.Start();
        }

        private void CbxMemoryAddress_TextUpdate(object sender, EventArgs e)
        {
            OnMemoryAddressUpdate();
        }

        private void BtnInjectBytes_Click(object sender, EventArgs e)
        {
            InjectBytesAtSelectedPosition();
        }

        private void BtnInjectAsmCode_Click(object sender, EventArgs e)
        {
            InjectAsmAtSelectedPosition();
        }

        private void BtnFillSelectedItemWithNops_Click(object sender, EventArgs e)
        {
            FillSelectedItemWithNops();
        }

        private void TmrCheckAnswer_Tick(object sender, EventArgs e)
        {
            CheckForAnswer();
        }

        private void TmrCheckProcessAlive_Tick(object sender, EventArgs e)
        {
            CheckForProcessAlive();
        }

        private void CbxMemoryAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxMemoryAddress.SelectedValue is uint)
            {
                RefreshMemoryView((uint)CbxMemoryAddress.SelectedValue);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ChallengeProcess.Memory.Handle.Close();

            ChallengeProcess.Memory.Windows.MainWindow.Close();

            this.ParentForm.Close();
        }

        private void CbxMemoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMemoryValue();
        }

        private void RbtxCode_TextChanged(object sender, EventArgs e)
        {
            var instructionsBytes = Asm.AssembleInstructions(RbtxCode.Text);

            if (instructionsBytes != null && instructionsBytes.Length > 0)
            {
                RbtxByteOutput.ContainedControl.Text = ByteExtension.ByteToHexSplit(instructionsBytes, 2);
            }
        }

        private void LsvMemory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LsvMemory.SelectedItems.Count > 0)
            {
                RbtxCode.Text = LsvMemory.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void TbxMemoryAddress_TextChanged(object sender, EventArgs e)
        {
            UpdateMemoryValue();
        }

        private void TbxMemoryValue_ButtonClicked()
        {
            UpdateMemoryValue(false);
        }

        private void LsvMemory_SizeChanged(object sender, EventArgs e)
        {
            LsvMemory.Columns[2].Width = LsvMemory.Width - 10;
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            try
            {
                if (ChallengeProcess.Memory.IsRunning)
                {
                    ChallengeProcess.Memory.Native.Kill();
                }
            }
            catch(Exception ex)
            {

            }
        }

        #endregion

        #region Methods

        private int NopRemainingBytes(int instructionIndex, byte[] currentInstruction)
        {
            var stringBytes = LsvMemory.Items[instructionIndex].SubItems[1].Text.Split(' ').Where(opcode => opcode != String.Empty).Count();

            int bytesDifference = currentInstruction.Length - stringBytes;

            if (bytesDifference > 0)
            {
                while (bytesDifference > 0)
                {
                    instructionIndex++;

                    int count = LsvMemory.Items[instructionIndex].SubItems[1].Text.Split(' ').Where(opcode => opcode != String.Empty).Count();

                    bytesDifference -= count;
                }
            }

            return Math.Abs(bytesDifference);
        }

        private void CheckForAnswer()
        {
            var address = new IntPtr(CurrentChallenge.AnswerAddress);

            if (ChallengeProcess.Memory.IsRunning && ChallengeProcess.Memory.Read<byte>(address, false) == 0x1)
            {
                TmrCheckAnswer.Stop();

                CurrentChallenge.Finished = true;
                Watch.Stop();

                CurrentChallenge.TotalTime = Watch.Elapsed;

                CurrentChallenge.Save();

                MessageBox.Show(new Form { TopMost = true }, "Desafio concluído com sucesso!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ChallengeProcess.Memory.Windows.MainWindow.Close();

                Globals.ResetChallenges = true;

                this.ParentForm.Close();
            }
        }

        private void CheckForProcessAlive()
        {
            if (ChallengeProcess.Memory.IsRunning == false)
            {
                TmrCheckAnswer.Stop();

                CurrentChallenge.RemoteProcessCrashes++;

                var startInfoBackup = ChallengeProcess.Memory.Native.StartInfo;

                ChallengeProcess.Memory.Native.Start();

                ChallengeProcess = new WindowsProcess(CurrentChallenge.Name, false);

                ChallengeProcess.Memory.Native.StartInfo = startInfoBackup;

                var proc = Process.GetProcessesByName(CurrentChallenge.Name).FirstOrDefault();

                while(proc == null)
                {
                    proc = Process.GetProcessesByName(CurrentChallenge.Name).FirstOrDefault();

                    Thread.Sleep(100);
                }

                TmrCheckAnswer.Start();
            }
        }

        private void InjectBytesAtSelectedPosition()
        {
            if (LsvMemory.SelectedItems.Count <= 0)
            {
                return;
            }
            if (!UInt32.TryParse(LsvMemory.SelectedItems[0].SubItems[0].Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint result))
            {
                return;
            }

            var ptrAddress = new IntPtr(result);

            var instructionBytes = new List<byte>();

            foreach (var textByte in RbtxByteOutput.Text.Trim().Split(' '))
            {
                if (byte.TryParse(textByte, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out byte byteResult))
                {
                    instructionBytes.Add(byteResult);
                }
            }

            if (ChbxFillNops.Checked)
            {
                var nopCount = NopRemainingBytes(LsvMemory.SelectedItems[0].Index, instructionBytes.ToArray());

                while (nopCount > 0)
                {
                    instructionBytes.Add(0x90);

                    nopCount--;
                }
            }

            try
            {
                for (int offset = 0; offset < instructionBytes.Count; offset++)
                {
                    ChallengeProcess.Memory.Write(ptrAddress + offset, instructionBytes[offset], false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CurrentChallenge.Operations.Add(new Operation()
            {
                Address = result,
                OperationType = OperationType.WRITE,
                Value = RbtxByteOutput.Text,
                ElapsedTime = Watch.Elapsed
            });

            RefreshMemoryView();
        }

        private void InjectAsmAtSelectedPosition()
        {
            if (LsvMemory.SelectedItems.Count > 0)
            {
                if (!UInt32.TryParse(LsvMemory.SelectedItems[0].SubItems[0].Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint result))
                {
                    return;
                }

                var ptrAddress = new IntPtr(result);

                if (ChbxFillNops.Checked)
                {
                    var nopCount = NopRemainingBytes(LsvMemory.SelectedItems[0].Index, Asm.AssembleInstructions(RbtxCode.Text));

                    while (nopCount > 0)
                    {
                        RbtxCode.Text += Environment.NewLine + "nop";

                        nopCount--;
                    }
                }

                try
                {
                    ChallengeProcess.Memory.Assembly.Inject(RbtxCode.Text, ptrAddress);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CurrentChallenge.Operations.Add(new Operation()
                {
                    Address = result,
                    OperationType = OperationType.ASM_OVERWRITE,
                    Value = RbtxCode.Text,
                    ElapsedTime = Watch.Elapsed
                });

                RefreshMemoryView();
            }
        }

        private void FillSelectedItemWithNops()
        {
            if (LsvMemory.SelectedItems.Count <= 0)
            {
                return;
            }

            if (!UInt32.TryParse(LsvMemory.SelectedItems[0].SubItems[0].Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint result))
            {
                return;
            }

            var ptrAddress = new IntPtr(result);

            for (int offset = 0; offset < NopRemainingBytes(LsvMemory.SelectedItems[0].Index, new byte[0]) ; offset++)
            {
                ChallengeProcess.Memory.Write(ptrAddress + offset, (byte)0x90, false);

                CurrentChallenge.Operations.Add(new Operation()
                {
                    Address = result + (uint)offset,
                    OperationType = OperationType.WRITE,
                    Value = "0x90",
                    ElapsedTime = Watch.Elapsed
                });
            }

            RefreshMemoryView();
        }

        private void RegisterContainedControlsEvents()
        {
            LsvMemory.ContainedControl.SelectedIndexChanged += LsvMemory_SelectedIndexChanged;
            TbxMemoryValue.ButtonClicked += TbxMemoryValue_ButtonClicked;
        }

        private void LoadTypeComboboxes()
        {
            var types = EnumExtensions.GetDescriptionList<DataType>();

            CbxMemoryType.SetDictionaryDataSource(types);

            var addressesDataSource = CurrentChallenge.Addresses.ToDictionary(addr => addr.Description + " (" + addr.Address.ToString("X") + ")", addr => addr.Address);

            CbxMemoryAddress.SetDictionaryDataSource(addressesDataSource);
        }

        private void UpdateMemoryValue(bool read = true)
        {
            if (!UInt32.TryParse(TbxMemoryAddress.Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint result))
            {
                return;
            }

            if (!IsValidAddress(result))
            {
                return;
            }

            var ptrAddress = new IntPtr(result);

            if (!read)
            {
                if (result == CurrentChallenge.AnswerAddress)
                {
                    CurrentChallenge.Cheated = true;
                }
            }

            switch ((DataType)CbxMemoryType.SelectedValue)
            {
                case DataType.INTEGER:
                    {
                        if (read)
                        {
                            TbxMemoryValue.Text = ChallengeProcess.Memory.Read<int>(ptrAddress, false).ToString();
                        }
                        else if (Int32.TryParse(TbxMemoryValue.Text, out int intValue))
                        {
                            ChallengeProcess.Memory.Write(ptrAddress, intValue, false);
                        }
                    }
                    break;

                case DataType.FLOAT:
                    {
                        if (read)
                        {
                            TbxMemoryValue.Text = ChallengeProcess.Memory.Read<float>(ptrAddress, false).ToString();
                        }
                        else if (float.TryParse(TbxMemoryValue.Text, out float floatValue))
                        {
                            ChallengeProcess.Memory.Write(ptrAddress, floatValue, false);
                        }
                    }
                    break;

                case DataType.BIT:
                    {
                        if (read)
                        {
                            TbxMemoryValue.Text = ChallengeProcess.Memory.Read<bool>(ptrAddress, false).ToString();
                        }
                        else if (Boolean.TryParse(TbxMemoryValue.Text, out bool boolValue))
                        {
                            ChallengeProcess.Memory.Write(ptrAddress, boolValue, false);
                        }
                    }
                    break;

                case DataType.STRING:
                    {
                        if (read)
                        {
                            TbxMemoryValue.Text = ChallengeProcess.Memory.ReadString(ptrAddress, false);
                        }
                        else if (!String.IsNullOrEmpty(TbxMemoryValue.Text))
                        {
                            ChallengeProcess.Memory.WriteString(ptrAddress, TbxMemoryValue.Text, false);
                        }

                    }
                    break;

                case DataType.BYTE:
                    {
                        if (read)
                        {
                            TbxMemoryValue.Text = ChallengeProcess.Memory.Read<byte>(ptrAddress, false).ToString("X");
                        }
                        else if (Byte.TryParse(TbxMemoryValue.Text, out byte byteValue))
                        {
                            ChallengeProcess.Memory.Write(ptrAddress, byteValue, false);
                        }
                    }
                    break;

                case DataType.CHAR:
                    {
                        if (read)
                        {
                            TbxMemoryValue.Text = ChallengeProcess.Memory.Read<char>(ptrAddress, false).ToString();
                        }
                        else if (Char.TryParse(TbxMemoryValue.Text, out char charValue))
                        {
                            ChallengeProcess.Memory.Write(ptrAddress, charValue, false);
                        }
                    }
                    break;
            }

            CurrentChallenge.Operations.Add(new Operation()
            {
                Address = result,
                OperationType = (read) ? OperationType.READ : OperationType.WRITE,
                Value = TbxMemoryValue.Text,
                ElapsedTime = Watch.Elapsed
            });

            if (!read)
            {
                RefreshMemoryView();
            }
        }

        private bool IsValidAddress(uint address)
        {
            int baseAddress = ChallengeProcess.Memory.Modules.MainModule.BaseAddress.ToInt32();

            if (address >= baseAddress && address <= (ChallengeProcess.Memory.Modules.MainModule.Size + baseAddress))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void OnMemoryAddressUpdate()
        {
            if (!UInt32.TryParse(CbxMemoryAddress.Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint result))
            {
                if (CbxMemoryAddress.SelectedValue != null && CbxMemoryAddress.SelectedValue is uint)
                {
                    result = (uint)CbxMemoryAddress.SelectedValue;
                }
            }

            RefreshMemoryView(result);
        }

        private void RefreshMemoryView()
        {
            RefreshMemoryView(LastestAddress);
        }

        private void RefreshMemoryView(uint address, int size = 1024)
        {
            if (!IsValidAddress(address))
            {
                return;
            }

            LastestAddress = address;

            LsvMemory.Items.Clear();

            var ptrAddress = new IntPtr(address);

            byte[] bytes = ChallengeProcess.Memory.Read<byte>(ptrAddress, size, false);

            var parsedInstructions = Disasm.DisassembleBytes(address, bytes);

            bool addrBetween = false;

            foreach (var instruction in parsedInstructions)
            {
                var lastItem = LsvMemory.Items.Add(new ListViewItem(new string[] { instruction.Address, ByteExtension.ByteToHexSplit(instruction.Bytes, 2), instruction.Opcodes }));

                var uintAddr = Convert.ToUInt32(instruction.Address, 16);

                addrBetween = CurrentChallenge.Addresses.Any(addr => addr.Address < uintAddr && addr.PairAddress > uintAddr);

                if (addrBetween)
                {
                    lastItem.BackColor = Color.LightGreen;
                    addrBetween = false;
                }

                var specialAddr = CurrentChallenge.Addresses.FirstOrDefault(addr => addr.Address == uintAddr);

                if (specialAddr != null)
                {
                    switch (specialAddr.Type)
                    {
                        case AddressType.SINGLE:
                            lastItem.BackColor = Color.LightBlue;
                            break;
                        case AddressType.START:
                        case AddressType.END:
                            lastItem.BackColor = Color.LightCoral;
                            break;
                    }
                }
            }
        }

        private void StartChallengeProcess()
        {
            var proc = System.Diagnostics.Process.GetProcessesByName(CurrentChallenge.Name).FirstOrDefault();

            if (proc != null)
            {
                proc.Kill();
            }

            while(proc != null)
            {
                proc = System.Diagnostics.Process.GetProcessesByName(CurrentChallenge.Name).FirstOrDefault();

                Thread.Sleep(100);
            }

            File.WriteAllBytes(CurrentChallenge.Name + ".exe", CurrentChallenge.ExecutableBytes);

            ChallengeProcess = new WindowsProcess(CurrentChallenge.Name + ".exe", true);

        }

        #endregion
    }
}
