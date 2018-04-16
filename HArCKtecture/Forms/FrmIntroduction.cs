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

        private static readonly Dictionary<string, Image> ImageCache = new Dictionary<string, Image>(StringComparer.OrdinalIgnoreCase);

        private Challenge LoadedChallenge { get; set; }

        private static string html2 = @"
<html>
    <head>
    </head>
  <body style='display: flex;
  justify-items: center;
  justify-content: center;'>
    <div style='height: 20%; width: 60%; display: flex;position: relative;
    margin: .5rem 0 1rem 0;
    background-color: rgb(220,220,220);
    -webkit-transition: -webkit-box-shadow .25s;
    transition: -webkit-box-shadow .25s;
    transition: box-shadow .25s;
    transition: box-shadow .25s, -webkit-box-shadow .25s;
    border-radius: 2px;box-shadow: 0 2px 2px 0 rgba(0,0,0,0.14), 0 3px 1px -2px rgba(0,0,0,0.12), 0 1px 5px 0 rgba(0,0,0,0.2);   
    -webkit-box-sizing: inherit;
    box-sizing: inherit;'>
        <div style=' height: 57%;
        width: 91%;
        display: flex;
        align-items: center;
        padding: 24px;
        border-radius: 0 0 2px 2px;'>
            <div><img src='info' alt=''></div>
            <div style='font-size: 1em; padding-left: 5%'>
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut 
                labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation 
                ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor 
                in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. 
                Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
            </div>
        </div>
      </div>

  </body> 
</html>";

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
            HtmlPainel.Text = html2;
            if(LoadedChallenge != null)
            {
                HtmlPainel.Text = HtmlPainel.Text.Replace("{0}", LoadedChallenge.Name)
               .Replace("{1}", LoadedChallenge.Description);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Methods

        private void HtmlPainel_RenderError(object sender, HtmlRenderErrorEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void HtmlPainel_ImageLoad(object sender, HtmlImageLoadEventArgs e)
        {
            var img = TryLoadResourceImage(e.Src);

            if(img != null)
            {
                e.Callback(img);
            }
        }

        private Image TryLoadResourceImage(string src)
        {
            if (!ImageCache.TryGetValue(src, out Image image))
            {
                var imageStream = GetType().Assembly.GetManifestResourceStream("HArCKtecture.Properties.Resources.resources." + src + ".png");
                if (imageStream != null)
                {
                    image = System.Drawing.Image.FromStream(imageStream);
                    ImageCache[src] = image;
                }
            }
            return image;
        }

        #endregion
    }
}
