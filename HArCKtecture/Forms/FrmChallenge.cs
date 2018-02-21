using HArCKtecture.Classes;
using VisualPlus.Toolkit.Controls.Layout;

namespace HArCKtecture.Forms
{
    public partial class FrmChallenge : VisualForm
    {
        Challenge LoadedChallenge;

        #region Constructor

        public FrmChallenge(Challenge challenge)
            :base()
        {
            LoadedChallenge = challenge;

            InitializeComponent();
        }

        #endregion

        #region Events

        private void FrmChallenge_Load(object sender, System.EventArgs e)
        {

        }

        #endregion

        #region Methods

        #endregion
    }
}
