﻿namespace Hotel_Management
{
    partial class FReason
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            btnCancelRoom = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cbReason1 = new CheckBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblHi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label3 = new Label();
            cbReason2 = new CheckBox();
            cbReason3 = new CheckBox();
            cbReason4 = new CheckBox();
            txtOther = new RichTextBox();
            guna2ShadowPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ShadowPanel3
            // 
            guna2ShadowPanel3.BackColor = Color.Transparent;
            guna2ShadowPanel3.Controls.Add(txtOther);
            guna2ShadowPanel3.Controls.Add(cbReason4);
            guna2ShadowPanel3.Controls.Add(cbReason3);
            guna2ShadowPanel3.Controls.Add(cbReason2);
            guna2ShadowPanel3.Controls.Add(btnCancelRoom);
            guna2ShadowPanel3.Controls.Add(guna2HtmlLabel3);
            guna2ShadowPanel3.Controls.Add(cbReason1);
            guna2ShadowPanel3.Controls.Add(guna2HtmlLabel2);
            guna2ShadowPanel3.Controls.Add(lblHi);
            guna2ShadowPanel3.Controls.Add(guna2HtmlLabel1);
            guna2ShadowPanel3.Controls.Add(label3);
            guna2ShadowPanel3.FillColor = Color.White;
            guna2ShadowPanel3.Location = new Point(32, 2);
            guna2ShadowPanel3.Margin = new Padding(4);
            guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            guna2ShadowPanel3.Radius = 10;
            guna2ShadowPanel3.ShadowColor = Color.Silver;
            guna2ShadowPanel3.ShadowShift = 18;
            guna2ShadowPanel3.Size = new Size(604, 711);
            guna2ShadowPanel3.TabIndex = 86;
            // 
            // btnCancelRoom
            // 
            btnCancelRoom.BorderRadius = 10;
            btnCancelRoom.BorderThickness = 2;
            btnCancelRoom.CustomizableEdges = customizableEdges1;
            btnCancelRoom.DisabledState.BorderColor = Color.DarkGray;
            btnCancelRoom.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelRoom.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelRoom.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelRoom.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelRoom.ForeColor = Color.White;
            btnCancelRoom.Location = new Point(247, 623);
            btnCancelRoom.Name = "btnCancelRoom";
            btnCancelRoom.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCancelRoom.Size = new Size(133, 50);
            btnCancelRoom.TabIndex = 97;
            btnCancelRoom.Text = "Trả phòng";
            btnCancelRoom.Click += btnCancelRoom_Click;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel3.Location = new Point(70, 451);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(51, 30);
            guna2HtmlLabel3.TabIndex = 95;
            guna2HtmlLabel3.Text = "Khác:";
            // 
            // cbReason1
            // 
            cbReason1.AutoSize = true;
            cbReason1.Location = new Point(69, 258);
            cbReason1.Name = "cbReason1";
            cbReason1.Size = new Size(239, 29);
            cbReason1.TabIndex = 90;
            cbReason1.Text = "Thay đổi kế hoạch du lịch";
            cbReason1.UseVisualStyleBackColor = true;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel2.Location = new Point(69, 206);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(242, 30);
            guna2HtmlLabel2.TabIndex = 89;
            guna2HtmlLabel2.Text = "Lý do bạn trả phòng là gì?";
            // 
            // lblHi
            // 
            lblHi.AutoSize = false;
            lblHi.BackColor = Color.Transparent;
            lblHi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHi.ForeColor = SystemColors.ActiveCaptionText;
            lblHi.Location = new Point(69, 151);
            lblHi.Margin = new Padding(2);
            lblHi.Name = "lblHi";
            lblHi.Size = new Size(443, 38);
            lblHi.TabIndex = 88;
            lblHi.Text = "Xin chào, ";
            lblHi.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(118, 121);
            guna2HtmlLabel1.Margin = new Padding(2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(3, 2);
            guna2HtmlLabel1.TabIndex = 85;
            guna2HtmlLabel1.Text = null;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(604, 119);
            label3.TabIndex = 69;
            label3.Text = "Lý do trả phòng";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // cbReason2
            // 
            cbReason2.AutoSize = true;
            cbReason2.Location = new Point(69, 307);
            cbReason2.Name = "cbReason2";
            cbReason2.Size = new Size(244, 29);
            cbReason2.TabIndex = 98;
            cbReason2.Text = "Không hài lòng về dịch vụ";
            cbReason2.UseVisualStyleBackColor = true;
            // 
            // cbReason3
            // 
            cbReason3.AutoSize = true;
            cbReason3.Location = new Point(70, 354);
            cbReason3.Name = "cbReason3";
            cbReason3.Size = new Size(291, 29);
            cbReason3.TabIndex = 99;
            cbReason3.Text = "Có công việc, kế hoạch đột xuất";
            cbReason3.UseVisualStyleBackColor = true;
            // 
            // cbReason4
            // 
            cbReason4.AutoSize = true;
            cbReason4.Location = new Point(70, 405);
            cbReason4.Name = "cbReason4";
            cbReason4.Size = new Size(169, 29);
            cbReason4.TabIndex = 100;
            cbReason4.Text = "Không thoải mái";
            cbReason4.UseVisualStyleBackColor = true;
            // 
            // txtOther
            // 
            txtOther.Location = new Point(141, 451);
            txtOther.Name = "txtOther";
            txtOther.Size = new Size(410, 144);
            txtOther.TabIndex = 101;
            txtOther.Text = "";
            // 
            // FReason
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 705);
            Controls.Add(guna2ShadowPanel3);
            Name = "FReason";
            Text = "FReason";
            guna2ShadowPanel3.ResumeLayout(false);
            guna2ShadowPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHi;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label label3;
        private RichTextBox richTextBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox cbReason1;
        private Guna.UI2.WinForms.Guna2Button btnCancelRoom;
        private RichTextBox txtOther;
        private CheckBox cbReason4;
        private CheckBox cbReason3;
        private CheckBox cbReason2;
    }
}