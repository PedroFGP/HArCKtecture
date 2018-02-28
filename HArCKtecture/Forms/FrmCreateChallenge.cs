using HArCKtecture.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using VisualPlus.Toolkit.Controls.Editors;
using VisualPlus.Toolkit.Controls.Layout;
using ZeroFormatter;

namespace HArCKtecture.Forms
{
    public partial class FrmCreateChallenge : VisualForm
    {
        #region Constructor

        public FrmCreateChallenge()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void FrmCreateChallenge_Load(object sender, System.EventArgs e)
        {
            
        }

        private void BtnRemove_Click(object sender, System.EventArgs e)
        {
            LsvAddresses.Items.Remove(LsvAddresses.SelectedItems[0]);
        }

        private void BtnFilePath_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openExecutable = new OpenFileDialog
            {
                CheckFileExists = true,
                Multiselect = false,
                Filter = "Executáveis (*.exe)| *.exe | Todos os arquivos (*.*) | *.* "
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
                new KeyValuePair<Control, string>(RtbxHelp, LblHelp.Text));

            if(String.IsNullOrEmpty(message))
            {
                CreateChallenge();
            }
            else
            {
                MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Methods

        private string IsEmptyInput(params KeyValuePair<Control, string>[] list)
        {
            StringBuilder invalidMessage = new StringBuilder();

            invalidMessage.AppendLine("Favor preencher corretamente os seguintes campos:" + Environment.NewLine);

            foreach (var item in list)
            {
                if (item.Key is ComboBox)
                {
                    if (((ComboBox)item.Key).SelectedIndex != -1)
                    {
                        invalidMessage.AppendLine(item.Value);
                    }
                }
                else if (item.Key is VisualTextBox)
                {
                    if (String.IsNullOrEmpty(item.Key.Text))
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
                Dificulty = (DificultyLevel)CbxDificulty.SelectedItem,
                Description = RtbxHelp.Text,
                Architecture = ArchitectureMode.x86_32,
                DynamicBase = ChkDynamicBase.Checked,
                FileLocation = TbxFilePath.Text,
                AnswerAddress = Convert.ToUInt32(TbxAnswerAddress.Text),
                Order = NupOrder.Value,
                Finished = false,
                Addresses = new Dictionary<string, uint>().AsLazyDictionary()
            };

            File.WriteAllBytes(newChallenge.FileLocation.Replace(".exe", ".hck"), ZeroFormatterSerializer.Serialize(newChallenge));
        }

        #endregion
    }
}
