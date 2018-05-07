using HArCKtecture.Classes;
using HArCKtecture.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using TheArtOfDev.HtmlRenderer.Core.Entities;
using VisualPlus.Toolkit.Dialogs;

namespace HArCKtecture.Forms
{
    public partial class FrmHelp : VisualForm
    {
        #region Property

        private Challenge LoadedChallenge { get; set; }

        #endregion

        #region Constructor

        public FrmHelp(Challenge challenge)
        {
            LoadedChallenge = challenge;

            InitializeComponent();

            HtmlPainel.ImageLoad += HtmlPainel_ImageLoad;
            HtmlPainel.RenderError += HtmlPainel_RenderError;
        }

        #endregion

        #region Events

        private void FrmIntroduction_Load(object sender, System.EventArgs e)
        {
            HtmlPainel.Text = Globals.BASE_HELP_HTML;

            if (LoadedChallenge != null)
            {
                HtmlPainel.Text = HtmlPainel.Text.Replace("{Title}", LoadedChallenge.Name)
               .Replace("{Description}", LoadedChallenge.Description);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void HtmlPainel_RenderError(object sender, HtmlRenderErrorEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void HtmlPainel_ImageLoad(object sender, HtmlImageLoadEventArgs e)
        {
            var image = Resources.ResourceManager.GetObject(e.Src);

            e.Callback(image);
        }

        #endregion
    }
}
