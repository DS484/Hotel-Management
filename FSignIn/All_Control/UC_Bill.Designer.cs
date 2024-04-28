namespace Hotel_Management.All_Control
{
    partial class UC_Bill
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            bcàAllBill = new Guna.UI2.WinForms.Guna2Button();
            btnExportFile = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            dgvBill = new DataGridView();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            dtpStartDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            lblCreateDay = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            Column12 = new DataGridViewImageColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column18 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 30;
            // 
            // bcàAllBill
            // 
            bcàAllBill.BackColor = Color.FromArgb(222, 241, 241);
            bcàAllBill.BorderRadius = 18;
            bcàAllBill.CustomizableEdges = customizableEdges1;
            bcàAllBill.DisabledState.BorderColor = Color.DarkGray;
            bcàAllBill.DisabledState.CustomBorderColor = Color.DarkGray;
            bcàAllBill.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bcàAllBill.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bcàAllBill.FillColor = Color.DarkOliveGreen;
            bcàAllBill.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bcàAllBill.ForeColor = Color.White;
            bcàAllBill.Location = new Point(857, 23);
            bcàAllBill.Margin = new Padding(3, 2, 3, 2);
            bcàAllBill.Name = "bcàAllBill";
            bcàAllBill.ShadowDecoration.CustomizableEdges = customizableEdges2;
            bcàAllBill.Size = new Size(164, 32);
            bcàAllBill.TabIndex = 18;
            bcàAllBill.Text = "Tất cả";
            // 
            // btnExportFile
            // 
            btnExportFile.BackColor = Color.FromArgb(222, 241, 241);
            btnExportFile.BorderRadius = 18;
            btnExportFile.Cursor = Cursors.Hand;
            btnExportFile.CustomizableEdges = customizableEdges3;
            btnExportFile.DisabledState.BorderColor = Color.DarkGray;
            btnExportFile.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExportFile.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExportFile.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExportFile.FillColor = Color.Goldenrod;
            btnExportFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportFile.ForeColor = Color.White;
            btnExportFile.Location = new Point(664, 23);
            btnExportFile.Margin = new Padding(3, 2, 3, 2);
            btnExportFile.Name = "btnExportFile";
            btnExportFile.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnExportFile.Size = new Size(164, 32);
            btnExportFile.TabIndex = 17;
            btnExportFile.Text = "Xuất file Excel";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvBill);
            panel1.Location = new Point(15, 59);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1140, 565);
            panel1.TabIndex = 19;
            // 
            // dgvBill
            // 
            dgvBill.AllowUserToAddRows = false;
            dgvBill.AllowUserToDeleteRows = false;
            dgvBill.AllowUserToResizeColumns = false;
            dgvBill.AllowUserToResizeRows = false;
            dgvBill.Anchor = AnchorStyles.None;
            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBill.BackgroundColor = Color.FromArgb(222, 241, 241);
            dgvBill.BorderStyle = BorderStyle.None;
            dgvBill.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBill.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(155, 215, 215);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(155, 215, 215);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBill.ColumnHeadersHeight = 50;
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBill.Columns.AddRange(new DataGridViewColumn[] { Column12, Column13, Column14, Column15, Column16, Column18 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 241, 241);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(187, 228, 228);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBill.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBill.EnableHeadersVisualStyles = false;
            dgvBill.GridColor = SystemColors.ControlDark;
            dgvBill.Location = new Point(2, 2);
            dgvBill.Margin = new Padding(2, 2, 2, 2);
            dgvBill.MultiSelect = false;
            dgvBill.Name = "dgvBill";
            dgvBill.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(154, 215, 215);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(154, 215, 215);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBill.RowHeadersVisible = false;
            dgvBill.RowHeadersWidth = 62;
            dgvBill.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvBill.RowTemplate.Height = 33;
            dgvBill.RowTemplate.ReadOnly = true;
            dgvBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBill.Size = new Size(1049, 559);
            dgvBill.TabIndex = 36;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 10;
            guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            // 
            // dtpStartDay
            // 
            dtpStartDay.BackColor = Color.FromArgb(222, 241, 241);
            dtpStartDay.BorderRadius = 18;
            dtpStartDay.BorderThickness = 2;
            dtpStartDay.Checked = true;
            dtpStartDay.Cursor = Cursors.Hand;
            dtpStartDay.CustomFormat = "dd/MM/yyyy";
            dtpStartDay.CustomizableEdges = customizableEdges7;
            dtpStartDay.FillColor = Color.FromArgb(155, 215, 215);
            dtpStartDay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpStartDay.Format = DateTimePickerFormat.Custom;
            dtpStartDay.Location = new Point(116, 20);
            dtpStartDay.Margin = new Padding(3, 2, 3, 2);
            dtpStartDay.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpStartDay.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpStartDay.Name = "dtpStartDay";
            dtpStartDay.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtpStartDay.Size = new Size(148, 35);
            dtpStartDay.TabIndex = 20;
            dtpStartDay.Tag = "";
            dtpStartDay.TextAlign = HorizontalAlignment.Center;
            dtpStartDay.Value = new DateTime(2024, 3, 3, 14, 9, 45, 140);
            // 
            // lblCreateDay
            // 
            lblCreateDay.BackColor = Color.Transparent;
            lblCreateDay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCreateDay.Location = new Point(17, 28);
            lblCreateDay.Margin = new Padding(2, 2, 2, 2);
            lblCreateDay.Name = "lblCreateDay";
            lblCreateDay.Size = new Size(89, 23);
            lblCreateDay.TabIndex = 21;
            lblCreateDay.Text = "Kể từ ngày:";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(222, 241, 241);
            btnSearch.BorderRadius = 18;
            btnSearch.CustomizableEdges = customizableEdges5;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.SeaGreen;
            btnSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(285, 23);
            btnSearch.Margin = new Padding(2, 2, 2, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSearch.Size = new Size(95, 30);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += btnSearch_Click;
            // 
            // Column12
            // 
            Column12.FillWeight = 10F;
            Column12.HeaderText = "";
            Column12.MinimumWidth = 80;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // Column13
            // 
            Column13.HeaderText = "Mã hóa đơn";
            Column13.MinimumWidth = 100;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            // 
            // Column14
            // 
            Column14.FillWeight = 79.85747F;
            Column14.HeaderText = "Tên khách hàng";
            Column14.MinimumWidth = 100;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            // 
            // Column15
            // 
            Column15.FillWeight = 79.85747F;
            Column15.HeaderText = "Phòng";
            Column15.MinimumWidth = 100;
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            // 
            // Column16
            // 
            Column16.FillWeight = 79.85747F;
            Column16.HeaderText = "Tổng đơn";
            Column16.MinimumWidth = 125;
            Column16.Name = "Column16";
            Column16.ReadOnly = true;
            // 
            // Column18
            // 
            Column18.FillWeight = 79.85747F;
            Column18.HeaderText = "Mã giảm giá";
            Column18.MinimumWidth = 200;
            Column18.Name = "Column18";
            Column18.ReadOnly = true;
            // 
            // UC_Bill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 241, 241);
            Controls.Add(btnSearch);
            Controls.Add(lblCreateDay);
            Controls.Add(dtpStartDay);
            Controls.Add(bcàAllBill);
            Controls.Add(btnExportFile);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_Bill";
            Size = new Size(1079, 635);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Button bcàAllBill;
        private Guna.UI2.WinForms.Guna2Button btnExportFile;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDay;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCreateDay;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        public DataGridView dgvBill;
        private DataGridViewImageColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column18;
    }
}
