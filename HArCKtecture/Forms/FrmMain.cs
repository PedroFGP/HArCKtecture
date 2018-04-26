using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using HArCKtecture.Classes;
using ZeroFormatter;
using HArCKtecture.User_Controls;
using System.Drawing;
using VisualPlus.Toolkit.Dialogs;

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

        #endregion

        #region Methods

        private void LoadChallenges()
        {
            FlpChallenges.Controls.Clear();

            Directory.CreateDirectory(Globals.DIRECTORY_NAME);

            List<Challenge> challenges = new List<Challenge>();

            foreach (string file in Directory.EnumerateFiles(Globals.DIRECTORY_NAME, "*.hck*", SearchOption.AllDirectories))
            {
                challenges.Add(ZeroFormatterSerializer.Deserialize<Challenge>(File.ReadAllBytes(file)));
            }

            var highestChallengeOrder = challenges.Where(chl => chl.Finished == true).OrderByDescending(chl => chl.Order).FirstOrDefault();

            if(highestChallengeOrder == null)
            {
                highestChallengeOrder = challenges.OrderByDescending(chl => chl.Order).FirstOrDefault();
            }

            var challengesOrder = challenges.GroupBy(chg => chg.Order).Select(chg => new
            {
                Order = chg.Key,
                Items = chg.ToList()
            });

            var orderColors = new List<dynamic>();

            foreach(var order in challengesOrder)
            {
                orderColors.Add(new
                {
                    Color = UniqueColorGenerator.Next(),
                    order.Items
                });
            }

            long highestOrder = 0;

            if(highestChallengeOrder != null)
            {
                highestOrder = highestChallengeOrder.Order;
            }

            int totalChallenges = challenges.Count();
            int completedChallenges = challenges.Count(chg => chg.Finished);

            LblAvailableChallenges.Text = string.Format(LblAvailableChallenges.Text, completedChallenges, totalChallenges);

            foreach (Challenge clg in challenges.OrderBy(chg => chg.Order).ToList())
            {
                UcChallengeItem challengeUc = new UcChallengeItem(clg)
                {
                    Width = FlpChallenges.Size.Width - 10
                };

                var orderColor = orderColors.FirstOrDefault(chg => chg.Items.Contains(clg));

                if(orderColor != null)
                {
                    var pnlColor = (Panel)challengeUc.Controls.Find("PnlColor", true).First();

                    pnlColor.BackColor = orderColor.Color;
                }

                if (FlpChallenges.Controls.Count % 2 == 0)
                {
                    challengeUc.BackColor = Color.LightGray;
                }

                if(clg.Finished)
                {
                    var btn = challengeUc.Controls.Find("BtnPlay", true).First();

                    if(btn != null)
                    {
                        btn.Text = "Jogar Novamente";
                    }
                }

                if(clg.Order > highestOrder)
                {
                    challengeUc.Enabled = false;
                }

                FlpChallenges.Controls.Add(challengeUc);
            }
        }

        #endregion
    }
}
