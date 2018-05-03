using HArCKtecture.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VisualPlus.Toolkit.Controls.Editors;
using VisualPlus.Toolkit.Dialogs;

namespace HArCKtecture.Forms
{
    public partial class FrmCreateChallenge : VisualForm
    {
        #region Properties

        private List<SpecialAddress> Addresses { get; }

        private byte[] FileBytes;

        #endregion

        #region Constructor

        public FrmCreateChallenge()
        {
            InitializeComponent();

            Addresses = new List<SpecialAddress>();
        }

        #endregion

        #region Events

        private void FrmCreateChallenge_Load(object sender, System.EventArgs e)
        {
            FillComboboxes();
        }

        private void BtnRemove_Click(object sender, System.EventArgs e)
        {
            Addresses.RemoveAll(addr => addr.Address == Convert.ToUInt32(LsvAddresses.SelectedItems[0].SubItems[2].Text));

            LsvAddresses.Items.Remove(LsvAddresses.SelectedItems[0]);
        }

        private void BtnAddAddress_Click(object sender, EventArgs e)
        {
            if(!UInt32.TryParse(TbxNewAddress.Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint newAddress))
            {
                MessageBox.Show(null, "Favor escrever um endereço válido (somente números)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if(Addresses.Find(addr => addr.Address == newAddress) != null)
            {
                MessageBox.Show(null, "Esse endereço já existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if(Addresses.Count(addr => addr.Description == TbxNewDescription.Text) == 2)
            {
                MessageBox.Show(null, "Já existem dois endereços especiais com essa descrição!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            LsvAddresses.Items.Add(new ListViewItem(new string[] { TbxNewAddress.Text, TbxNewDescription.Text }));

            Addresses.Add(new SpecialAddress() {
                Address = newAddress,
                Description = TbxNewDescription.Text,
                Type = AddressType.NONE
            });
        }

        private void BtnFilePath_Click(object sender, System.EventArgs e)
        {
            var openExecutable = new OpenFileDialog
            {
                Multiselect = false
            };

            var dialogResult = openExecutable.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                if(!File.Exists(openExecutable.FileName))
                {

                }

                TbxFilePath.Text = openExecutable.FileName;
                FileBytes = File.ReadAllBytes(TbxFilePath.Text);
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

            var invalidMessage = new StringBuilder();

            invalidMessage.Append("Favor preencher corretamente os seguintes campos:").AppendLine(Environment.NewLine);
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
            SpecialAddress pairAddr = null;

            foreach(var specAddr in Addresses.ToList())
            {
                if(pairAddr != null && pairAddr.Address == specAddr.Address)
                {
                    continue;
                }

                pairAddr = Addresses.FirstOrDefault(addr => addr.Description == specAddr.Description && addr.Address != specAddr.Address);

                if(specAddr.Type == AddressType.NONE)
                {
                    if (pairAddr != null)
                    {
                        specAddr.PairAddress = pairAddr.Address;
                        specAddr.Type = AddressType.START;
                        pairAddr.Type = AddressType.END;
                    }
                    else
                    {
                        specAddr.Type = AddressType.SINGLE;
                    }
                }
            }

            var newChallenge = new Challenge()
            {
                Name = TbxTitle.Text,
                Dificulty = ((KeyValuePair<string, DificultyLevel>)CbxDificulty.SelectedItem).Value,
                Description = RtbxHelp.Text,
                Architecture = ArchitectureMode.x86_32,
                DynamicBase = !TglDynamicBase.Toggled,
                AnswerAddress = UInt32.Parse(TbxAnswerAddress.Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture),
                Order = NupOrder.Value,
                Finished = false,
                Addresses = Addresses,
                ExecutableBytes = File.ReadAllBytes(TbxFilePath.Text),
                Cheated = false,
                RemoteProcessCrashes = 0,
                Operations = new List<Operation>()
            };

            newChallenge.Save();
        }

        #endregion
    }
}
