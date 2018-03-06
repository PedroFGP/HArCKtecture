using HArCKtecture.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WindowsAPI;

namespace HArCKtecture.User_Controls
{
    public partial class UcMemoryViewer : UserControl
    {
        #region Properties

        private Challenge Current { get; set; }

        private WindowsProcess Process { get; set; }

        #endregion

        #region Constructor

        public UcMemoryViewer(Challenge challenge)
        {
            Current = challenge;

            Process = new WindowsProcess(challenge.FileLocation, true);

            InitializeComponent();
        }

        #endregion

        #region Events

        private void UcMemoryViewer_Load(object sender, EventArgs e)
        {
            LoadTypeComboboxes();

            SetupMemoryView();

            LblMemoryView.Text = String.Format(LblMemoryView.Text, Process.Memory.Windows.MainWindow.Title + ", 0x" + Process.Memory.Modules.MainModule.BaseAddress.ToString("X"));

            RegisterContainedControlsEvents();

            TmrCheckAnswer.Start();
        }

        private void CbxMemoryAddress_TextUpdate(object sender, EventArgs e)
        {
            OnMemoryAddressUpdate();
        }

        private void TbxMemoryValue_TextChanged(object sender, EventArgs e)
        {
            if (!Int64.TryParse(TbxMemoryValue.Text, out long result))
            {
                return;
            }
        }

        private void BtnInjectAsmCode_Click(object sender, EventArgs e)
        {
            if (LsvMemory.SelectedItems.Count > 0)
            {
                if (!UInt32.TryParse(LsvMemory.SelectedItems[0].SubItems[0].Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint result))
                {
                    return;
                }

                var address = new IntPtr(result);

                var instructionsBytes = Asm.AssembleInstructions(RbtxCode.Text);

                var stringBytes = LsvMemory.SelectedItems[0].SubItems[1].Text.Split(' ').Where(opcode => opcode != String.Empty);

                int bytesDifference = instructionsBytes.Length - stringBytes.Count();

                int selectedIndex = LsvMemory.SelectedItems[0].Index;

                if (bytesDifference > 0)
                { 
                    while (bytesDifference > 0)
                    {
                        selectedIndex++;

                        int count = LsvMemory.Items[selectedIndex].SubItems[1].Text.Split(' ').Where(opcode => opcode != String.Empty).Count();



                        bytesDifference -= count;
                    }
                }
                else if(bytesDifference < 0)
                {
                    while (bytesDifference != 0)
                    {
                        bytesDifference = Math.Abs(bytesDifference);

                        RbtxCode.Text += Environment.NewLine + "nop";

                        bytesDifference--;
                    }
                } 

                Process.Memory.Assembly.Inject(RbtxCode.Text, address);

                OnMemoryAddressUpdate();
            }
        }

        private void TmrCheckAnswer_Tick(object sender, EventArgs e)
        {
            if (!UInt32.TryParse(Current.AnswerAddress.ToString(), NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint result))
            {
                return;
            }

            var address = new IntPtr(result);

            if (Process.Memory.Read<bool>(address, false))
            {
                TmrCheckAnswer.Stop();

                Current.Finished = true;

                MessageBox.Show(null, "Desafio concluído com sucesso!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Current.Save();
            }
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
            Process.Memory.Handle.Close();

            this.ParentForm.Close();
        }

        private void CbxMemoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxMemoryAddress.SelectedValue != null)
            {
                var ptrAddress = new IntPtr((uint)CbxMemoryAddress.SelectedValue);

                UpdateMemoryValue(ptrAddress);
            }
            else if (!String.IsNullOrEmpty(CbxMemoryAddress.Text))
            {
                if (!UInt32.TryParse(CbxMemoryAddress.Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint result))
                {
                    return;
                }

                var ptrAddress = new IntPtr(result);

                UpdateMemoryValue(ptrAddress);
            }
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

                if (!UInt32.TryParse(LsvMemory.SelectedItems[0].SubItems[0].Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint result))
                {
                    return;
                }

                var ptrAddress = new IntPtr(result);

                UpdateMemoryValue(ptrAddress);
            }
        }

        #endregion

        #region Methods

        private void RegisterContainedControlsEvents()
        {
            LsvMemory.ContainedControl.SelectedIndexChanged += LsvMemory_SelectedIndexChanged;
        }

        private void LoadTypeComboboxes()
        {
            var types = EnumExtensions.GetDescriptionList<DataType>();

            CbxMemoryType.SetDictionaryDataSource(types);

            var addresses = new Dictionary<string, uint>(Current.Addresses);

            CbxMemoryAddress.SetDictionaryDataSource(addresses);
        }

        private void SetupMemoryView()
        {
            RefreshMemoryView((uint)CbxMemoryAddress.SelectedValue);
        }

        private void UpdateMemoryValue(IntPtr ptrAddress)
        {
            switch ((DataType)CbxMemoryType.SelectedValue)
            {
                case DataType.INTEGER:
                    TbxMemoryValue.Text = Process.Memory.Read<int>(ptrAddress, false).ToString();
                    break;

                case DataType.FLOAT:
                    TbxMemoryValue.Text = Process.Memory.Read<float>(ptrAddress, false).ToString();
                    break;

                case DataType.BIT:
                    TbxMemoryValue.Text = Process.Memory.Read<bool>(ptrAddress, false).ToString();
                    break;

                case DataType.STRING:
                    TbxMemoryValue.Text = Process.Memory.ReadString(ptrAddress, false);
                    break;

                case DataType.BYTE:
                    TbxMemoryValue.Text = Process.Memory.Read<byte>(ptrAddress, false).ToString("X");
                    break;

                case DataType.CHAR:
                    TbxMemoryValue.Text = Process.Memory.Read<char>(ptrAddress, false).ToString();
                    break;
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

            int baseAddress = Process.Memory.Modules.MainModule.BaseAddress.ToInt32();

            if (result >= baseAddress && result <= (Process.Memory.Modules.MainModule.Size + baseAddress))
            {
                RefreshMemoryView(result);
            }
        }

        private void RefreshMemoryView(uint address)
        {
            LsvMemory.Items.Clear();

            var ptrAddress = new IntPtr(address);

            byte[] bytes = Process.Memory.Read<byte>(ptrAddress, 512, false);

            UpdateMemoryValue(ptrAddress);

            var parsedInstructions = Disasm.DisassembleBytes(address, bytes);

            foreach (var instruction in parsedInstructions)
            {
                LsvMemory.Items.Add(new ListViewItem(new string[] { instruction.Address, ByteExtension.ByteToHexSplit(instruction.Bytes, 2), instruction.Opcodes }));
            }
        }

        #endregion
    }
}
