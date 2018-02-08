namespace HArCKtecture.User_Controls
{
    partial class UcMemoryViewer
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
            VisualPlus.Structure.TextStyle textStyle6 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle2 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle3 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle4 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle5 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle7 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle12 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle8 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle9 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle10 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle11 = new VisualPlus.Structure.TextStyle();
            this.LblMemoryView = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.GbxWriteMemory = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.BtnWriteMemory = new System.Windows.Forms.Button();
            this.CbxWriteType = new System.Windows.Forms.ComboBox();
            this.TbxValue = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
            this.LblTypeValueWrite = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.TbxWriteAddress = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
            this.LblAddress = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.BtnBack = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.GbxReadMemory = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.CbxReadType = new System.Windows.Forms.ComboBox();
            this.LblTypeValueRead = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.BtnVisualize = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.visualTextBox1 = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
            this.TbxReadAddress = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
            this.visualLabel2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.LvwMemory = new System.Windows.Forms.ListView();
            this.GbxWriteMemory.SuspendLayout();
            this.GbxReadMemory.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblMemoryView
            // 
            this.LblMemoryView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LblMemoryView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblMemoryView.Location = new System.Drawing.Point(12, 16);
            this.LblMemoryView.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.LblMemoryView.Name = "LblMemoryView";
            this.LblMemoryView.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LblMemoryView.Outline = false;
            this.LblMemoryView.OutlineColor = System.Drawing.Color.Red;
            this.LblMemoryView.OutlineLocation = new System.Drawing.Point(0, 0);
            this.LblMemoryView.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblMemoryView.ReflectionSpacing = 0;
            this.LblMemoryView.ShadowColor = System.Drawing.Color.Black;
            this.LblMemoryView.ShadowDirection = 315;
            this.LblMemoryView.ShadowLocation = new System.Drawing.Point(0, 0);
            this.LblMemoryView.ShadowOpacity = 100;
            this.LblMemoryView.Size = new System.Drawing.Size(137, 23);
            this.LblMemoryView.TabIndex = 0;
            this.LblMemoryView.Text = "Visualização da Memória:";
            this.LblMemoryView.TextAlignment = System.Drawing.StringAlignment.Near;
            this.LblMemoryView.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle1.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle1.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle1.Hover = System.Drawing.Color.Empty;
            textStyle1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.LblMemoryView.TextStyle = textStyle1;
            // 
            // GbxWriteMemory
            // 
            this.GbxWriteMemory.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GbxWriteMemory.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.GbxWriteMemory.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.GbxWriteMemory.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.GbxWriteMemory.Border.HoverVisible = true;
            this.GbxWriteMemory.Border.Rounding = 6;
            this.GbxWriteMemory.Border.Thickness = 1;
            this.GbxWriteMemory.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.GbxWriteMemory.Border.Visible = true;
            this.GbxWriteMemory.BoxStyle = VisualPlus.Toolkit.Controls.Layout.VisualGroupBox.GroupBoxStyle.Default;
            this.GbxWriteMemory.Controls.Add(this.BtnWriteMemory);
            this.GbxWriteMemory.Controls.Add(this.CbxWriteType);
            this.GbxWriteMemory.Controls.Add(this.TbxValue);
            this.GbxWriteMemory.Controls.Add(this.LblTypeValueWrite);
            this.GbxWriteMemory.Controls.Add(this.TbxWriteAddress);
            this.GbxWriteMemory.Controls.Add(this.LblAddress);
            this.GbxWriteMemory.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GbxWriteMemory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GbxWriteMemory.Image = null;
            this.GbxWriteMemory.Location = new System.Drawing.Point(420, 211);
            this.GbxWriteMemory.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.GbxWriteMemory.Name = "GbxWriteMemory";
            this.GbxWriteMemory.Padding = new System.Windows.Forms.Padding(5, 26, 5, 5);
            this.GbxWriteMemory.Separator = true;
            this.GbxWriteMemory.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.GbxWriteMemory.Size = new System.Drawing.Size(207, 195);
            this.GbxWriteMemory.TabIndex = 2;
            this.GbxWriteMemory.Text = "Escrever na Memória";
            this.GbxWriteMemory.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GbxWriteMemory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GbxWriteMemory.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle6.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle6.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle6.Hover = System.Drawing.Color.Empty;
            textStyle6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.GbxWriteMemory.TextStyle = textStyle6;
            this.GbxWriteMemory.TitleBoxHeight = 25;
            // 
            // BtnWriteMemory
            // 
            this.BtnWriteMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.BtnWriteMemory.BackgroundImage = global::HArCKtecture.Properties.Resources.right_arrow;
            this.BtnWriteMemory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnWriteMemory.FlatAppearance.BorderSize = 0;
            this.BtnWriteMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWriteMemory.Location = new System.Drawing.Point(175, 156);
            this.BtnWriteMemory.Name = "BtnWriteMemory";
            this.BtnWriteMemory.Size = new System.Drawing.Size(25, 25);
            this.BtnWriteMemory.TabIndex = 9;
            this.BtnWriteMemory.UseVisualStyleBackColor = false;
            this.BtnWriteMemory.Click += new System.EventHandler(this.BtnWriteMemory_Click);
            // 
            // CbxWriteType
            // 
            this.CbxWriteType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.CbxWriteType.FormattingEnabled = true;
            this.CbxWriteType.Location = new System.Drawing.Point(13, 120);
            this.CbxWriteType.Name = "CbxWriteType";
            this.CbxWriteType.Size = new System.Drawing.Size(187, 21);
            this.CbxWriteType.TabIndex = 8;
            // 
            // TbxValue
            // 
            this.TbxValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TbxValue.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TbxValue.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.TbxValue.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TbxValue.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TbxValue.Border.HoverVisible = true;
            this.TbxValue.Border.Rounding = 6;
            this.TbxValue.Border.Thickness = 1;
            this.TbxValue.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.TbxValue.Border.Visible = true;
            this.TbxValue.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TbxValue.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TbxValue.ButtonBorder.HoverVisible = true;
            this.TbxValue.ButtonBorder.Rounding = 6;
            this.TbxValue.ButtonBorder.Thickness = 1;
            this.TbxValue.ButtonBorder.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.TbxValue.ButtonBorder.Visible = true;
            this.TbxValue.ButtonColor.Disabled = System.Drawing.Color.Empty;
            this.TbxValue.ButtonColor.Enabled = System.Drawing.Color.Empty;
            this.TbxValue.ButtonColor.Hover = System.Drawing.Color.Empty;
            this.TbxValue.ButtonColor.Pressed = System.Drawing.Color.Empty;
            this.TbxValue.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxValue.ButtonIndent = 3;
            this.TbxValue.ButtonText = "visualButton";
            this.TbxValue.ButtonVisible = false;
            this.TbxValue.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TbxValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TbxValue.ImageSize = new System.Drawing.Size(16, 16);
            this.TbxValue.ImageVisible = false;
            this.TbxValue.ImageWidth = 35;
            this.TbxValue.Location = new System.Drawing.Point(13, 156);
            this.TbxValue.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TbxValue.Name = "TbxValue";
            this.TbxValue.PasswordChar = '\0';
            this.TbxValue.ReadOnly = false;
            this.TbxValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbxValue.Size = new System.Drawing.Size(156, 25);
            this.TbxValue.TabIndex = 6;
            this.TbxValue.TextBoxWidth = 146;
            textStyle2.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle2.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle2.Hover = System.Drawing.Color.Empty;
            textStyle2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TbxValue.TextStyle = textStyle2;
            this.TbxValue.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TbxValue.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TbxValue.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TbxValue.Watermark.Text = "Watermark text";
            this.TbxValue.Watermark.Visible = false;
            // 
            // LblTypeValueWrite
            // 
            this.LblTypeValueWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LblTypeValueWrite.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LblTypeValueWrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTypeValueWrite.Location = new System.Drawing.Point(13, 91);
            this.LblTypeValueWrite.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.LblTypeValueWrite.Name = "LblTypeValueWrite";
            this.LblTypeValueWrite.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LblTypeValueWrite.Outline = false;
            this.LblTypeValueWrite.OutlineColor = System.Drawing.Color.Red;
            this.LblTypeValueWrite.OutlineLocation = new System.Drawing.Point(0, 0);
            this.LblTypeValueWrite.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTypeValueWrite.ReflectionSpacing = 0;
            this.LblTypeValueWrite.ShadowColor = System.Drawing.Color.Black;
            this.LblTypeValueWrite.ShadowDirection = 315;
            this.LblTypeValueWrite.ShadowLocation = new System.Drawing.Point(0, 0);
            this.LblTypeValueWrite.ShadowOpacity = 100;
            this.LblTypeValueWrite.Size = new System.Drawing.Size(75, 23);
            this.LblTypeValueWrite.TabIndex = 4;
            this.LblTypeValueWrite.Text = "Tipo/Valor:";
            this.LblTypeValueWrite.TextAlignment = System.Drawing.StringAlignment.Near;
            this.LblTypeValueWrite.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle3.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle3.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle3.Hover = System.Drawing.Color.Empty;
            textStyle3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.LblTypeValueWrite.TextStyle = textStyle3;
            // 
            // TbxWriteAddress
            // 
            this.TbxWriteAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TbxWriteAddress.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TbxWriteAddress.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.TbxWriteAddress.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TbxWriteAddress.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TbxWriteAddress.Border.HoverVisible = true;
            this.TbxWriteAddress.Border.Rounding = 6;
            this.TbxWriteAddress.Border.Thickness = 1;
            this.TbxWriteAddress.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.TbxWriteAddress.Border.Visible = true;
            this.TbxWriteAddress.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TbxWriteAddress.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TbxWriteAddress.ButtonBorder.HoverVisible = true;
            this.TbxWriteAddress.ButtonBorder.Rounding = 6;
            this.TbxWriteAddress.ButtonBorder.Thickness = 1;
            this.TbxWriteAddress.ButtonBorder.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.TbxWriteAddress.ButtonBorder.Visible = true;
            this.TbxWriteAddress.ButtonColor.Disabled = System.Drawing.Color.Empty;
            this.TbxWriteAddress.ButtonColor.Enabled = System.Drawing.Color.Empty;
            this.TbxWriteAddress.ButtonColor.Hover = System.Drawing.Color.Empty;
            this.TbxWriteAddress.ButtonColor.Pressed = System.Drawing.Color.Empty;
            this.TbxWriteAddress.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxWriteAddress.ButtonIndent = 3;
            this.TbxWriteAddress.ButtonText = "visualButton";
            this.TbxWriteAddress.ButtonVisible = false;
            this.TbxWriteAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TbxWriteAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TbxWriteAddress.ImageSize = new System.Drawing.Size(16, 16);
            this.TbxWriteAddress.ImageVisible = false;
            this.TbxWriteAddress.ImageWidth = 35;
            this.TbxWriteAddress.Location = new System.Drawing.Point(13, 54);
            this.TbxWriteAddress.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TbxWriteAddress.Name = "TbxWriteAddress";
            this.TbxWriteAddress.PasswordChar = '\0';
            this.TbxWriteAddress.ReadOnly = false;
            this.TbxWriteAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbxWriteAddress.Size = new System.Drawing.Size(187, 25);
            this.TbxWriteAddress.TabIndex = 2;
            this.TbxWriteAddress.TextBoxWidth = 177;
            textStyle4.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle4.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle4.Hover = System.Drawing.Color.Empty;
            textStyle4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TbxWriteAddress.TextStyle = textStyle4;
            this.TbxWriteAddress.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TbxWriteAddress.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TbxWriteAddress.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TbxWriteAddress.Watermark.Text = "Watermark text";
            this.TbxWriteAddress.Watermark.Visible = false;
            // 
            // LblAddress
            // 
            this.LblAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LblAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAddress.Location = new System.Drawing.Point(13, 25);
            this.LblAddress.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LblAddress.Outline = false;
            this.LblAddress.OutlineColor = System.Drawing.Color.Red;
            this.LblAddress.OutlineLocation = new System.Drawing.Point(0, 0);
            this.LblAddress.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAddress.ReflectionSpacing = 0;
            this.LblAddress.ShadowColor = System.Drawing.Color.Black;
            this.LblAddress.ShadowDirection = 315;
            this.LblAddress.ShadowLocation = new System.Drawing.Point(0, 0);
            this.LblAddress.ShadowOpacity = 100;
            this.LblAddress.Size = new System.Drawing.Size(75, 23);
            this.LblAddress.TabIndex = 1;
            this.LblAddress.Text = "Endereço:";
            this.LblAddress.TextAlignment = System.Drawing.StringAlignment.Near;
            this.LblAddress.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle5.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle5.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle5.Hover = System.Drawing.Color.Empty;
            textStyle5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.LblAddress.TextStyle = textStyle5;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBack.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.BtnBack.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBack.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnBack.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.BtnBack.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.BtnBack.Border.HoverVisible = true;
            this.BtnBack.Border.Rounding = 6;
            this.BtnBack.Border.Thickness = 1;
            this.BtnBack.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.BtnBack.Border.Visible = true;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BtnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnBack.Image = null;
            this.BtnBack.Location = new System.Drawing.Point(12, 422);
            this.BtnBack.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 25);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.Text = "Voltar";
            this.BtnBack.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnBack.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle7.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle7.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle7.Hover = System.Drawing.Color.Empty;
            textStyle7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnBack.TextStyle = textStyle7;
            // 
            // GbxReadMemory
            // 
            this.GbxReadMemory.BackColor = System.Drawing.SystemColors.Control;
            this.GbxReadMemory.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GbxReadMemory.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.GbxReadMemory.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.GbxReadMemory.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.GbxReadMemory.Border.HoverVisible = true;
            this.GbxReadMemory.Border.Rounding = 6;
            this.GbxReadMemory.Border.Thickness = 1;
            this.GbxReadMemory.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.GbxReadMemory.Border.Visible = true;
            this.GbxReadMemory.BoxStyle = VisualPlus.Toolkit.Controls.Layout.VisualGroupBox.GroupBoxStyle.Default;
            this.GbxReadMemory.Controls.Add(this.CbxReadType);
            this.GbxReadMemory.Controls.Add(this.LblTypeValueRead);
            this.GbxReadMemory.Controls.Add(this.BtnVisualize);
            this.GbxReadMemory.Controls.Add(this.BtnSearch);
            this.GbxReadMemory.Controls.Add(this.visualTextBox1);
            this.GbxReadMemory.Controls.Add(this.TbxReadAddress);
            this.GbxReadMemory.Controls.Add(this.visualLabel2);
            this.GbxReadMemory.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GbxReadMemory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GbxReadMemory.Image = null;
            this.GbxReadMemory.Location = new System.Drawing.Point(420, 45);
            this.GbxReadMemory.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.GbxReadMemory.Name = "GbxReadMemory";
            this.GbxReadMemory.Padding = new System.Windows.Forms.Padding(5, 26, 5, 5);
            this.GbxReadMemory.Separator = true;
            this.GbxReadMemory.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.GbxReadMemory.Size = new System.Drawing.Size(207, 160);
            this.GbxReadMemory.TabIndex = 4;
            this.GbxReadMemory.Text = "Ler da Memória";
            this.GbxReadMemory.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GbxReadMemory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.GbxReadMemory.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle12.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle12.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle12.Hover = System.Drawing.Color.Empty;
            textStyle12.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.GbxReadMemory.TextStyle = textStyle12;
            this.GbxReadMemory.TitleBoxHeight = 25;
            // 
            // CbxReadType
            // 
            this.CbxReadType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.CbxReadType.FormattingEnabled = true;
            this.CbxReadType.Location = new System.Drawing.Point(10, 126);
            this.CbxReadType.Name = "CbxReadType";
            this.CbxReadType.Size = new System.Drawing.Size(105, 21);
            this.CbxReadType.TabIndex = 18;
            // 
            // LblTypeValueRead
            // 
            this.LblTypeValueRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LblTypeValueRead.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LblTypeValueRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTypeValueRead.Location = new System.Drawing.Point(10, 97);
            this.LblTypeValueRead.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.LblTypeValueRead.Name = "LblTypeValueRead";
            this.LblTypeValueRead.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LblTypeValueRead.Outline = false;
            this.LblTypeValueRead.OutlineColor = System.Drawing.Color.Red;
            this.LblTypeValueRead.OutlineLocation = new System.Drawing.Point(0, 0);
            this.LblTypeValueRead.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTypeValueRead.ReflectionSpacing = 0;
            this.LblTypeValueRead.ShadowColor = System.Drawing.Color.Black;
            this.LblTypeValueRead.ShadowDirection = 315;
            this.LblTypeValueRead.ShadowLocation = new System.Drawing.Point(0, 0);
            this.LblTypeValueRead.ShadowOpacity = 100;
            this.LblTypeValueRead.Size = new System.Drawing.Size(70, 23);
            this.LblTypeValueRead.TabIndex = 17;
            this.LblTypeValueRead.Text = "Tipo/Valor:";
            this.LblTypeValueRead.TextAlignment = System.Drawing.StringAlignment.Near;
            this.LblTypeValueRead.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle8.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle8.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle8.Hover = System.Drawing.Color.Empty;
            textStyle8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.LblTypeValueRead.TextStyle = textStyle8;
            // 
            // BtnVisualize
            // 
            this.BtnVisualize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.BtnVisualize.BackgroundImage = global::HArCKtecture.Properties.Resources.right_arrow;
            this.BtnVisualize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVisualize.FlatAppearance.BorderSize = 0;
            this.BtnVisualize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVisualize.Location = new System.Drawing.Point(175, 51);
            this.BtnVisualize.Name = "BtnVisualize";
            this.BtnVisualize.Size = new System.Drawing.Size(25, 25);
            this.BtnVisualize.TabIndex = 16;
            this.BtnVisualize.UseVisualStyleBackColor = false;
            this.BtnVisualize.Click += new System.EventHandler(this.BtnVisualize_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.BtnSearch.BackgroundImage = global::HArCKtecture.Properties.Resources.right_arrow;
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Location = new System.Drawing.Point(144, 51);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(25, 25);
            this.BtnSearch.TabIndex = 15;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // visualTextBox1
            // 
            this.visualTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualTextBox1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualTextBox1.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.visualTextBox1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.visualTextBox1.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualTextBox1.Border.HoverVisible = true;
            this.visualTextBox1.Border.Rounding = 6;
            this.visualTextBox1.Border.Thickness = 1;
            this.visualTextBox1.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualTextBox1.Border.Visible = true;
            this.visualTextBox1.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.visualTextBox1.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualTextBox1.ButtonBorder.HoverVisible = true;
            this.visualTextBox1.ButtonBorder.Rounding = 6;
            this.visualTextBox1.ButtonBorder.Thickness = 1;
            this.visualTextBox1.ButtonBorder.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualTextBox1.ButtonBorder.Visible = true;
            this.visualTextBox1.ButtonColor.Disabled = System.Drawing.Color.Empty;
            this.visualTextBox1.ButtonColor.Enabled = System.Drawing.Color.Empty;
            this.visualTextBox1.ButtonColor.Hover = System.Drawing.Color.Empty;
            this.visualTextBox1.ButtonColor.Pressed = System.Drawing.Color.Empty;
            this.visualTextBox1.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualTextBox1.ButtonIndent = 3;
            this.visualTextBox1.ButtonText = "visualButton";
            this.visualTextBox1.ButtonVisible = false;
            this.visualTextBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualTextBox1.ImageSize = new System.Drawing.Size(16, 16);
            this.visualTextBox1.ImageVisible = false;
            this.visualTextBox1.ImageWidth = 35;
            this.visualTextBox1.Location = new System.Drawing.Point(121, 123);
            this.visualTextBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualTextBox1.Name = "visualTextBox1";
            this.visualTextBox1.PasswordChar = '\0';
            this.visualTextBox1.ReadOnly = false;
            this.visualTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.visualTextBox1.Size = new System.Drawing.Size(79, 25);
            this.visualTextBox1.TabIndex = 13;
            this.visualTextBox1.TextBoxWidth = 69;
            textStyle9.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle9.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle9.Hover = System.Drawing.Color.Empty;
            textStyle9.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualTextBox1.TextStyle = textStyle9;
            this.visualTextBox1.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.visualTextBox1.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualTextBox1.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.visualTextBox1.Watermark.Text = "Watermark text";
            this.visualTextBox1.Watermark.Visible = false;
            // 
            // TbxReadAddress
            // 
            this.TbxReadAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TbxReadAddress.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TbxReadAddress.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.TbxReadAddress.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TbxReadAddress.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TbxReadAddress.Border.HoverVisible = true;
            this.TbxReadAddress.Border.Rounding = 6;
            this.TbxReadAddress.Border.Thickness = 1;
            this.TbxReadAddress.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.TbxReadAddress.Border.Visible = true;
            this.TbxReadAddress.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TbxReadAddress.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TbxReadAddress.ButtonBorder.HoverVisible = true;
            this.TbxReadAddress.ButtonBorder.Rounding = 6;
            this.TbxReadAddress.ButtonBorder.Thickness = 1;
            this.TbxReadAddress.ButtonBorder.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.TbxReadAddress.ButtonBorder.Visible = true;
            this.TbxReadAddress.ButtonColor.Disabled = System.Drawing.Color.Empty;
            this.TbxReadAddress.ButtonColor.Enabled = System.Drawing.Color.Empty;
            this.TbxReadAddress.ButtonColor.Hover = System.Drawing.Color.Empty;
            this.TbxReadAddress.ButtonColor.Pressed = System.Drawing.Color.Empty;
            this.TbxReadAddress.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxReadAddress.ButtonIndent = 3;
            this.TbxReadAddress.ButtonText = "visualButton";
            this.TbxReadAddress.ButtonVisible = false;
            this.TbxReadAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TbxReadAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TbxReadAddress.ImageSize = new System.Drawing.Size(16, 16);
            this.TbxReadAddress.ImageVisible = false;
            this.TbxReadAddress.ImageWidth = 35;
            this.TbxReadAddress.Location = new System.Drawing.Point(10, 51);
            this.TbxReadAddress.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TbxReadAddress.Name = "TbxReadAddress";
            this.TbxReadAddress.PasswordChar = '\0';
            this.TbxReadAddress.ReadOnly = false;
            this.TbxReadAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbxReadAddress.Size = new System.Drawing.Size(128, 25);
            this.TbxReadAddress.TabIndex = 11;
            this.TbxReadAddress.TextBoxWidth = 118;
            textStyle10.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle10.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle10.Hover = System.Drawing.Color.Empty;
            textStyle10.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TbxReadAddress.TextStyle = textStyle10;
            this.TbxReadAddress.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TbxReadAddress.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TbxReadAddress.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TbxReadAddress.Watermark.Text = "Watermark text";
            this.TbxReadAddress.Watermark.Visible = false;
            // 
            // visualLabel2
            // 
            this.visualLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel2.Location = new System.Drawing.Point(10, 22);
            this.visualLabel2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel2.Name = "visualLabel2";
            this.visualLabel2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel2.Outline = false;
            this.visualLabel2.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel2.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel2.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel2.ReflectionSpacing = 0;
            this.visualLabel2.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel2.ShadowDirection = 315;
            this.visualLabel2.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel2.ShadowOpacity = 100;
            this.visualLabel2.Size = new System.Drawing.Size(56, 23);
            this.visualLabel2.TabIndex = 10;
            this.visualLabel2.Text = "Endereço:";
            this.visualLabel2.TextAlignment = System.Drawing.StringAlignment.Near;
            this.visualLabel2.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle11.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle11.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle11.Hover = System.Drawing.Color.Empty;
            textStyle11.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel2.TextStyle = textStyle11;
            // 
            // LvwMemory
            // 
            this.LvwMemory.BackColor = System.Drawing.SystemColors.Control;
            this.LvwMemory.Location = new System.Drawing.Point(12, 45);
            this.LvwMemory.Name = "LvwMemory";
            this.LvwMemory.Size = new System.Drawing.Size(402, 361);
            this.LvwMemory.TabIndex = 5;
            this.LvwMemory.UseCompatibleStateImageBehavior = false;
            // 
            // UcMemoryViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LvwMemory);
            this.Controls.Add(this.GbxReadMemory);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.GbxWriteMemory);
            this.Controls.Add(this.LblMemoryView);
            this.Name = "UcMemoryViewer";
            this.Size = new System.Drawing.Size(640, 460);
            this.Load += new System.EventHandler(this.UcMemoryViewer_Load);
            this.GbxWriteMemory.ResumeLayout(false);
            this.GbxWriteMemory.PerformLayout();
            this.GbxReadMemory.ResumeLayout(false);
            this.GbxReadMemory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel LblMemoryView;
        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox GbxWriteMemory;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnBack;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel LblAddress;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel LblTypeValueWrite;
        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox GbxReadMemory;
        private VisualPlus.Toolkit.Controls.Editors.VisualTextBox TbxValue;
        private System.Windows.Forms.ComboBox CbxWriteType;
        private VisualPlus.Toolkit.Controls.Editors.VisualTextBox TbxWriteAddress;
        private System.Windows.Forms.Button BtnWriteMemory;
        private System.Windows.Forms.ComboBox CbxReadType;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel LblTypeValueRead;
        private System.Windows.Forms.Button BtnVisualize;
        private System.Windows.Forms.Button BtnSearch;
        private VisualPlus.Toolkit.Controls.Editors.VisualTextBox visualTextBox1;
        private VisualPlus.Toolkit.Controls.Editors.VisualTextBox TbxReadAddress;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel2;
        private System.Windows.Forms.ListView LvwMemory;
    }
}
