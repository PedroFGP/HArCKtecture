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

            LoadMemoryViewer();
        }

        #endregion

        #region Events

        private void FrmChallenge_Load(object sender, System.EventArgs e)
        {
            
        }

        #endregion

        #region Methods

        private void LoadMemoryViewer()
        {
            this.Text = LoadedChallenge.Name;
            
            var memoryViewer = new UcMemoryViewer(LoadedChallenge)
            {
                Location = new Point(2, 30),
                Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom)
            };

            this.Controls.Add(memoryViewer);
        }

        #endregion
    }
}
