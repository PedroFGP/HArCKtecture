using System.Windows.Forms;
using VisualPlus.Toolkit.Controls.Layout;

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
            SetupAddressesList();
        }

        private void BtnRemove_Click(object sender, System.EventArgs e)
        {

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

            if(dialogResult == DialogResult.OK)
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
            
        }

        #endregion

        #region Methods

        private void CreateChallenge()
        {

        }

        private void SetupAddressesList()
        {
            LsvAddresses.Items.Add(new ListViewItem(new string[] { "Resposta", "" }));
        }

        #endregion
    }
}
