using System.Windows.Forms;
using System.Linq;
using VisualPlus.Toolkit.Controls.Layout;
using System.IO;

namespace HArCKtecture.Forms
{
    public partial class FrmMain : VisualForm
    {
        #region Constructor

        public FrmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void FrmMain_Load(object sender, System.EventArgs e)
        {
            LoadChallenges();
        }

        private void LblAbout_Click(object sender, System.EventArgs e)
        {
            FrmAbout aboutForm = (FrmAbout)Application.OpenForms.Cast<Form>().FirstOrDefault(form => form is FrmAbout);

            if(aboutForm == null)
            {
                aboutForm = new FrmAbout();
            }

            aboutForm.Show();
            aboutForm.Focus();
        }

        #endregion

        #region Methods

        private void LoadChallenges()
        {
            Directory.CreateDirectory("Challenges");

            
        }

        #endregion
    }
}
