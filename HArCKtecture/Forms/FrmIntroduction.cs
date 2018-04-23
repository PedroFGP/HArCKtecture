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
       <body style='font: 10pt Tahoma'>
    <table style='border: 1px solid maroon; margin-top: 5px'>
        <tr style='vertical-align: top;'>
            <td width='32' style='padding: 2px 0 0 0'>
                <img src='info' />
            </td>
            <td>This <i>text</i> is inside a <b>table</b> <u>element</u>.<br />
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur ornare mollis elit.
            </td>
        </tr>
    </table>
    <ul style='margin-top: 5px'>
        <li><span style='color: red'>Colors</span></li>
        <li><span style='background-color: #8dd'>Back colors</span></li>
    </ul>
</body>";

        #endregion

        #region Constructor

        public FrmIntroduction(Challenge challenge)
        {
            LoadedChallenge = challenge;

            InitializeComponent();

            HtmlPainel.ImageLoad += HtmlPainel_ImageLoad;
            HtmlPainel.RenderError += HtmlPainel_RenderError;
            HtmlPainel.Validated += HtmlPainel_Validated;
        }

        private void HtmlPainel_Validated(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
