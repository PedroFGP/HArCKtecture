using System;
using System.Drawing;
using System.Windows.Forms;
using HArCKtecture.Classes;
using HArCKtecture.Forms;

namespace HArCKtecture.User_Controls
{
    public partial class UcChallenge : UserControl
    {
        private Challenge LoadedChallenge;

        #region Constructor

        public UcChallenge(Challenge challenge)
        {
            LoadedChallenge = challenge;

            InitializeComponent();
        }

        #endregion

        #region Events

        private void UcChallenge_Load(object sender, EventArgs e)
        {
            var descriptions = LoadedChallenge.Dificulty.GetDescriptionsList();

            BgeLevel.Background = ColorTranslator.FromHtml(descriptions[1]);
            BgeLevel.Text = descriptions[0];
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            FrmChallenge challengeForm = new FrmChallenge(LoadedChallenge);

            challengeForm.Show();
        }

        #endregion

        #region Methods

        #endregion
    }
}
