﻿namespace Hotel_Management
{
    partial class FSignIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSignIn));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            panel2 = new Panel();
            btnHide = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            uC_SignUp1 = new All_Control.UC_SignUp();
            uC_Login1 = new All_Control.UC_Login();
            uC_FogetPasswork1 = new All_Control.UC_FogetPasswork();
            pictureBox1 = new PictureBox();
            uC_Shape1 = new All_Control.UC_Shape();
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 30;
            guna2Elipse2.TargetControl = panel1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(uC_SignUp1);
            panel1.Controls.Add(uC_Login1);
            panel1.Controls.Add(uC_FogetPasswork1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(uC_Shape1);
            panel1.Location = new Point(15, 15);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1390, 821);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnHide);
            panel2.Controls.Add(guna2CircleButton3);
            panel2.Controls.Add(btnExit);
            panel2.Location = new Point(1255, 4);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(121, 38);
            panel2.TabIndex = 39;
            // 
            // btnHide
            // 
            btnHide.DisabledState.BorderColor = Color.DarkGray;
            btnHide.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHide.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHide.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHide.FillColor = Color.Transparent;
            btnHide.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnHide.ForeColor = Color.White;
            btnHide.Image = (Image)resources.GetObject("btnHide.Image");
            btnHide.ImageSize = new Size(22, 22);
            btnHide.Location = new Point(8, 2);
            btnHide.Margin = new Padding(4);
            btnHide.Name = "btnHide";
            btnHide.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnHide.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnHide.Size = new Size(31, 31);
            btnHide.TabIndex = 39;
            // 
            // guna2CircleButton3
            // 
            guna2CircleButton3.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton3.FillColor = Color.Transparent;
            guna2CircleButton3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2CircleButton3.ForeColor = Color.White;
            guna2CircleButton3.Image = (Image)resources.GetObject("guna2CircleButton3.Image");
            guna2CircleButton3.ImageSize = new Size(25, 25);
            guna2CircleButton3.Location = new Point(46, 2);
            guna2CircleButton3.Margin = new Padding(4);
            guna2CircleButton3.Name = "guna2CircleButton3";
            guna2CircleButton3.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton3.Size = new Size(31, 31);
            guna2CircleButton3.TabIndex = 39;
            // 
            // btnExit
            // 
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.Transparent;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageSize = new Size(22, 22);
            btnExit.Location = new Point(85, 2);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(31, 31);
            btnExit.TabIndex = 38;
            btnExit.Click += btnExit_Click_2;
            // 
            // uC_SignUp1
            // 
            uC_SignUp1.BackColor = Color.White;
            uC_SignUp1.Location = new Point(804, 38);
            uC_SignUp1.Margin = new Padding(5);
            uC_SignUp1.Name = "uC_SignUp1";
            uC_SignUp1.Size = new Size(572, 772);
            uC_SignUp1.TabIndex = 27;
            uC_SignUp1.Load += uC_SignUp1_Load;
            // 
            // uC_Login1
            // 
            uC_Login1.BackColor = Color.White;
            uC_Login1.Location = new Point(804, 288);
            uC_Login1.Margin = new Padding(5);
            uC_Login1.Name = "uC_Login1";
            uC_Login1.Size = new Size(532, 534);
            uC_Login1.TabIndex = 25;
            // 
            // uC_FogetPasswork1
            // 
            uC_FogetPasswork1.BackColor = Color.White;
            uC_FogetPasswork1.Location = new Point(804, 288);
            uC_FogetPasswork1.Margin = new Padding(5);
            uC_FogetPasswork1.Name = "uC_FogetPasswork1";
            uC_FogetPasswork1.Size = new Size(532, 530);
            uC_FogetPasswork1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-176, 91);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1035, 719);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            // 
            // uC_Shape1
            // 
            uC_Shape1.BackColor = Color.White;
            uC_Shape1.Location = new Point(804, 38);
            uC_Shape1.Margin = new Padding(5);
            uC_Shape1.Name = "uC_Shape1";
            uC_Shape1.Size = new Size(532, 245);
            uC_Shape1.TabIndex = 28;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 30;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.BorderRadius = 30;
            // 
            // guna2Elipse5
            // 
            guna2Elipse5.BorderRadius = 30;
            // 
            // FSignIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1420, 884);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(216, 148);
            Margin = new Padding(4);
            Name = "FSignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FSignIn_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Panel panel1;
        private All_Control.UC_Login uC_Login1;
        private All_Control.UC_FogetPasswork uC_FogetPasswork1;
        private PictureBox pictureBox1;
        private All_Control.UC_Shape uC_Shape1;
        public All_Control.UC_SignUp uC_SignUp1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnHide;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}