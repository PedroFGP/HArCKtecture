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

        private static string baseHTML = @"
        <html>
        <style>
        table {
            border-collapse: collapse;
            width: 100%;
        }

        td, th {
            border: 1px solid #dddddd;
            text-align: left;
            padding: 8px;
        }

        tr:nth-child(even) {
            background-color: #dddddd;
        }
        </style>
        <meta http-equiv='Content-Type' content='text/html; charset=utf-8'>
        <body style='font: 12pt Segoe UI;'>
            <h1 style='font: 16pt Segoe UI; text-align: center;'>{Title}</h1>
            <table style='border: 2px solid black; margin: 0px auto;' align='center'>
            <tr style='vertical-align: middle; text-align: center;'>
                <td style='padding: 5px; vertical-align: top;'>
                    <img src='info'/>
                </td>
                <td style='padding: 5px;'>
                    {Description}
                </td>
            </tr>
            </table>
        </body>
        </html>";

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
            HtmlPainel.Text = baseHTML;

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
