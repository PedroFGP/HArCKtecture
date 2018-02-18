﻿using HArCKtecture.Classes;
using System;
using System.Windows.Forms;
using WindowsAPI;

namespace HArCKtecture.User_Controls
{
    public partial class UcMemoryViewer : UserControl
    {
        #region Properties

        private WindowsProcess Process { get; set; }

        #endregion

        #region Constructor

        public UcMemoryViewer(WindowsProcess process)
        {
            Process = process;

            InitializeComponent();
        }

        #endregion

        #region Events

        private void UcMemoryViewer_Load(object sender, System.EventArgs e)
        {
            LoadTypeComboboxes();

            SetupMemoryView();
        }

        private void BtnSearch_Click(object sender, System.EventArgs e)
        {
            IntPtr address = ProcessExtensions.StringToAddress(TbxReadAddress.Text);
        }

        private void BtnVisualize_Click(object sender, System.EventArgs e)
        {

        }

        private void BtnWriteMemory_Click(object sender, System.EventArgs e)
        {

        }

        #endregion

        #region Methods

        private void LoadTypeComboboxes()
        {
            var types = EnumExtensions.GetDescriptionList<DataTypes>();

            CbxReadType.SetDictionaryDataSource(types);
            CbxWriteType.SetDictionaryDataSource(types);
        }

        private void SetupMemoryView()
        {
            LvwMemory.Columns.Add("Endereço", 80, HorizontalAlignment.Center);
            LvwMemory.Columns.Add("Bytes + Opcodes", 80, HorizontalAlignment.Center);

            RefreshMemoryView();
        }

        private void RefreshMemoryView()
        {
            LvwMemory.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            LvwMemory.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        #endregion
    }
}