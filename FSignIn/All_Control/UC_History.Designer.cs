namespace Hotel_Management.All_Control
{
    partial class UC_History
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblHotel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblRoomName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dtpCheckInDaten = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtpCheckOutDaten = new Guna.UI2.WinForms.Guna2DateTimePicker();
            n = new Guna.UI2.WinForms.Guna2HtmlLabel();
            m = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnEvaluate = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // lblHotel
            // 
            lblHotel.AutoSize = false;
            lblHotel.BackColor = Color.Transparent;
            lblHotel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHotel.Location = new Point(195, 19);
            lblHotel.Margin = new Padding(2);
            lblHotel.Name = "lblHotel";
            lblHotel.Size = new Size(159, 30);
            lblHotel.TabIndex = 0;
            lblHotel.Text = "...";
            lblHotel.Click += lblHotel_Click;
            // 
            // lblRoomName
            // 
            lblRoomName.AutoSize = false;
            lblRoomName.BackColor = Color.Transparent;
            lblRoomName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRoomName.Location = new Point(156, 66);
            lblRoomName.Margin = new Padding(2);
            lblRoomName.Name = "lblRoomName";
            lblRoomName.Size = new Size(120, 30);
            lblRoomName.TabIndex = 1;
            lblRoomName.Text = "...";
            lblRoomName.Click += lblRoomName_Click;
            // 
            // dtpCheckInDaten
            // 
            dtpCheckInDaten.Checked = true;
            dtpCheckInDaten.CustomizableEdges = customizableEdges1;
            dtpCheckInDaten.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpCheckInDaten.Format = DateTimePickerFormat.Short;
            dtpCheckInDaten.Location = new Point(410, 114);
            dtpCheckInDaten.Margin = new Padding(2);
            dtpCheckInDaten.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpCheckInDaten.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpCheckInDaten.Name = "dtpCheckInDaten";
            dtpCheckInDaten.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dtpCheckInDaten.Size = new Size(213, 35);
            dtpCheckInDaten.TabIndex = 2;
            dtpCheckInDaten.Value = new DateTime(2024, 3, 27, 0, 0, 0, 0);
            dtpCheckInDaten.ValueChanged += dtpCheckInDate_ValueChanged;
            // 
            // dtpCheckOutDaten
            // 
            dtpCheckOutDaten.Checked = true;
            dtpCheckOutDaten.CustomizableEdges = customizableEdges3;
            dtpCheckOutDaten.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpCheckOutDaten.Format = DateTimePickerFormat.Short;
            dtpCheckOutDaten.Location = new Point(410, 173);
            dtpCheckOutDaten.Margin = new Padding(2);
            dtpCheckOutDaten.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpCheckOutDaten.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpCheckOutDaten.Name = "dtpCheckOutDaten";
            dtpCheckOutDaten.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpCheckOutDaten.Size = new Size(213, 35);
            dtpCheckOutDaten.TabIndex = 2;
            dtpCheckOutDaten.Value = new DateTime(2024, 3, 27, 0, 0, 0, 0);
            dtpCheckOutDaten.ValueChanged += dtpCheckOutDate_ValueChanged;
            // 
            // n
            // 
            n.AutoSize = false;
            n.BackColor = Color.Transparent;
            n.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            n.Location = new Point(219, 119);
            n.Margin = new Padding(2);
            n.Name = "n";
            n.Size = new Size(183, 30);
            n.TabIndex = 3;
            n.Text = "...";
            n.Click += lblCheckInDate_Click;
            // 
            // m
            // 
            m.AutoSize = false;
            m.BackColor = Color.Transparent;
            m.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            m.Location = new Point(214, 173);
            m.Margin = new Padding(2);
            m.Name = "m";
            m.Size = new Size(178, 30);
            m.TabIndex = 4;
            m.Text = "...";
            m.Click += lblCheckOutDate_Click;
            // 
            // btnEvaluate
            // 
            btnEvaluate.BorderColor = Color.White;
            btnEvaluate.BorderRadius = 10;
            btnEvaluate.BorderThickness = 2;
            btnEvaluate.CustomizableEdges = customizableEdges5;
            btnEvaluate.DisabledState.BorderColor = Color.DarkGray;
            btnEvaluate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEvaluate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEvaluate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEvaluate.FillColor = Color.ForestGreen;
            btnEvaluate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEvaluate.ForeColor = Color.White;
            btnEvaluate.Location = new Point(659, 153);
            btnEvaluate.Margin = new Padding(2);
            btnEvaluate.Name = "btnEvaluate";
            btnEvaluate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnEvaluate.Size = new Size(171, 50);
            btnEvaluate.TabIndex = 5;
            btnEvaluate.Text = "Đánh giá";
            btnEvaluate.Click += btnEvaluate_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 18;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.AutoSize = false;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(32, 19);
            guna2HtmlLabel1.Margin = new Padding(2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(159, 30);
            guna2HtmlLabel1.TabIndex = 6;
            guna2HtmlLabel1.Text = "Tên khách sạn:";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.AutoSize = false;
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel2.Location = new Point(32, 66);
            guna2HtmlLabel2.Margin = new Padding(2);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(120, 30);
            guna2HtmlLabel2.TabIndex = 7;
            guna2HtmlLabel2.Text = "Mã phòng:";
            guna2HtmlLabel2.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.AutoSize = false;
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel3.Location = new Point(32, 119);
            guna2HtmlLabel3.Margin = new Padding(2);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(183, 30);
            guna2HtmlLabel3.TabIndex = 8;
            guna2HtmlLabel3.Text = "Ngày đặt phòng:";
            guna2HtmlLabel3.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.AutoSize = false;
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel4.Location = new Point(32, 173);
            guna2HtmlLabel4.Margin = new Padding(2);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(178, 30);
            guna2HtmlLabel4.TabIndex = 9;
            guna2HtmlLabel4.Text = "Ngày trả phòng:";
            guna2HtmlLabel4.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // UC_History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(btnEvaluate);
            Controls.Add(m);
            Controls.Add(n);
            Controls.Add(dtpCheckOutDaten);
            Controls.Add(dtpCheckInDaten);
            Controls.Add(lblRoomName);
            Controls.Add(lblHotel);
            Margin = new Padding(2);
            Name = "UC_History";
            Size = new Size(860, 221);
            Load += UC_History_Load;
            ResumeLayout(false);
        }

        #endregion

        public Guna.UI2.WinForms.Guna2HtmlLabel lblHotel;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblRoomName;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpCheckInDaten;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpCheckOutDaten;
        public Guna.UI2.WinForms.Guna2HtmlLabel n;
        public Guna.UI2.WinForms.Guna2HtmlLabel m;
        public Guna.UI2.WinForms.Guna2Button btnEvaluate;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
