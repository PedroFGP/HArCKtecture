using VisualPlus.Toolkit.Dialogs;

namespace HArCKtecture.Forms
{
    public partial class FrmAbout : VisualForm
    {
        #region Constructor

        public FrmAbout()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void BtnBack_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void FrmAbout_Load(object sender, System.EventArgs e)
        {
            RTbxAbout.Text = @"Ícones:

- Smashicons, www.flaticon.com licenciado por CC 3.0 BY

- Freepik, www.flaticon.com licenciado por CC 3.0 BY

Desenvolvido por:

- Pedro Ferreira Glenadel Pereira

Bibliotecas utilizadas:

- SharpDisasm

- VisualPlus

- MemorySharp

- MessagePack

- Fasm.NET";
        }

        #endregion
    }
}
