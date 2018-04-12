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
        private UcMemoryViewer MemoryViewer;
        private FrmIntroduction frmIntro;

        #region Constructor

        public FrmChallenge(Challenge challenge)
            :base()
        {
            LoadedChallenge = challenge;

            frmIntro = new FrmIntroduction(LoadedChallenge);

            InitializeComponent();

            LoadMemoryViewer();
        }

        #endregion

        #region Events

        private void FrmChallenge_Load(object sender, System.EventArgs e)
        {
            frmIntro.Show();
        }

        #endregion

        #region Methods

        private void LoadMemoryViewer()
        {
            this.Text = LoadedChallenge.Name;

            MemoryViewer = new UcMemoryViewer(LoadedChallenge)
            {
                Dock = DockStyle.Fill
            };

            this.MainPanel.Controls.Add(MemoryViewer);

            var a = MainPanel.Size;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                frmIntro.Show();
            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
    }
}
