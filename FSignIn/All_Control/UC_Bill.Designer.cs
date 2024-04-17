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
            dgvBill = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            dtpStartDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            lblCreateDay = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            Column1 = new DataGridViewImageColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
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
            bcàAllBill.BackColor = Color.WhiteSmoke;
            bcàAllBill.BorderRadius = 18;
            bcàAllBill.CustomizableEdges = customizableEdges1;
            bcàAllBill.DisabledState.BorderColor = Color.DarkGray;
            bcàAllBill.DisabledState.CustomBorderColor = Color.DarkGray;
            bcàAllBill.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bcàAllBill.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bcàAllBill.FillColor = Color.DarkOliveGreen;
            bcàAllBill.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bcàAllBill.ForeColor = Color.White;
            bcàAllBill.Location = new Point(1224, 38);
            bcàAllBill.Margin = new Padding(4);
            bcàAllBill.Name = "bcàAllBill";
            bcàAllBill.ShadowDecoration.CustomizableEdges = customizableEdges2;
            bcàAllBill.Size = new Size(234, 54);
            bcàAllBill.TabIndex = 18;
            bcàAllBill.Text = "Tất cả";
            // 
            // btnExportFile
            // 
            btnExportFile.BackColor = Color.WhiteSmoke;
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
            btnExportFile.Location = new Point(948, 38);
            btnExportFile.Margin = new Padding(4);
            btnExportFile.Name = "btnExportFile";
            btnExportFile.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnExportFile.Size = new Size(234, 54);
            btnExportFile.TabIndex = 17;
            btnExportFile.Text = "Xuất file Excel";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvBill);
            panel1.Location = new Point(21, 99);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1628, 942);
            panel1.TabIndex = 19;
            // 
            // dgvBill
            // 
            dgvBill.AllowUserToAddRows = false;
            dgvBill.AllowUserToDeleteRows = false;
            dgvBill.AllowUserToResizeColumns = false;
            dgvBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(201, 231, 203);
            dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBill.BackgroundColor = Color.MediumSeaGreen;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(76, 175, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBill.ColumnHeadersHeight = 50;
            dgvBill.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(219, 239, 220);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(135, 201, 138);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBill.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBill.GridColor = Color.FromArgb(199, 231, 201);
            dgvBill.Location = new Point(3, 0);
            dgvBill.MultiSelect = false;
            dgvBill.Name = "dgvBill";
            dgvBill.ReadOnly = true;
            dgvBill.RowHeadersVisible = false;
            dgvBill.RowHeadersWidth = 40;
            dgvBill.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvBill.RowTemplate.Height = 33;
            dgvBill.Size = new Size(1527, 936);
            dgvBill.TabIndex = 32;
            dgvBill.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            dgvBill.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(201, 231, 203);
            dgvBill.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvBill.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvBill.ThemeStyle.BackColor = Color.MediumSeaGreen;
            dgvBill.ThemeStyle.GridColor = Color.FromArgb(199, 231, 201);
            dgvBill.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(76, 175, 80);
            dgvBill.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBill.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvBill.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvBill.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBill.ThemeStyle.HeaderStyle.Height = 50;
            dgvBill.ThemeStyle.ReadOnly = true;
            dgvBill.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(219, 239, 220);
            dgvBill.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBill.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvBill.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvBill.ThemeStyle.RowsStyle.Height = 33;
            dgvBill.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(135, 201, 138);
            dgvBill.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            dgvBill.CellContentClick += dgvBill_CellContentClick;
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
            dtpStartDay.BackColor = Color.WhiteSmoke;
            dtpStartDay.BorderRadius = 18;
            dtpStartDay.BorderThickness = 2;
            dtpStartDay.Checked = true;
            dtpStartDay.Cursor = Cursors.Hand;
            dtpStartDay.CustomFormat = "dd/MM/yyyy";
            dtpStartDay.CustomizableEdges = customizableEdges7;
            dtpStartDay.FillColor = Color.WhiteSmoke;
            dtpStartDay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtpStartDay.Format = DateTimePickerFormat.Custom;
            dtpStartDay.Location = new Point(165, 34);
            dtpStartDay.Margin = new Padding(4);
            dtpStartDay.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpStartDay.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpStartDay.Name = "dtpStartDay";
            dtpStartDay.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtpStartDay.Size = new Size(212, 58);
            dtpStartDay.TabIndex = 20;
            dtpStartDay.Tag = "";
            dtpStartDay.TextAlign = HorizontalAlignment.Center;
            dtpStartDay.Value = new DateTime(2024, 3, 3, 14, 9, 45, 140);
            // 
            // lblCreateDay
            // 
            lblCreateDay.BackColor = Color.Transparent;
            lblCreateDay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCreateDay.Location = new Point(24, 47);
            lblCreateDay.Name = "lblCreateDay";
            lblCreateDay.Size = new Size(134, 34);
            lblCreateDay.TabIndex = 21;
            lblCreateDay.Text = "Kể từ ngày:";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.WhiteSmoke;
            btnSearch.BorderRadius = 18;
            btnSearch.CustomizableEdges = customizableEdges5;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.SeaGreen;
            btnSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(407, 38);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSearch.Size = new Size(136, 50);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += btnSearch_Click;
            // 
            // Column1
            // 
            Column1.FillWeight = 10F;
            Column1.HeaderText = "";
            Column1.MinimumWidth = 70;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.FillWeight = 50F;
            Column2.HeaderText = "Mã hóa đơn";
            Column2.MinimumWidth = 150;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.FillWeight = 50F;
            Column3.HeaderText = "Tên khách hàng";
            Column3.MinimumWidth = 200;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.FillWeight = 50F;
            Column4.HeaderText = "Phòng";
            Column4.MinimumWidth = 150;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.FillWeight = 50F;
            Column5.HeaderText = "Tổng đơn";
            Column5.MinimumWidth = 200;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.FillWeight = 50F;
            Column6.HeaderText = "Tạo ngày";
            Column6.MinimumWidth = 150;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Mã giảm giá";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // UC_Bill
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(btnSearch);
            Controls.Add(lblCreateDay);
            Controls.Add(dtpStartDay);
            Controls.Add(bcàAllBill);
            Controls.Add(btnExportFile);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Margin = new Padding(4);
            Name = "UC_Bill";
            Size = new Size(1542, 1059);
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvBill;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCreateDay;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private DataGridViewImageColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}
