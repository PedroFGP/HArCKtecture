using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using HArCKtecture.Classes;
using HArCKtecture.User_Controls;
using System.Drawing;
using VisualPlus.Toolkit.Dialogs;
using System;
using MessagePack;
using System.Globalization;
using HArCKtecture.Properties;

namespace HArCKtecture.Forms
{
    public partial class FrmMain : VisualForm
    {
        #region Properties

        List<Challenge> Challenges = new List<Challenge>();
        private FrmTutorial FormTutorial;

        #endregion

        #region Constructor

        public FrmMain()
        {
            InitializeComponent();

            this.ControlBox.HelpButton.Click += HelpButton_Click;
        }

        #endregion

        #region Events

        private void HelpButton_Click(object sender, EventArgs e)
        {
            FormTutorial = new FrmTutorial();

            FormTutorial.Show();
            FormTutorial.Focus();
        }

        private void FrmMain_Load(object sender, System.EventArgs e)
        {
            LoadChallenges();

            TmrCheckChallengeFinished.Start();
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            if (Settings.Default.FirstRun)
            {
                this.Enabled = false;

                MessageBox.Show(this, "Já que é a primeira vez que você abre o HArCKtecture vamos apresentar um pequeno tutorial.", "Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormTutorial = new FrmTutorial();

                FormTutorial.ShowDialog();
                FormTutorial.Focus();

                this.Enabled = true;

                Settings.Default.FirstRun = false;
                Settings.Default.Save();
            }
        }

        private void LblAbout_Click(object sender, System.EventArgs e)
        {
            FrmAbout aboutForm = (FrmAbout)Application.OpenForms.Cast<Form>().FirstOrDefault(form => form is FrmAbout);

            if (aboutForm == null)
            {
                aboutForm = new FrmAbout();
            }

            aboutForm.Show();
            aboutForm.Focus();
        }

        private void BtnCreateChallenge_Click(object sender, System.EventArgs e)
        {
            FrmCreateChallenge createForm = new FrmCreateChallenge();

            createForm.Show();
            createForm.Focus();

            createForm.FormClosed += (s, eventArgs) =>
            {
                LoadChallenges();
            };
        }

        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void BtnResetChallenges_Click(object sender, System.EventArgs e)
        {
            foreach (var challenge in Challenges)
            {
                challenge.Finished = false;
                challenge.TotalTime = TimeSpan.Zero;
                challenge.Operations = new List<Operation>();
                challenge.RemoteProcessCrashes = 0;
                challenge.Cheated = false;

                challenge.Save();
            }

            LoadChallenges();
        }

        private void TmrCheckChallengeFinished_Tick(object sender, EventArgs e)
        {
            if (Globals.ResetChallenges)
            {
                LoadChallenges();
            }
        }

        #endregion

        #region Methods

        private void LoadChallenges()
        {
            Globals.ResetChallenges = false;
            Challenges.Clear();
            FlpChallenges.Controls.Clear();

            Directory.CreateDirectory(Globals.DIRECTORY_NAME);

            foreach (string file in Directory.EnumerateFiles(Globals.DIRECTORY_NAME, "*.hck*", SearchOption.AllDirectories))
            {
                Challenges.Add(MessagePackSerializer.Deserialize<Challenge>(File.ReadAllBytes(file)));
            }

            var highestChallengeOrder = Challenges.Where(chl => chl.Finished == true).OrderByDescending(chl => chl.Order).FirstOrDefault();

            if (highestChallengeOrder == null)
            {
                highestChallengeOrder = Challenges.OrderByDescending(chl => chl.Order).FirstOrDefault();
            }

            var challengesOrder = Challenges.GroupBy(chg => chg.Order).Select(chg => new
            {
                Order = chg.Key,
                Items = chg.ToList()
            });

            var orderColors = new List<dynamic>();

            foreach (var order in challengesOrder)
            {
                orderColors.Add(new
                {
                    Color = UniqueColorGenerator.Next(),
                    order.Items
                });
            }

            long highestOrder = 0;

            if (highestChallengeOrder != null)
            {
                highestOrder = highestChallengeOrder.Order;
            }

            int totalChallenges = Challenges.Count();
            int completedChallenges = Challenges.Count(chg => chg.Finished);

            LblAvailableChallenges.Text = string.Format(Globals.AVAILABLE_CHALLENGES, completedChallenges, totalChallenges);

            foreach (Challenge clg in Challenges.OrderBy(chg => chg.Order).ToList())
            {
                UcChallengeItem challengeUc = new UcChallengeItem(clg)
                {
                    Width = FlpChallenges.Size.Width - 10
                };

                var orderColor = orderColors.FirstOrDefault(chg => chg.Items.Contains(clg));

                if (orderColor != null)
                {
                    var pnlColor = (Panel)challengeUc.Controls.Find("PnlColor", true).First();

                    pnlColor.BackColor = orderColor.Color;
                }

                if (FlpChallenges.Controls.Count % 2 == 0)
                {
                    challengeUc.BackColor = Color.LightGray;
                }

                if (clg.Finished)
                {
                    var btn = challengeUc.Controls.Find("BtnPlay", true).First();

                    if (btn != null)
                    {
                        btn.Text = "Jogar Novamente";
                    }
                }

                if (clg.Order > highestOrder)
                {
                    challengeUc.Enabled = false;
                }

                FlpChallenges.Controls.Add(challengeUc);
            }
        }

        #endregion
    }
}
