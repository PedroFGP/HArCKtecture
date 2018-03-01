using VisualPlus.Toolkit.Dialogs;

namespace HArCKtecture.Forms
{
    public partial class FrmAbout : VisualForm
    {
        #region Constructor

        public FrmAbout()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void BtnBack_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
