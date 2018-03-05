using HArCKtecture.Classes;
using System;
using System.Collections.Generic;
using System.IO;
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

            LblMemoryView.Text = String.Format(LblMemoryView.Text, Process.Memory.Windows.MainWindow.Title + ", 0x" + Process.Memory.Modules.MainModule.BaseAddress.ToString());
        }

        private void TbxMemoryAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbxMemoryValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnInjectAsmCode_Click(object sender, EventArgs e)
        {

        }

        private void BtnOverwriteAsm_Click(object sender, EventArgs e)
        {

        }

        private void TmrCheckAnswer_Tick(object sender, EventArgs e)
        {
            if(Process.Memory.Read<bool>((IntPtr)Current.AnswerAddress, false))
            {
                Current.Finished = true;

                Current.Save();

                TmrCheckAnswer.Stop();
            }
        }

        #endregion

        #region Methods

        private void LoadTypeComboboxes()
        {
            var types = EnumExtensions.GetDescriptionList<DataTypes>();
            
            CbxMemoryType.SetDictionaryDataSource(types);

            Dictionary<string, uint> addresses = new Dictionary<string, uint>(Current.Addresses);

            CbxMemoryAddress.SetDictionaryDataSource(addresses);
        }

        private void SetupMemoryView()
        {
            RefreshMemoryView();
        }

        private void RefreshMemoryView()
        {
            byte[] bytes = Process.Memory.Read<byte>(new IntPtr((uint)CbxMemoryAddress.SelectedValue), 512, false);

            foreach(var line in Disasm.DisassembleBytes((uint)CbxMemoryAddress.SelectedValue, bytes))
            {
                LsvMemory.Items.Add(new ListViewItem(new string[] { line.Key, line.Value }));
            }

            LsvMemory.ContainedControl.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            LsvMemory.ContainedControl.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        #endregion

        private void CbxMemoryAddress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
