using System.Windows.Forms;
using System.Linq;
using VisualPlus.Toolkit.Controls.Layout;
using System.IO;
using System.Collections.Generic;
using HArCKtecture.Classes;
using ZeroFormatter;
using HArCKtecture.User_Controls;
using System.Drawing;

namespace HArCKtecture.Forms
{
    public partial class FrmMain : VisualForm
    {
        private const string DIRECTORY_NAME = "Desafios";

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

            this.Hide();
        }

        #endregion

        #region Methods

        private void LoadChallenges()
        {
            Directory.CreateDirectory(DIRECTORY_NAME);

            List<Challenge> challenges = new List<Challenge>();

            foreach (string file in Directory.EnumerateFiles(DIRECTORY_NAME, "*.hck*", SearchOption.AllDirectories))
            {
                challenges.Add(ZeroFormatterSerializer.Deserialize<Challenge>(File.ReadAllBytes(file)));
            }

            var highestChallengeOrder = challenges.Where(chl => chl.Finished == true).OrderByDescending(chl => chl.Order).FirstOrDefault();

            long highestOrder = 0;

            if(highestChallengeOrder != null)
            {
                highestOrder = highestChallengeOrder.Order;
            }

            foreach (Challenge clg in challenges)
            {
                UcChallengeItem challengeUc = new UcChallengeItem(clg)
                {
                    Width = FlpChallenges.Size.Width - 25
                };

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
