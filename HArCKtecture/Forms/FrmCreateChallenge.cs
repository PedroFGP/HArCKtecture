using HArCKtecture.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using VisualPlus.Toolkit.Controls.Editors;
using VisualPlus.Toolkit.Dialogs;
using ZeroFormatter;

namespace HArCKtecture.Forms
{
    public partial class FrmCreateChallenge : VisualForm
    {
        #region Properties

        Dictionary<string, uint> Addresses { get; set; }

        #endregion

        #region Constructor

        public FrmCreateChallenge()
        {
            InitializeComponent();

            Addresses = new Dictionary<string, uint>();
        }

        #endregion

        #region Events

        private void FrmCreateChallenge_Load(object sender, System.EventArgs e)
        {
            FillComboboxes();
        }

        private void BtnRemove_Click(object sender, System.EventArgs e)
        {
            Addresses.Remove(LsvAddresses.SelectedItems[0].SubItems[1].Text);

            LsvAddresses.Items.Remove(LsvAddresses.SelectedItems[0]);
        }

        private void BtnAddAddress_Click(object sender, EventArgs e)
        {
            if(!UInt32.TryParse(TbxNewAddress.Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint newAddress))
            {
                MessageBox.Show(null, "Favor escrever um endereço válido (somente números)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if(Addresses.ContainsKey(TbxNewDescription.Text))
            {
                MessageBox.Show(null, "Essa descrição já existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            LsvAddresses.Items.Add(new ListViewItem(new string[] { TbxNewAddress.Text, TbxNewDescription.Text }));

            Addresses.Add(TbxNewDescription.Text, newAddress);
        }

        private void BtnFilePath_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openExecutable = new OpenFileDialog
            {
                Multiselect = false
            };

            var dialogResult = openExecutable.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                TbxFilePath.Text = openExecutable.FileName;
            }
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            var message = IsEmptyInput(
                new KeyValuePair<Control, string>(CbxDificulty, CbxDificulty.Text),
                new KeyValuePair<Control, string>(TbxTitle, LblName.Text),
                new KeyValuePair<Control, string>(TbxFilePath, LblPath.Text),
                new KeyValuePair<Control, string>(RtbxHelp, GbxDescription.Text));

            StringBuilder invalidMessage = new StringBuilder();

            invalidMessage.AppendLine("Favor preencher corretamente os seguintes campos:" + Environment.NewLine);
            invalidMessage.AppendLine(message);

            if (String.IsNullOrEmpty(message))
            {
                CreateChallenge();

                this.Close();
            }
            else
            {
                MessageBox.Show(this, invalidMessage.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Methods

        private void FillComboboxes()
        {
            var types = EnumExtensions.GetDescriptionsList<DificultyLevel>();

            CbxDificulty.SetDictionaryDataSource(types);
        }

        private string IsEmptyInput(params KeyValuePair<Control, string>[] list)
        {
            StringBuilder invalidMessage = new StringBuilder();

            foreach (var item in list)
            {
                if (item.Key is ComboBox)
                {
                    if (((ComboBox)item.Key).SelectedIndex == -1)
                    {
                        invalidMessage.AppendLine(item.Value);
                    }
                }
                else if (item.Key is VisualTextBox)
                {
                    if (String.IsNullOrEmpty(((VisualTextBox)item.Key).Text))
                    {
                        invalidMessage.AppendLine(item.Value);
                    }
                }
            }

            return invalidMessage.ToString();
        }

        private void CreateChallenge()
        {
            Challenge newChallenge = new Challenge()
            {
                Name = TbxTitle.Text,
                Dificulty = ((KeyValuePair<string, DificultyLevel>)CbxDificulty.SelectedItem).Value,
                Description = RtbxHelp.Text,
                Architecture = ArchitectureMode.x86_32,
                DynamicBase = ChkDynamicBase.Checked,
                FileLocation = TbxFilePath.Text,
                AnswerAddress = Convert.ToUInt32(TbxAnswerAddress.Text),
                Order = NupOrder.Value,
                Finished = false,
                Addresses = Addresses.AsLazyDictionary()
            };

            newChallenge.Save();
        }

        #endregion
    }
}
