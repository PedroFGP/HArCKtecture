using VisualPlus.Toolkit.Dialogs;

namespace HArCKtecture.Forms
{
    public partial class FrmIntroduction : VisualForm
    {
        #region Property

        private static string baseHTML = @"<!DOCTYPE html><html><body><h1 style='text-align: center;'>{0}</h1></body></html>";

        #endregion

        #region Constructor

        public FrmIntroduction()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void FrmIntroduction_Load(object sender, System.EventArgs e)
        {
            HtmlPainel.Text = string.Format(baseHTML, "Desafio 01 - Adição");
        }

        #endregion

        #region Methods

        #endregion
    }
}
