namespace HArCKtecture.User_Controls
{
    partial class UcChallengeItem
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
            VisualPlus.Structure.TextStyle textStyle5 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle4 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle3 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle2 = new VisualPlus.Structure.TextStyle();
            this.BtnPlay = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.BgeLevel = new VisualPlus.Toolkit.Components.VisualBadge(this.components);
            this.LblChallengeTitle = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.GbxDetails = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.LblTimeTaken = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.GbxDetails.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnPlay
            // 
            this.BtnPlay.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.BtnPlay.Location = new System.Drawing.Point(418, 3);
            this.BtnPlay.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(112, 20);
            this.BtnPlay.TabIndex = 1;
            this.BtnPlay.Text = "Jogar";
            this.BtnPlay.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnPlay.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle1.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle1.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle1.Hover = System.Drawing.Color.Empty;
            textStyle1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnPlay.TextStyle = textStyle1;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BgeLevel
            // 
            this.BgeLevel.Background = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.BgeLevel.Control = this;
            this.BgeLevel.Enabled = true;
            this.BgeLevel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.BgeLevel.ForeColor = System.Drawing.Color.White;
            this.BgeLevel.Location = new System.Drawing.Point(25, 3);
            this.BgeLevel.Shape.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.BgeLevel.Shape.Rounding = 6;
            this.BgeLevel.Shape.Thickness = 1;
            this.BgeLevel.Shape.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.BgeLevel.Shape.Visible = true;
            this.BgeLevel.Size = new System.Drawing.Size(80, 20);
            this.BgeLevel.Text = "Fácil";
            // 
            // LblChallengeTitle
            // 
            this.LblChallengeTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LblChallengeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblChallengeTitle.Location = new System.Drawing.Point(113, 3);
            this.LblChallengeTitle.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.LblChallengeTitle.Name = "LblChallengeTitle";
            this.LblChallengeTitle.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LblChallengeTitle.Outline = false;
            this.LblChallengeTitle.OutlineColor = System.Drawing.Color.Red;
            this.LblChallengeTitle.OutlineLocation = new System.Drawing.Point(0, 0);
            this.LblChallengeTitle.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblChallengeTitle.ReflectionSpacing = 0;
            this.LblChallengeTitle.ShadowColor = System.Drawing.Color.Black;
            this.LblChallengeTitle.ShadowDirection = 315;
            this.LblChallengeTitle.ShadowLocation = new System.Drawing.Point(0, 0);
            this.LblChallengeTitle.ShadowOpacity = 100;
            this.LblChallengeTitle.Size = new System.Drawing.Size(299, 20);
            this.LblChallengeTitle.TabIndex = 2;
            this.LblChallengeTitle.Text = "visualLabel1";
            this.LblChallengeTitle.TextAlignment = System.Drawing.StringAlignment.Near;
            this.LblChallengeTitle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle5.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle5.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle5.Hover = System.Drawing.Color.Empty;
            textStyle5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.LblChallengeTitle.TextStyle = textStyle5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::HArCKtecture.Properties.Resources.caret_down;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 15);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // GbxDetails
            // 
            this.GbxDetails.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GbxDetails.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.GbxDetails.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.GbxDetails.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.GbxDetails.Border.HoverVisible = true;
            this.GbxDetails.Border.Rounding = 6;
            this.GbxDetails.Border.Thickness = 1;
            this.GbxDetails.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.GbxDetails.Border.Visible = true;
            this.GbxDetails.BoxStyle = VisualPlus.Toolkit.Controls.Layout.VisualGroupBox.GroupBoxStyle.Default;
            this.GbxDetails.Controls.Add(this.visualLabel1);
            this.GbxDetails.Controls.Add(this.LblTimeTaken);
            this.GbxDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GbxDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GbxDetails.Image = null;
            this.GbxDetails.Location = new System.Drawing.Point(3, 3);
            this.GbxDetails.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.GbxDetails.Name = "GbxDetails";
            this.GbxDetails.Padding = new System.Windows.Forms.Padding(5, 26, 5, 5);
            this.GbxDetails.Separator = true;
            this.GbxDetails.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.GbxDetails.Size = new System.Drawing.Size(525, 111);
            this.GbxDetails.TabIndex = 4;
            this.GbxDetails.Text = "visualGroupBox1";
            this.GbxDetails.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GbxDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GbxDetails.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle4.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle4.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle4.Hover = System.Drawing.Color.Empty;
            textStyle4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.GbxDetails.TextStyle = textStyle4;
            this.GbxDetails.TitleBoxHeight = 25;
            // 
            // LblTimeTaken
            // 
            this.LblTimeTaken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LblTimeTaken.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LblTimeTaken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTimeTaken.Location = new System.Drawing.Point(14, 26);
            this.LblTimeTaken.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.LblTimeTaken.Name = "LblTimeTaken";
            this.LblTimeTaken.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LblTimeTaken.Outline = false;
            this.LblTimeTaken.OutlineColor = System.Drawing.Color.Red;
            this.LblTimeTaken.OutlineLocation = new System.Drawing.Point(0, 0);
            this.LblTimeTaken.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTimeTaken.ReflectionSpacing = 0;
            this.LblTimeTaken.ShadowColor = System.Drawing.Color.Black;
            this.LblTimeTaken.ShadowDirection = 315;
            this.LblTimeTaken.ShadowLocation = new System.Drawing.Point(0, 0);
            this.LblTimeTaken.ShadowOpacity = 100;
            this.LblTimeTaken.Size = new System.Drawing.Size(75, 23);
            this.LblTimeTaken.TabIndex = 1;
            this.LblTimeTaken.Text = "Tempo gasto:";
            this.LblTimeTaken.TextAlignment = System.Drawing.StringAlignment.Near;
            this.LblTimeTaken.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle3.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle3.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle3.Hover = System.Drawing.Color.Empty;
            textStyle3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.LblTimeTaken.TextStyle = textStyle3;
            // 
            // visualLabel1
            // 
            this.visualLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.Location = new System.Drawing.Point(14, 64);
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
            this.visualLabel1.Size = new System.Drawing.Size(75, 23);
            this.visualLabel1.TabIndex = 2;
            this.visualLabel1.Text = "visualLabel1";
            this.visualLabel1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.visualLabel1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle2.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle2.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle2.Hover = System.Drawing.Color.Empty;
            textStyle2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel1.TextStyle = textStyle2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.GbxDetails);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(535, 116);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // UcChallengeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblChallengeTitle);
            this.Controls.Add(this.BtnPlay);
            this.Name = "UcChallengeItem";
            this.Size = new System.Drawing.Size(535, 143);
            this.Load += new System.EventHandler(this.UcChallenge_Load);
            this.GbxDetails.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnPlay;
        private VisualPlus.Toolkit.Components.VisualBadge BgeLevel;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel LblChallengeTitle;
        private System.Windows.Forms.Button button1;
        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox GbxDetails;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel LblTimeTaken;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel1;
    }
}
