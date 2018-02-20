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
            VisualPlus.Structure.TextStyle textStyle2 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle7 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle3 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle4 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle5 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle6 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle13 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle8 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle9 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle10 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle11 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle12 = new VisualPlus.Structure.TextStyle();
            this.LblMemoryView = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.BtnBack = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.GbxReadMemory = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.CbxMemoryType = new System.Windows.Forms.ComboBox();
            this.LblTypeValueRead = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.TbxMemoryValue = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
            this.TbxMemoryAddress = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
            this.visualLabel2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.LvwMemory = new System.Windows.Forms.ListView();
            this.visualGroupBox1 = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.BtnInjectAsmCode = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.LblByteOutput = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.RbtxByteOutput = new VisualPlus.Toolkit.Controls.Editors.VisualRichTextBox();
            this.RbtxCode = new VisualPlus.Toolkit.Controls.Editors.VisualRichTextBox();
            this.LblAsmCode = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.GbxReadMemory.SuspendLayout();
            this.visualGroupBox1.SuspendLayout();
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
            this.LblMemoryView.Size = new System.Drawing.Size(667, 23);
            this.LblMemoryView.TabIndex = 0;
            this.LblMemoryView.Text = "Visualização da Memória - {0}\r\n";
            this.LblMemoryView.TextAlignment = System.Drawing.StringAlignment.Near;
            this.LblMemoryView.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle1.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle1.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle1.Hover = System.Drawing.Color.Empty;
            textStyle1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.LblMemoryView.TextStyle = textStyle1;
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
            this.BtnBack.Location = new System.Drawing.Point(12, 610);
            this.BtnBack.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 25);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.Text = "Voltar";
            this.BtnBack.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnBack.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle2.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle2.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle2.Hover = System.Drawing.Color.Empty;
            textStyle2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnBack.TextStyle = textStyle2;
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
            this.GbxReadMemory.Controls.Add(this.CbxMemoryType);
            this.GbxReadMemory.Controls.Add(this.LblTypeValueRead);
            this.GbxReadMemory.Controls.Add(this.TbxMemoryValue);
            this.GbxReadMemory.Controls.Add(this.TbxMemoryAddress);
            this.GbxReadMemory.Controls.Add(this.visualLabel2);
            this.GbxReadMemory.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.GbxReadMemory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GbxReadMemory.Image = null;
            this.GbxReadMemory.Location = new System.Drawing.Point(938, 45);
            this.GbxReadMemory.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.GbxReadMemory.Name = "GbxReadMemory";
            this.GbxReadMemory.Padding = new System.Windows.Forms.Padding(5, 26, 5, 5);
            this.GbxReadMemory.Separator = true;
            this.GbxReadMemory.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.GbxReadMemory.Size = new System.Drawing.Size(311, 160);
            this.GbxReadMemory.TabIndex = 4;
            this.GbxReadMemory.Text = "Memória";
            this.GbxReadMemory.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GbxReadMemory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.GbxReadMemory.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle7.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle7.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle7.Hover = System.Drawing.Color.Empty;
            textStyle7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.GbxReadMemory.TextStyle = textStyle7;
            this.GbxReadMemory.TitleBoxHeight = 25;
            // 
            // CbxMemoryType
            // 
            this.CbxMemoryType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.CbxMemoryType.FormattingEnabled = true;
            this.CbxMemoryType.Location = new System.Drawing.Point(13, 109);
            this.CbxMemoryType.Name = "CbxMemoryType";
            this.CbxMemoryType.Size = new System.Drawing.Size(105, 21);
            this.CbxMemoryType.TabIndex = 18;
            // 
            // LblTypeValueRead
            // 
            this.LblTypeValueRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LblTypeValueRead.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LblTypeValueRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTypeValueRead.Location = new System.Drawing.Point(13, 82);
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
            textStyle3.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle3.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle3.Hover = System.Drawing.Color.Empty;
            textStyle3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.LblTypeValueRead.TextStyle = textStyle3;
            // 
            // TbxMemoryValue
            // 
            this.TbxMemoryValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TbxMemoryValue.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TbxMemoryValue.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.TbxMemoryValue.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TbxMemoryValue.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TbxMemoryValue.Border.HoverVisible = true;
            this.TbxMemoryValue.Border.Rounding = 6;
            this.TbxMemoryValue.Border.Thickness = 1;
            this.TbxMemoryValue.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.TbxMemoryValue.Border.Visible = true;
            this.TbxMemoryValue.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TbxMemoryValue.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TbxMemoryValue.ButtonBorder.HoverVisible = true;
            this.TbxMemoryValue.ButtonBorder.Rounding = 6;
            this.TbxMemoryValue.ButtonBorder.Thickness = 1;
            this.TbxMemoryValue.ButtonBorder.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.TbxMemoryValue.ButtonBorder.Visible = true;
            this.TbxMemoryValue.ButtonColor.Disabled = System.Drawing.Color.Empty;
            this.TbxMemoryValue.ButtonColor.Enabled = System.Drawing.Color.Empty;
            this.TbxMemoryValue.ButtonColor.Hover = System.Drawing.Color.Empty;
            this.TbxMemoryValue.ButtonColor.Pressed = System.Drawing.Color.Empty;
            this.TbxMemoryValue.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxMemoryValue.ButtonIndent = 3;
            this.TbxMemoryValue.ButtonText = "visualButton";
            this.TbxMemoryValue.ButtonVisible = false;
            this.TbxMemoryValue.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TbxMemoryValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TbxMemoryValue.ImageSize = new System.Drawing.Size(16, 16);
            this.TbxMemoryValue.ImageVisible = false;
            this.TbxMemoryValue.ImageWidth = 35;
            this.TbxMemoryValue.Location = new System.Drawing.Point(124, 107);
            this.TbxMemoryValue.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TbxMemoryValue.Name = "TbxMemoryValue";
            this.TbxMemoryValue.PasswordChar = '\0';
            this.TbxMemoryValue.ReadOnly = false;
            this.TbxMemoryValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbxMemoryValue.Size = new System.Drawing.Size(173, 25);
            this.TbxMemoryValue.TabIndex = 13;
            this.TbxMemoryValue.TextBoxWidth = 163;
            textStyle4.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle4.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle4.Hover = System.Drawing.Color.Empty;
            textStyle4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TbxMemoryValue.TextStyle = textStyle4;
            this.TbxMemoryValue.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TbxMemoryValue.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TbxMemoryValue.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TbxMemoryValue.Watermark.Text = "Watermark text";
            this.TbxMemoryValue.Watermark.Visible = false;
            this.TbxMemoryValue.TextChanged += new System.EventHandler(this.TbxMemoryValue_TextChanged);
            // 
            // TbxMemoryAddress
            // 
            this.TbxMemoryAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TbxMemoryAddress.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TbxMemoryAddress.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.TbxMemoryAddress.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TbxMemoryAddress.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TbxMemoryAddress.Border.HoverVisible = true;
            this.TbxMemoryAddress.Border.Rounding = 6;
            this.TbxMemoryAddress.Border.Thickness = 1;
            this.TbxMemoryAddress.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.TbxMemoryAddress.Border.Visible = true;
            this.TbxMemoryAddress.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TbxMemoryAddress.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TbxMemoryAddress.ButtonBorder.HoverVisible = true;
            this.TbxMemoryAddress.ButtonBorder.Rounding = 6;
            this.TbxMemoryAddress.ButtonBorder.Thickness = 1;
            this.TbxMemoryAddress.ButtonBorder.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.TbxMemoryAddress.ButtonBorder.Visible = true;
            this.TbxMemoryAddress.ButtonColor.Disabled = System.Drawing.Color.Empty;
            this.TbxMemoryAddress.ButtonColor.Enabled = System.Drawing.Color.Empty;
            this.TbxMemoryAddress.ButtonColor.Hover = System.Drawing.Color.Empty;
            this.TbxMemoryAddress.ButtonColor.Pressed = System.Drawing.Color.Empty;
            this.TbxMemoryAddress.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxMemoryAddress.ButtonIndent = 3;
            this.TbxMemoryAddress.ButtonText = "visualButton";
            this.TbxMemoryAddress.ButtonVisible = false;
            this.TbxMemoryAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TbxMemoryAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TbxMemoryAddress.ImageSize = new System.Drawing.Size(16, 16);
            this.TbxMemoryAddress.ImageVisible = false;
            this.TbxMemoryAddress.ImageWidth = 35;
            this.TbxMemoryAddress.Location = new System.Drawing.Point(10, 51);
            this.TbxMemoryAddress.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TbxMemoryAddress.Name = "TbxMemoryAddress";
            this.TbxMemoryAddress.PasswordChar = '\0';
            this.TbxMemoryAddress.ReadOnly = false;
            this.TbxMemoryAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbxMemoryAddress.Size = new System.Drawing.Size(287, 25);
            this.TbxMemoryAddress.TabIndex = 11;
            this.TbxMemoryAddress.TextBoxWidth = 277;
            textStyle5.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle5.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle5.Hover = System.Drawing.Color.Empty;
            textStyle5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TbxMemoryAddress.TextStyle = textStyle5;
            this.TbxMemoryAddress.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TbxMemoryAddress.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TbxMemoryAddress.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TbxMemoryAddress.Watermark.Text = "Watermark text";
            this.TbxMemoryAddress.Watermark.Visible = false;
            this.TbxMemoryAddress.TextChanged += new System.EventHandler(this.TbxMemoryAddress_TextChanged);
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
            textStyle6.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle6.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle6.Hover = System.Drawing.Color.Empty;
            textStyle6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualLabel2.TextStyle = textStyle6;
            // 
            // LvwMemory
            // 
            this.LvwMemory.BackColor = System.Drawing.SystemColors.Control;
            this.LvwMemory.Location = new System.Drawing.Point(12, 45);
            this.LvwMemory.Name = "LvwMemory";
            this.LvwMemory.Size = new System.Drawing.Size(900, 559);
            this.LvwMemory.TabIndex = 5;
            this.LvwMemory.UseCompatibleStateImageBehavior = false;
            // 
            // visualGroupBox1
            // 
            this.visualGroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.visualGroupBox1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.visualGroupBox1.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualGroupBox1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.visualGroupBox1.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualGroupBox1.Border.HoverVisible = true;
            this.visualGroupBox1.Border.Rounding = 6;
            this.visualGroupBox1.Border.Thickness = 1;
            this.visualGroupBox1.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualGroupBox1.Border.Visible = true;
            this.visualGroupBox1.BoxStyle = VisualPlus.Toolkit.Controls.Layout.VisualGroupBox.GroupBoxStyle.Default;
            this.visualGroupBox1.Controls.Add(this.BtnInjectAsmCode);
            this.visualGroupBox1.Controls.Add(this.LblByteOutput);
            this.visualGroupBox1.Controls.Add(this.RbtxByteOutput);
            this.visualGroupBox1.Controls.Add(this.RbtxCode);
            this.visualGroupBox1.Controls.Add(this.LblAsmCode);
            this.visualGroupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualGroupBox1.Image = null;
            this.visualGroupBox1.Location = new System.Drawing.Point(938, 211);
            this.visualGroupBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualGroupBox1.Name = "visualGroupBox1";
            this.visualGroupBox1.Padding = new System.Windows.Forms.Padding(5, 26, 5, 5);
            this.visualGroupBox1.Separator = true;
            this.visualGroupBox1.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualGroupBox1.Size = new System.Drawing.Size(311, 393);
            this.visualGroupBox1.TabIndex = 6;
            this.visualGroupBox1.Text = "Assembly (x86)";
            this.visualGroupBox1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualGroupBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.visualGroupBox1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle13.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle13.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle13.Hover = System.Drawing.Color.Empty;
            textStyle13.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualGroupBox1.TextStyle = textStyle13;
            this.visualGroupBox1.TitleBoxHeight = 25;
            // 
            // BtnInjectAsmCode
            // 
            this.BtnInjectAsmCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.BtnInjectAsmCode.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnInjectAsmCode.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.BtnInjectAsmCode.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnInjectAsmCode.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnInjectAsmCode.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.BtnInjectAsmCode.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.BtnInjectAsmCode.Border.HoverVisible = true;
            this.BtnInjectAsmCode.Border.Rounding = 6;
            this.BtnInjectAsmCode.Border.Thickness = 1;
            this.BtnInjectAsmCode.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.BtnInjectAsmCode.Border.Visible = true;
            this.BtnInjectAsmCode.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BtnInjectAsmCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnInjectAsmCode.Image = null;
            this.BtnInjectAsmCode.Location = new System.Drawing.Point(13, 353);
            this.BtnInjectAsmCode.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.BtnInjectAsmCode.Name = "BtnInjectAsmCode";
            this.BtnInjectAsmCode.Size = new System.Drawing.Size(284, 25);
            this.BtnInjectAsmCode.TabIndex = 14;
            this.BtnInjectAsmCode.Text = "Injetar na posição selecionada";
            this.BtnInjectAsmCode.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnInjectAsmCode.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.BtnInjectAsmCode.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle8.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle8.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle8.Hover = System.Drawing.Color.Empty;
            textStyle8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.BtnInjectAsmCode.TextStyle = textStyle8;
            this.BtnInjectAsmCode.Click += new System.EventHandler(this.BtnInjectAsmCode_Click);
            // 
            // LblByteOutput
            // 
            this.LblByteOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LblByteOutput.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LblByteOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblByteOutput.Location = new System.Drawing.Point(13, 187);
            this.LblByteOutput.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.LblByteOutput.Name = "LblByteOutput";
            this.LblByteOutput.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LblByteOutput.Outline = false;
            this.LblByteOutput.OutlineColor = System.Drawing.Color.Red;
            this.LblByteOutput.OutlineLocation = new System.Drawing.Point(0, 0);
            this.LblByteOutput.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblByteOutput.ReflectionSpacing = 0;
            this.LblByteOutput.ShadowColor = System.Drawing.Color.Black;
            this.LblByteOutput.ShadowDirection = 315;
            this.LblByteOutput.ShadowLocation = new System.Drawing.Point(0, 0);
            this.LblByteOutput.ShadowOpacity = 100;
            this.LblByteOutput.Size = new System.Drawing.Size(94, 24);
            this.LblByteOutput.TabIndex = 13;
            this.LblByteOutput.Text = "Saída em bytes:";
            this.LblByteOutput.TextAlignment = System.Drawing.StringAlignment.Near;
            this.LblByteOutput.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle9.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle9.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle9.Hover = System.Drawing.Color.Empty;
            textStyle9.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.LblByteOutput.TextStyle = textStyle9;
            // 
            // RbtxByteOutput
            // 
            this.RbtxByteOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.RbtxByteOutput.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.RbtxByteOutput.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.RbtxByteOutput.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.RbtxByteOutput.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.RbtxByteOutput.Border.HoverVisible = true;
            this.RbtxByteOutput.Border.Rounding = 6;
            this.RbtxByteOutput.Border.Thickness = 1;
            this.RbtxByteOutput.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.RbtxByteOutput.Border.Visible = true;
            this.RbtxByteOutput.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.RbtxByteOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RbtxByteOutput.Location = new System.Drawing.Point(13, 217);
            this.RbtxByteOutput.MaxLength = 2147483647;
            this.RbtxByteOutput.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.RbtxByteOutput.Name = "RbtxByteOutput";
            this.RbtxByteOutput.ReadOnly = false;
            this.RbtxByteOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.RbtxByteOutput.ShowSelectionMargin = false;
            this.RbtxByteOutput.Size = new System.Drawing.Size(284, 130);
            this.RbtxByteOutput.TabIndex = 12;
            textStyle10.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle10.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle10.Hover = System.Drawing.Color.Empty;
            textStyle10.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.RbtxByteOutput.TextStyle = textStyle10;
            // 
            // RbtxCode
            // 
            this.RbtxCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.RbtxCode.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.RbtxCode.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.RbtxCode.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.RbtxCode.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.RbtxCode.Border.HoverVisible = true;
            this.RbtxCode.Border.Rounding = 6;
            this.RbtxCode.Border.Thickness = 1;
            this.RbtxCode.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.RbtxCode.Border.Visible = true;
            this.RbtxCode.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.RbtxCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RbtxCode.Location = new System.Drawing.Point(13, 51);
            this.RbtxCode.MaxLength = 2147483647;
            this.RbtxCode.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.RbtxCode.Name = "RbtxCode";
            this.RbtxCode.ReadOnly = false;
            this.RbtxCode.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.RbtxCode.ShowSelectionMargin = false;
            this.RbtxCode.Size = new System.Drawing.Size(284, 130);
            this.RbtxCode.TabIndex = 11;
            textStyle11.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle11.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle11.Hover = System.Drawing.Color.Empty;
            textStyle11.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.RbtxCode.TextStyle = textStyle11;
            // 
            // LblAsmCode
            // 
            this.LblAsmCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LblAsmCode.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LblAsmCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAsmCode.Location = new System.Drawing.Point(10, 22);
            this.LblAsmCode.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.LblAsmCode.Name = "LblAsmCode";
            this.LblAsmCode.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LblAsmCode.Outline = false;
            this.LblAsmCode.OutlineColor = System.Drawing.Color.Red;
            this.LblAsmCode.OutlineLocation = new System.Drawing.Point(0, 0);
            this.LblAsmCode.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAsmCode.ReflectionSpacing = 0;
            this.LblAsmCode.ShadowColor = System.Drawing.Color.Black;
            this.LblAsmCode.ShadowDirection = 315;
            this.LblAsmCode.ShadowLocation = new System.Drawing.Point(0, 0);
            this.LblAsmCode.ShadowOpacity = 100;
            this.LblAsmCode.Size = new System.Drawing.Size(56, 23);
            this.LblAsmCode.TabIndex = 10;
            this.LblAsmCode.Text = "Código:";
            this.LblAsmCode.TextAlignment = System.Drawing.StringAlignment.Near;
            this.LblAsmCode.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle12.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle12.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle12.Hover = System.Drawing.Color.Empty;
            textStyle12.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.LblAsmCode.TextStyle = textStyle12;
            // 
            // UcMemoryViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.visualGroupBox1);
            this.Controls.Add(this.LvwMemory);
            this.Controls.Add(this.GbxReadMemory);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LblMemoryView);
            this.Name = "UcMemoryViewer";
            this.Size = new System.Drawing.Size(1260, 650);
            this.Load += new System.EventHandler(this.UcMemoryViewer_Load);
            this.GbxReadMemory.ResumeLayout(false);
            this.GbxReadMemory.PerformLayout();
            this.visualGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel LblMemoryView;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnBack;
        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox GbxReadMemory;
        private System.Windows.Forms.ComboBox CbxMemoryType;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel LblTypeValueRead;
        private VisualPlus.Toolkit.Controls.Editors.VisualTextBox TbxMemoryValue;
        private VisualPlus.Toolkit.Controls.Editors.VisualTextBox TbxMemoryAddress;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel2;
        private System.Windows.Forms.ListView LvwMemory;
        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox visualGroupBox1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel LblAsmCode;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton BtnInjectAsmCode;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel LblByteOutput;
        private VisualPlus.Toolkit.Controls.Editors.VisualRichTextBox RbtxByteOutput;
        private VisualPlus.Toolkit.Controls.Editors.VisualRichTextBox RbtxCode;
    }
}
