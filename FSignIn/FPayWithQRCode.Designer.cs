namespace Hotel_Management
{
    partial class FPayWithQRCode
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPayWithQRCode));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnCreateQRCode = new Button();
            label1 = new Label();
            cbbBanks = new Guna.UI2.WinForms.Guna2ComboBox();
            label2 = new Label();
            txtSTK = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbbTemplate = new Guna.UI2.WinForms.Guna2ComboBox();
            txtAccountName = new Guna.UI2.WinForms.Guna2TextBox();
            txtInvoice = new Guna.UI2.WinForms.Guna2TextBox();
            label6 = new Label();
            txtExtraInfo = new Guna.UI2.WinForms.Guna2TextBox();
            pbQRCode = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label24 = new Label();
            btnBack = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)pbQRCode).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateQRCode
            // 
            btnCreateQRCode.BackColor = Color.FromArgb(0, 0, 192);
            btnCreateQRCode.Cursor = Cursors.Hand;
            btnCreateQRCode.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateQRCode.ForeColor = SystemColors.ControlLight;
            btnCreateQRCode.Location = new Point(133, 495);
            btnCreateQRCode.Margin = new Padding(3, 4, 3, 4);
            btnCreateQRCode.Name = "btnCreateQRCode";
            btnCreateQRCode.Size = new Size(223, 57);
            btnCreateQRCode.TabIndex = 0;
            btnCreateQRCode.Text = "Tạo QR Code";
            btnCreateQRCode.UseVisualStyleBackColor = false;
            btnCreateQRCode.Click += btnCreateQRCode_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(44, 128, 38);
            label1.Location = new Point(24, 110);
            label1.Name = "label1";
            label1.Size = new Size(127, 27);
            label1.TabIndex = 2;
            label1.Text = "Ngân hàng";
            // 
            // cbbBanks
            // 
            cbbBanks.BackColor = Color.White;
            cbbBanks.BorderColor = Color.FromArgb(51, 32, 32);
            cbbBanks.BorderRadius = 10;
            cbbBanks.BorderThickness = 2;
            cbbBanks.CustomizableEdges = customizableEdges1;
            cbbBanks.DrawMode = DrawMode.OwnerDrawFixed;
            cbbBanks.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbBanks.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbBanks.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbBanks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbBanks.ForeColor = Color.FromArgb(68, 88, 112);
            cbbBanks.ItemHeight = 40;
            cbbBanks.Location = new Point(24, 141);
            cbbBanks.Margin = new Padding(3, 4, 3, 4);
            cbbBanks.Name = "cbbBanks";
            cbbBanks.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbbBanks.Size = new Size(223, 46);
            cbbBanks.TabIndex = 3;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(44, 128, 38);
            label2.Location = new Point(253, 110);
            label2.Name = "label2";
            label2.Size = new Size(137, 27);
            label2.TabIndex = 2;
            label2.Text = "Số tài khoản";
            // 
            // txtSTK
            // 
            txtSTK.BackColor = Color.White;
            txtSTK.BorderColor = Color.FromArgb(51, 32, 32);
            txtSTK.BorderRadius = 10;
            txtSTK.BorderThickness = 2;
            txtSTK.CustomizableEdges = customizableEdges3;
            txtSTK.DefaultText = "";
            txtSTK.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSTK.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSTK.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSTK.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSTK.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSTK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSTK.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSTK.Location = new Point(254, 141);
            txtSTK.Margin = new Padding(4, 7, 4, 7);
            txtSTK.Name = "txtSTK";
            txtSTK.PasswordChar = '\0';
            txtSTK.PlaceholderText = "";
            txtSTK.SelectedText = "";
            txtSTK.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSTK.Size = new Size(223, 46);
            txtSTK.TabIndex = 4;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(44, 128, 38);
            label3.Location = new Point(24, 253);
            label3.Name = "label3";
            label3.Size = new Size(114, 27);
            label3.TabIndex = 2;
            label3.Text = "Template";
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(44, 128, 38);
            label4.Location = new Point(24, 391);
            label4.Name = "label4";
            label4.Size = new Size(96, 27);
            label4.TabIndex = 2;
            label4.Text = "Số tiền";
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(44, 128, 38);
            label5.Location = new Point(253, 253);
            label5.Name = "label5";
            label5.Size = new Size(144, 27);
            label5.TabIndex = 2;
            label5.Text = "Tên tài khoản";
            // 
            // cbbTemplate
            // 
            cbbTemplate.BackColor = Color.White;
            cbbTemplate.BorderColor = Color.FromArgb(51, 32, 32);
            cbbTemplate.BorderRadius = 10;
            cbbTemplate.BorderThickness = 2;
            cbbTemplate.CustomizableEdges = customizableEdges5;
            cbbTemplate.DrawMode = DrawMode.OwnerDrawFixed;
            cbbTemplate.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTemplate.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbTemplate.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbTemplate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbTemplate.ForeColor = Color.FromArgb(68, 88, 112);
            cbbTemplate.ItemHeight = 40;
            cbbTemplate.Items.AddRange(new object[] { "compact", "compact2", "qr_only", "print" });
            cbbTemplate.Location = new Point(24, 284);
            cbbTemplate.Margin = new Padding(3, 4, 3, 4);
            cbbTemplate.Name = "cbbTemplate";
            cbbTemplate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cbbTemplate.Size = new Size(223, 46);
            cbbTemplate.TabIndex = 5;
            // 
            // txtAccountName
            // 
            txtAccountName.BackColor = Color.White;
            txtAccountName.BorderColor = Color.FromArgb(51, 32, 32);
            txtAccountName.BorderRadius = 10;
            txtAccountName.BorderThickness = 2;
            txtAccountName.CustomizableEdges = customizableEdges7;
            txtAccountName.DefaultText = "";
            txtAccountName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtAccountName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtAccountName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtAccountName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtAccountName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAccountName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccountName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtAccountName.Location = new Point(254, 284);
            txtAccountName.Margin = new Padding(4, 7, 4, 7);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.PasswordChar = '\0';
            txtAccountName.PlaceholderText = "";
            txtAccountName.SelectedText = "";
            txtAccountName.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtAccountName.Size = new Size(223, 46);
            txtAccountName.TabIndex = 6;
            // 
            // txtInvoice
            // 
            txtInvoice.BackColor = Color.White;
            txtInvoice.BorderColor = Color.FromArgb(51, 32, 32);
            txtInvoice.BorderRadius = 10;
            txtInvoice.BorderThickness = 2;
            txtInvoice.CustomizableEdges = customizableEdges9;
            txtInvoice.DefaultText = "";
            txtInvoice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtInvoice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtInvoice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtInvoice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtInvoice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInvoice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtInvoice.Location = new Point(24, 420);
            txtInvoice.Margin = new Padding(4, 7, 4, 7);
            txtInvoice.Name = "txtInvoice";
            txtInvoice.PasswordChar = '\0';
            txtInvoice.PlaceholderText = "";
            txtInvoice.SelectedText = "";
            txtInvoice.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtInvoice.Size = new Size(223, 46);
            txtInvoice.TabIndex = 7;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(44, 128, 38);
            label6.Location = new Point(253, 391);
            label6.Name = "label6";
            label6.Size = new Size(159, 27);
            label6.TabIndex = 2;
            label6.Text = "Thông tin thêm";
            // 
            // txtExtraInfo
            // 
            txtExtraInfo.BackColor = Color.White;
            txtExtraInfo.BorderColor = Color.FromArgb(51, 32, 32);
            txtExtraInfo.BorderRadius = 10;
            txtExtraInfo.BorderThickness = 2;
            txtExtraInfo.CustomizableEdges = customizableEdges11;
            txtExtraInfo.DefaultText = "";
            txtExtraInfo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtExtraInfo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtExtraInfo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtExtraInfo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtExtraInfo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtExtraInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExtraInfo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtExtraInfo.Location = new Point(253, 420);
            txtExtraInfo.Margin = new Padding(4, 7, 4, 7);
            txtExtraInfo.Name = "txtExtraInfo";
            txtExtraInfo.PasswordChar = '\0';
            txtExtraInfo.PlaceholderText = "";
            txtExtraInfo.SelectedText = "";
            txtExtraInfo.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtExtraInfo.Size = new Size(223, 46);
            txtExtraInfo.TabIndex = 8;
            // 
            // pbQRCode
            // 
            pbQRCode.BackColor = Color.WhiteSmoke;
            pbQRCode.BorderRadius = 10;
            pbQRCode.CustomizableEdges = customizableEdges13;
            pbQRCode.Image = (Image)resources.GetObject("pbQRCode.Image");
            pbQRCode.ImageRotate = 0F;
            pbQRCode.Location = new Point(528, 141);
            pbQRCode.Margin = new Padding(3, 4, 3, 4);
            pbQRCode.Name = "pbQRCode";
            pbQRCode.ShadowDecoration.CustomizableEdges = customizableEdges14;
            pbQRCode.Size = new Size(400, 400);
            pbQRCode.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQRCode.TabIndex = 9;
            pbQRCode.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.AutoSize = false;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Dock = DockStyle.Top;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.Navy;
            guna2HtmlLabel1.Location = new Point(0, 0);
            guna2HtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(957, 78);
            guna2HtmlLabel1.TabIndex = 10;
            guna2HtmlLabel1.Text = "Thanh toán bằng QR Code";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.BottomCenter;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 18;
            guna2Elipse1.TargetControl = this;
            // 
            // label24
            // 
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label24.Location = new Point(36, 14);
            label24.Name = "label24";
            label24.Size = new Size(72, 29);
            label24.TabIndex = 54;
            label24.Text = "Trở lại";
            label24.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.WhiteSmoke;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageSize = new Size(30, 30);
            btnBack.Location = new Point(9, 12);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges15;
            btnBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnBack.Size = new Size(30, 30);
            btnBack.TabIndex = 53;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 18;
            guna2Elipse2.TargetControl = pbQRCode;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label24);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(guna2HtmlLabel1);
            panel1.Controls.Add(btnCreateQRCode);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(957, 617);
            panel1.TabIndex = 55;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 18;
            guna2Elipse3.TargetControl = panel1;
            // 
            // FPayWithQRCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(981, 641);
            Controls.Add(pbQRCode);
            Controls.Add(txtExtraInfo);
            Controls.Add(txtInvoice);
            Controls.Add(txtAccountName);
            Controls.Add(cbbTemplate);
            Controls.Add(txtSTK);
            Controls.Add(cbbBanks);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FPayWithQRCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FPayWithQRCode";
            Load += FPayWithQRCode_Load;
            ((System.ComponentModel.ISupportInitialize)pbQRCode).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateQRCode;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbBanks;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtSTK;
        private Label label3;
        private Label label4;
        private Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTemplate;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountName;
        private Guna.UI2.WinForms.Guna2TextBox txtInvoice;
        private Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtExtraInfo;
        private Guna.UI2.WinForms.Guna2PictureBox pbQRCode;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label24;
        private Guna.UI2.WinForms.Guna2CircleButton btnBack;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
    }
}