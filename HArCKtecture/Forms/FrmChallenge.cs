using HArCKtecture.Classes;
using HArCKtecture.User_Controls;
using System.Drawing;
using System.Windows.Forms;
using VisualPlus.Toolkit.Dialogs;

namespace HArCKtecture.Forms
{
    public partial class FrmChallenge : VisualForm
    {
        private Challenge LoadedChallenge;

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
            LoadMemoryViewer();
        }

        #endregion

        #region Methods

        private void LoadMemoryViewer()
        {
            UcMemoryViewer memoryViewer = new UcMemoryViewer(LoadedChallenge)
            {
                Location = new Point(2, 30),
                Anchor = AnchorStyles.Right | AnchorStyles.Bottom
            };

            this.Controls.Add(memoryViewer);
        }

        #endregion
    }
}
