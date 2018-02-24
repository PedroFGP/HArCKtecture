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

            Challenge chl01 = new Challenge()
            {
                Name = "Desafio 01 - Adição em Assembly",
                Dificulty = DificultyLevel.VERY_EASY,
                Description = "Com esse desafio o objetivo é enteder um pouco mais sobre adição em assembly x86.",
                Architecture = ArchitectureMode.x86_32,
                DynamicBase = false,
                FileLocation = "Challenges/Challenge01.exe",
                Addresses = new Dictionary<string, uint>() { { "Principal", 0x0 } }.AsLazyDictionary()
            };

            Challenge chl02 = new Challenge()
            {
                Name = "Desafio 02 - Adição em Assembly",
                Dificulty = DificultyLevel.MEDIUM,
                Description = "Com esse desafio o objetivo é enteder um pouco mais sobre adição em assembly x86.",
                Architecture = ArchitectureMode.x86_32,
                DynamicBase = false,
                FileLocation = "Challenges/Challenge02.exe",
                Addresses = new Dictionary<string, uint>() { { "Principal", 0x0 } }.AsLazyDictionary()
            };

            var data = ZeroFormatterSerializer.Serialize(chl02);

            File.WriteAllBytes(chl02.FileLocation.Replace(".exe", ".hck"), data);
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

                FlpChallenges.Controls.Add(challengeUc);
            }
        }

        #endregion 
    }
}
