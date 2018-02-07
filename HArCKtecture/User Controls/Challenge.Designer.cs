namespace HArCKtecture.User_Controls
{
    partial class Challenge
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            VisualPlus.Structure.TextStyle textStyle1 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle2 = new VisualPlus.Structure.TextStyle();
            this.visualPanel1 = new VisualPlus.Toolkit.Controls.Layout.VisualPanel();
            this.BtnPlay = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.SuspendLayout();
            // 
            // visualPanel1
            // 
            this.visualPanel1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.visualPanel1.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualPanel1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.visualPanel1.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualPanel1.Border.HoverVisible = true;
            this.visualPanel1.Border.Rounding = 6;
            this.visualPanel1.Border.Thickness = 1;
            this.visualPanel1.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualPanel1.Border.Visible = true;
            this.visualPanel1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualPanel1.Location = new System.Drawing.Point(35, 20);
            this.visualPanel1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualPanel1.Name = "visualPanel1";
            this.visualPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.visualPanel1.Size = new System.Drawing.Size(180, 180);
            this.visualPanel1.TabIndex = 0;
            this.visualPanel1.Text = "visualPanel1";
            textStyle1.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle1.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle1.Hover = System.Drawing.Color.Empty;
            textStyle1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualPanel1.TextStyle = textStyle1;
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnPlay.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.BtnPlay.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnPlay.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnPlay.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.BtnPlay.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.BtnPlay.Border.HoverVisible = true;
            this.BtnPlay.Border.Rounding = 8;
            this.BtnPlay.Border.Thickness = 1;
            this.BtnPlay.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.BtnPlay.Border.Visible = true;
            this.BtnPlay.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BtnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnPlay.Image = null;
            this.BtnPlay.Location = new System.Drawing.Point(77, 211);
            this.BtnPlay.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(98, 26);
            this.BtnPlay.TabIndex = 1;
            this.BtnPlay.Text = "Jogar";
            this.BtnPlay.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnPlay.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle2.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle2.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle2.Hover = System.Drawing.Color.Empty;
            textStyle2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnPlay.TextStyle = textStyle2;
            // 
            // Challenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.visualPanel1);
            this.Name = "Challenge";
            this.Size = new System.Drawing.Size(248, 248);
            this.ResumeLayout(false);

        }

        #endregion

        private VisualPlus.Toolkit.Controls.Layout.VisualPanel visualPanel1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnPlay;
    }
}
