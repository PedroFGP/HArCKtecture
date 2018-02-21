namespace HArCKtecture.User_Controls
{
    partial class UcChallenge
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
            VisualPlus.Structure.TextStyle textStyle3 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle1 = new VisualPlus.Structure.TextStyle();
            this.BtnPlay = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.BgeLevel = new VisualPlus.Toolkit.Components.VisualBadge(this.components);
            this.visualLabel1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.SuspendLayout();
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnPlay.BackColorState.Enabled = System.Drawing.Color.Gainsboro;
            this.BtnPlay.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnPlay.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnPlay.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.BtnPlay.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.BtnPlay.Border.HoverVisible = true;
            this.BtnPlay.Border.Rounding = 8;
            this.BtnPlay.Border.Thickness = 1;
            this.BtnPlay.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.BtnPlay.Border.Visible = true;
            this.BtnPlay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnPlay.Image = null;
            this.BtnPlay.Location = new System.Drawing.Point(432, 3);
            this.BtnPlay.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(98, 20);
            this.BtnPlay.TabIndex = 1;
            this.BtnPlay.Text = "Jogar";
            this.BtnPlay.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnPlay.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle3.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle3.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle3.Hover = System.Drawing.Color.Empty;
            textStyle3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnPlay.TextStyle = textStyle3;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BgeLevel
            // 
            this.BgeLevel.Background = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.BgeLevel.Control = this;
            this.BgeLevel.Enabled = true;
            this.BgeLevel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.BgeLevel.ForeColor = System.Drawing.Color.White;
            this.BgeLevel.Location = new System.Drawing.Point(5, 3);
            this.BgeLevel.Shape.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.BgeLevel.Shape.Rounding = 6;
            this.BgeLevel.Shape.Thickness = 1;
            this.BgeLevel.Shape.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.BgeLevel.Shape.Visible = true;
            this.BgeLevel.Size = new System.Drawing.Size(80, 20);
            this.BgeLevel.Text = "Fácil";
            // 
            // visualLabel1
            // 
            this.visualLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.Location = new System.Drawing.Point(93, 3);
            this.visualLabel1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel1.Name = "visualLabel1";
            this.visualLabel1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel1.Outline = false;
            this.visualLabel1.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel1.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel1.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.ReflectionSpacing = 0;
            this.visualLabel1.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel1.ShadowDirection = 315;
            this.visualLabel1.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel1.ShadowOpacity = 100;
            this.visualLabel1.Size = new System.Drawing.Size(333, 20);
            this.visualLabel1.TabIndex = 2;
            this.visualLabel1.Text = "visualLabel1";
            this.visualLabel1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.visualLabel1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle1.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle1.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle1.Hover = System.Drawing.Color.Empty;
            textStyle1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel1.TextStyle = textStyle1;
            // 
            // UcChallenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.visualLabel1);
            this.Controls.Add(this.BtnPlay);
            this.Name = "UcChallenge";
            this.Size = new System.Drawing.Size(533, 26);
            this.Load += new System.EventHandler(this.UcChallenge_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnPlay;
        private VisualPlus.Toolkit.Components.VisualBadge BgeLevel;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel1;
    }
}
