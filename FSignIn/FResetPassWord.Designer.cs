﻿namespace Hotel_Management
{
    partial class FResetPassWord
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FResetPassWord));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            pbCheckPass = new Guna.UI2.WinForms.Guna2PictureBox();
            btnExit = new Guna.UI2.WinForms.Guna2Button();
            btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            txtConfirmPass = new Guna.UI2.WinForms.Guna2TextBox();
            txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox1 = new PictureBox();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCheckPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.BorderColor = Color.DimGray;
            guna2Panel1.BorderRadius = 18;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(pbCheckPass);
            guna2Panel1.Controls.Add(btnExit);
            guna2Panel1.Controls.Add(btnConfirm);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(txtConfirmPass);
            guna2Panel1.Controls.Add(txtPass);
            guna2Panel1.Controls.Add(pictureBox1);
            guna2Panel1.CustomizableEdges = customizableEdges11;
            guna2Panel1.Location = new Point(0, 1);
            guna2Panel1.Margin = new Padding(3, 2, 3, 2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel1.Size = new Size(973, 493);
            guna2Panel1.TabIndex = 41;
            // 
            // pbCheckPass
            // 
            pbCheckPass.CustomizableEdges = customizableEdges1;
            pbCheckPass.ErrorImage = (Image)resources.GetObject("pbCheckPass.ErrorImage");
            pbCheckPass.FillColor = Color.WhiteSmoke;
            pbCheckPass.Image = (Image)resources.GetObject("pbCheckPass.Image");
            pbCheckPass.ImageRotate = 0F;
            pbCheckPass.InitialImage = (Image)resources.GetObject("pbCheckPass.InitialImage");
            pbCheckPass.Location = new Point(911, 260);
            pbCheckPass.Margin = new Padding(2);
            pbCheckPass.Name = "pbCheckPass";
            pbCheckPass.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pbCheckPass.Size = new Size(22, 19);
            pbCheckPass.TabIndex = 51;
            pbCheckPass.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BorderRadius = 10;
            btnExit.BorderThickness = 2;
            btnExit.CustomizableEdges = customizableEdges3;
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(830, 340);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnExit.Size = new Size(103, 46);
            btnExit.TabIndex = 50;
            btnExit.Text = "Thoát";
            btnExit.Click += btnExit_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BorderRadius = 10;
            btnConfirm.BorderThickness = 2;
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.CustomizableEdges = customizableEdges5;
            btnConfirm.DisabledState.BorderColor = Color.DarkGray;
            btnConfirm.DisabledState.CustomBorderColor = Color.DarkGray;
            btnConfirm.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnConfirm.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnConfirm.FillColor = Color.Green;
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(675, 340);
            btnConfirm.Margin = new Padding(3, 2, 3, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnConfirm.Size = new Size(103, 46);
            btnConfirm.TabIndex = 49;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(650, 78);
            label2.Name = "label2";
            label2.Size = new Size(316, 52);
            label2.TabIndex = 46;
            label2.Text = "Đặt lại mật khẩu";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.BorderRadius = 10;
            txtConfirmPass.BorderThickness = 2;
            txtConfirmPass.Cursor = Cursors.Hand;
            txtConfirmPass.CustomizableEdges = customizableEdges7;
            txtConfirmPass.DefaultText = "";
            txtConfirmPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtConfirmPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtConfirmPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmPass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtConfirmPass.ForeColor = Color.Black;
            txtConfirmPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmPass.IconLeft = (Image)resources.GetObject("txtConfirmPass.IconLeft");
            txtConfirmPass.IconLeftSize = new Size(30, 30);
            txtConfirmPass.Location = new Point(651, 249);
            txtConfirmPass.Margin = new Padding(4, 6, 4, 6);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '\0';
            txtConfirmPass.PlaceholderText = "Xác nhận mật khẩu mới";
            txtConfirmPass.SelectedText = "";
            txtConfirmPass.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtConfirmPass.Size = new Size(304, 39);
            txtConfirmPass.TabIndex = 47;
            txtConfirmPass.TextChanged += txtConfirmPass_TextChanged;
            // 
            // txtPass
            // 
            txtPass.BorderRadius = 10;
            txtPass.BorderThickness = 2;
            txtPass.Cursor = Cursors.Hand;
            txtPass.CustomizableEdges = customizableEdges9;
            txtPass.DefaultText = "";
            txtPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPass.ForeColor = Color.Black;
            txtPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPass.IconLeft = (Image)resources.GetObject("txtPass.IconLeft");
            txtPass.IconLeftSize = new Size(30, 30);
            txtPass.Location = new Point(651, 166);
            txtPass.Margin = new Padding(4, 6, 4, 6);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '\0';
            txtPass.PlaceholderText = "Nhập mật khẩu mới";
            txtPass.SelectedText = "";
            txtPass.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtPass.Size = new Size(304, 39);
            txtPass.TabIndex = 48;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 24);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(632, 431);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            // 
            // FResetPassWord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 491);
            Controls.Add(guna2Panel1);
            Margin = new Padding(2);
            Name = "FResetPassWord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FResetPassWord";
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCheckPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox pbCheckPass;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        public Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPass;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
    }
}