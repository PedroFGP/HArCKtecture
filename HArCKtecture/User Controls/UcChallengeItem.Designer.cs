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
            VisualPlus.Structure.TextStyle textStyle7 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle6 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle2 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle3 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle4 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle5 = new VisualPlus.Structure.TextStyle();
            this.BtnPlay = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.BgeLevel = new VisualPlus.Toolkit.Components.VisualBadge(this.components);
            this.LblChallengeTitle = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.PnlColor = new System.Windows.Forms.Panel();
            this.GbxStatistics = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.LblCheated = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.LblCrashes = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.LblMemoryOperations = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.LblTimeTaken = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.GbxStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnPlay
            // 
            this.BtnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.BtnPlay.Location = new System.Drawing.Point(418, 4);
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
            this.BgeLevel.Location = new System.Drawing.Point(25, 4);
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
            this.LblChallengeTitle.Location = new System.Drawing.Point(108, 4);
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
            this.LblChallengeTitle.Size = new System.Drawing.Size(304, 20);
            this.LblChallengeTitle.TabIndex = 2;
            this.LblChallengeTitle.Text = "visualLabel1";
            this.LblChallengeTitle.TextAlignment = System.Drawing.StringAlignment.Near;
            this.LblChallengeTitle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle7.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle7.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle7.Hover = System.Drawing.Color.Empty;
            textStyle7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.LblChallengeTitle.TextStyle = textStyle7;
            // 
            // PnlColor
            // 
            this.PnlColor.Location = new System.Drawing.Point(0, 0);
            this.PnlColor.Name = "PnlColor";
            this.PnlColor.Size = new System.Drawing.Size(15, 28);
            this.PnlColor.TabIndex = 3;
            // 
            // GbxStatistics
            // 
            this.GbxStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxStatistics.BackColor = System.Drawing.Color.Transparent;
            this.GbxStatistics.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GbxStatistics.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.GbxStatistics.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.GbxStatistics.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.GbxStatistics.Border.HoverVisible = true;
            this.GbxStatistics.Border.Rounding = 6;
            this.GbxStatistics.Border.Thickness = 1;
            this.GbxStatistics.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.GbxStatistics.Border.Visible = true;
            this.GbxStatistics.BoxStyle = VisualPlus.Toolkit.Controls.Layout.VisualGroupBox.GroupBoxStyle.Default;
            this.GbxStatistics.Controls.Add(this.LblCheated);
            this.GbxStatistics.Controls.Add(this.LblCrashes);
            this.GbxStatistics.Controls.Add(this.LblMemoryOperations);
            this.GbxStatistics.Controls.Add(this.LblTimeTaken);
            this.GbxStatistics.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GbxStatistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GbxStatistics.Image = null;
            this.GbxStatistics.Location = new System.Drawing.Point(3, 34);
            this.GbxStatistics.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.GbxStatistics.Name = "GbxStatistics";
            this.GbxStatistics.Padding = new System.Windows.Forms.Padding(5, 26, 5, 5);
            this.GbxStatistics.Separator = true;
            this.GbxStatistics.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.GbxStatistics.Size = new System.Drawing.Size(526, 73);
            this.GbxStatistics.TabIndex = 4;
            this.GbxStatistics.Text = "Estatísticas";
            this.GbxStatistics.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GbxStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GbxStatistics.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle6.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle6.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle6.Hover = System.Drawing.Color.Empty;
            textStyle6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.GbxStatistics.TextStyle = textStyle6;
            this.GbxStatistics.TitleBoxHeight = 25;
            // 
            // LblCheated
            // 
            this.LblCheated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LblCheated.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LblCheated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblCheated.Location = new System.Drawing.Point(334, 47);
            this.LblCheated.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.LblCheated.Name = "LblCheated";
            this.LblCheated.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LblCheated.Outline = false;
            this.LblCheated.OutlineColor = System.Drawing.Color.Red;
            this.LblCheated.OutlineLocation = new System.Drawing.Point(0, 0);
            this.LblCheated.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblCheated.ReflectionSpacing = 0;
            this.LblCheated.ShadowColor = System.Drawing.Color.Black;
            this.LblCheated.ShadowDirection = 315;
            this.LblCheated.ShadowLocation = new System.Drawing.Point(0, 0);
            this.LblCheated.ShadowOpacity = 100;
            this.LblCheated.Size = new System.Drawing.Size(189, 23);
            this.LblCheated.TabIndex = 4;
            this.LblCheated.Text = "Trapaceou: ";
            this.LblCheated.TextAlignment = System.Drawing.StringAlignment.Near;
            this.LblCheated.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle2.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle2.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle2.Hover = System.Drawing.Color.Empty;
            textStyle2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.LblCheated.TextStyle = textStyle2;
            // 
            // LblCrashes
            // 
            this.LblCrashes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LblCrashes.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LblCrashes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblCrashes.Location = new System.Drawing.Point(334, 21);
            this.LblCrashes.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.LblCrashes.Name = "LblCrashes";
            this.LblCrashes.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LblCrashes.Outline = false;
            this.LblCrashes.OutlineColor = System.Drawing.Color.Red;
            this.LblCrashes.OutlineLocation = new System.Drawing.Point(0, 0);
            this.LblCrashes.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblCrashes.ReflectionSpacing = 0;
            this.LblCrashes.ShadowColor = System.Drawing.Color.Black;
            this.LblCrashes.ShadowDirection = 315;
            this.LblCrashes.ShadowLocation = new System.Drawing.Point(0, 0);
            this.LblCrashes.ShadowOpacity = 100;
            this.LblCrashes.Size = new System.Drawing.Size(189, 23);
            this.LblCrashes.TabIndex = 3;
            this.LblCrashes.Text = "Crashes ocorridos: ";
            this.LblCrashes.TextAlignment = System.Drawing.StringAlignment.Near;
            this.LblCrashes.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle3.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle3.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle3.Hover = System.Drawing.Color.Empty;
            textStyle3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.LblCrashes.TextStyle = textStyle3;
            // 
            // LblMemoryOperations
            // 
            this.LblMemoryOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LblMemoryOperations.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LblMemoryOperations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblMemoryOperations.Location = new System.Drawing.Point(15, 47);
            this.LblMemoryOperations.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.LblMemoryOperations.Name = "LblMemoryOperations";
            this.LblMemoryOperations.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LblMemoryOperations.Outline = false;
            this.LblMemoryOperations.OutlineColor = System.Drawing.Color.Red;
            this.LblMemoryOperations.OutlineLocation = new System.Drawing.Point(0, 0);
            this.LblMemoryOperations.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblMemoryOperations.ReflectionSpacing = 0;
            this.LblMemoryOperations.ShadowColor = System.Drawing.Color.Black;
            this.LblMemoryOperations.ShadowDirection = 315;
            this.LblMemoryOperations.ShadowLocation = new System.Drawing.Point(0, 0);
            this.LblMemoryOperations.ShadowOpacity = 100;
            this.LblMemoryOperations.Size = new System.Drawing.Size(276, 23);
            this.LblMemoryOperations.TabIndex = 2;
            this.LblMemoryOperations.Text = "Operações de Memória: ";
            this.LblMemoryOperations.TextAlignment = System.Drawing.StringAlignment.Near;
            this.LblMemoryOperations.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle4.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle4.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle4.Hover = System.Drawing.Color.Empty;
            textStyle4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.LblMemoryOperations.TextStyle = textStyle4;
            // 
            // LblTimeTaken
            // 
            this.LblTimeTaken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LblTimeTaken.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LblTimeTaken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTimeTaken.Location = new System.Drawing.Point(15, 21);
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
            this.LblTimeTaken.Size = new System.Drawing.Size(276, 23);
            this.LblTimeTaken.TabIndex = 1;
            this.LblTimeTaken.Text = "Tempo levado: ";
            this.LblTimeTaken.TextAlignment = System.Drawing.StringAlignment.Near;
            this.LblTimeTaken.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle5.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle5.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle5.Hover = System.Drawing.Color.Empty;
            textStyle5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.LblTimeTaken.TextStyle = textStyle5;
            // 
            // UcChallengeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.GbxStatistics);
            this.Controls.Add(this.PnlColor);
            this.Controls.Add(this.LblChallengeTitle);
            this.Controls.Add(this.BtnPlay);
            this.Name = "UcChallengeItem";
            this.Size = new System.Drawing.Size(535, 28);
            this.Load += new System.EventHandler(this.UcChallenge_Load);
            this.GbxStatistics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnPlay;
        private VisualPlus.Toolkit.Components.VisualBadge BgeLevel;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel LblChallengeTitle;
        private System.Windows.Forms.Panel PnlColor;
        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox GbxStatistics;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel LblCheated;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel LblCrashes;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel LblMemoryOperations;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel LblTimeTaken;
    }
}
