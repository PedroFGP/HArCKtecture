using HArCKtecture.Classes;
using HArCKtecture.User_Controls;
using System.Drawing;
using System.Windows.Forms;
using VisualPlus.Toolkit.Dialogs;

namespace HArCKtecture.Forms
{
    public partial class FrmChallenge : VisualForm
    {
        public Challenge LoadedChallenge;
        private UcMemoryViewer MemoryViewer;
        private FrmHelp FormHelp;


        #region Constructor

        public FrmChallenge(Challenge challenge)
            :base()
        {
            LoadedChallenge = challenge;

            FormHelp = new FrmHelp(LoadedChallenge);

            InitializeComponent();

            LoadMemoryViewer();

            this.ControlBox.HelpButton.Click += HelpButton_Click;
        }

        #endregion

        #region Events

        private void HelpButton_Click(object sender, System.EventArgs e)
        {
            FormHelp = new FrmHelp(LoadedChallenge);

            FormHelp.Show();
            FormHelp.Focus();
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
        }

        #endregion
    }
}
