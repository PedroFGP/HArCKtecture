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
                Description = @" Com esse desafio o objetivo é enteder um pouco mais sobre adição em assembly x86.",
                Architecture = ArchitectureMode.x86_32,
                DynamicBase = false,
                FileLocation = @"Challenges/Challenge01.exe",
                Addresses = new Dictionary<string, uint>() { { "Principal", 0x0 } }.AsLazyDictionary()
            };

            Challenge chl02 = new Challenge()
            {
                Name = "Desafio 02 - Adição em Assembly",
                Dificulty = DificultyLevel.MEDIUM,
                Description = @" Com esse desafio o objetivo é enteder um pouco mais sobre adição em assembly x86.",
                Architecture = ArchitectureMode.x86_32,
                DynamicBase = false,
                FileLocation = @"Challenges/Challenge02.exe",
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

        #endregion

        #region Methods

        private void LoadChallenges()
        {
            Directory.CreateDirectory("Challenges");

            List<Challenge> challenges = new List<Challenge>();

            foreach (string file in Directory.EnumerateFiles("Challenges", "*.hck*", SearchOption.AllDirectories))
            {
                challenges.Add(ZeroFormatterSerializer.Deserialize<Challenge>(File.ReadAllBytes(file)));
            }

            foreach (Challenge clg in challenges)
            {
                UcChallenge challengeUc = new UcChallenge(clg);

                challengeUc.Width = flowLayoutPanel1.Size.Width - 10;

                if(flowLayoutPanel1.Controls.Count % 2 == 0)
                {
                    challengeUc.BackColor = Color.LightGray;
                }

                flowLayoutPanel1.Controls.Add(challengeUc);
            }
        }

        #endregion
    }
}
