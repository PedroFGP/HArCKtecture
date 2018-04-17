using HArCKtecture.Classes;
using HArCKtecture.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using TheArtOfDev.HtmlRenderer.Core.Entities;
using VisualPlus.Toolkit.Dialogs;

namespace HArCKtecture.Forms
{
    public partial class FrmIntroduction : VisualForm
    {
        #region Property

        private Challenge LoadedChallenge { get; set; }

        private static string baseHTML = @"
        <!DOCTYPE html>
        <html>
        <style>
            h1 {
                font-family: Segoe UI;
                font-size: 28px;
                font-style: bold;
                font-variant: normal;
                font-weight: 400;
                line-height: 28px;
            }
            p {
                font-family: Segoe UI;
                font-size: 16px;
                font-style: normal;
                font-variant: normal;
                font-weight: 400;
                line-height: 16px;
            }
        </style>
        <body bgcolor='#DCDCDC'>
            <h1 style='text-align: center;'>{0}</h1>
            <div><img src='info'></div>
            <div style='padding-top:5px'>
                <p style='text-align: center;'>{1}</p>
            </div>
        </body>
        </html>";

        #endregion

        #region Constructor

        public FrmIntroduction(Challenge challenge)
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
            HtmlPainel.Text = baseHTML;

            if (LoadedChallenge != null)
            {
                HtmlPainel.Text = HtmlPainel.Text.Replace("{0}", LoadedChallenge.Name)
               .Replace("{1}", LoadedChallenge.Description);
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
