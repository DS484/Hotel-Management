namespace Hotel_Management.All_Control
{
    partial class UC_Admin
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvRoom = new DataGridView();
            Column12 = new DataGridViewImageColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            Column18 = new DataGridViewTextBoxColumn();
            Column19 = new DataGridViewTextBoxColumn();
            Column20 = new DataGridViewTextBoxColumn();
            Column21 = new DataGridViewImageColumn();
            Column22 = new DataGridViewImageColumn();
            Column26 = new DataGridViewTextBoxColumn();
            Column25 = new DataGridViewTextBoxColumn();
            Column28 = new DataGridViewTextBoxColumn();
            Column23 = new DataGridViewTextBoxColumn();
            Column24 = new DataGridViewTextBoxColumn();
            Column27 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRoom).BeginInit();
            SuspendLayout();
            // 
            // dgvRoom
            // 
            dgvRoom.AllowUserToAddRows = false;
            dgvRoom.AllowUserToDeleteRows = false;
            dgvRoom.AllowUserToResizeColumns = false;
            dgvRoom.AllowUserToResizeRows = false;
            dgvRoom.Anchor = AnchorStyles.None;
            dgvRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoom.BackgroundColor = Color.FromArgb(222, 241, 241);
            dgvRoom.BorderStyle = BorderStyle.None;
            dgvRoom.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvRoom.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(155, 215, 215);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(155, 215, 215);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRoom.ColumnHeadersHeight = 50;
            dgvRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRoom.Columns.AddRange(new DataGridViewColumn[] { Column12, Column13, Column14, Column15, Column16, Column17, Column18, Column19, Column20, Column21, Column22, Column26, Column25, Column28, Column23, Column24, Column27 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 241, 241);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(187, 228, 228);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRoom.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRoom.EnableHeadersVisualStyles = false;
            dgvRoom.GridColor = SystemColors.ControlDark;
            dgvRoom.Location = new Point(19, 124);
            dgvRoom.MultiSelect = false;
            dgvRoom.Name = "dgvRoom";
            dgvRoom.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(154, 215, 215);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(154, 215, 215);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRoom.RowHeadersVisible = false;
            dgvRoom.RowHeadersWidth = 62;
            dgvRoom.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRoom.RowTemplate.Height = 33;
            dgvRoom.RowTemplate.ReadOnly = true;
            dgvRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoom.Size = new Size(1498, 932);
            dgvRoom.TabIndex = 36;
            // 
            // Column12
            // 
            Column12.FillWeight = 79.85747F;
            Column12.HeaderText = "";
            Column12.MinimumWidth = 8;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // Column13
            // 
            Column13.HeaderText = "Phòng";
            Column13.MinimumWidth = 100;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            // 
            // Column14
            // 
            Column14.FillWeight = 79.85747F;
            Column14.HeaderText = "Người lớn";
            Column14.MinimumWidth = 100;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            // 
            // Column15
            // 
            Column15.FillWeight = 79.85747F;
            Column15.HeaderText = "Trẻ em";
            Column15.MinimumWidth = 100;
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            // 
            // Column16
            // 
            Column16.FillWeight = 79.85747F;
            Column16.HeaderText = "Giá cũ";
            Column16.MinimumWidth = 125;
            Column16.Name = "Column16";
            Column16.ReadOnly = true;
            // 
            // Column17
            // 
            Column17.FillWeight = 79.85747F;
            Column17.HeaderText = "Giá mới ";
            Column17.MinimumWidth = 125;
            Column17.Name = "Column17";
            Column17.ReadOnly = true;
            // 
            // Column18
            // 
            Column18.FillWeight = 79.85747F;
            Column18.HeaderText = "Mô tả";
            Column18.MinimumWidth = 200;
            Column18.Name = "Column18";
            Column18.ReadOnly = true;
            // 
            // Column19
            // 
            Column19.FillWeight = 79.85747F;
            Column19.HeaderText = "Ngày mở phòng";
            Column19.MinimumWidth = 200;
            Column19.Name = "Column19";
            Column19.ReadOnly = true;
            // 
            // Column20
            // 
            Column20.FillWeight = 79.85747F;
            Column20.HeaderText = "Ngày đóng phòng";
            Column20.MinimumWidth = 200;
            Column20.Name = "Column20";
            Column20.ReadOnly = true;
            // 
            // Column21
            // 
            Column21.FillWeight = 79.85747F;
            Column21.HeaderText = "Sửa";
            Column21.MinimumWidth = 75;
            Column21.Name = "Column21";
            Column21.ReadOnly = true;
            // 
            // Column22
            // 
            Column22.FillWeight = 79.85747F;
            Column22.HeaderText = "Xóa";
            Column22.MinimumWidth = 75;
            Column22.Name = "Column22";
            Column22.ReadOnly = true;
            // 
            // Column26
            // 
            Column26.FillWeight = 76.97106F;
            Column26.HeaderText = "";
            Column26.MinimumWidth = 10;
            Column26.Name = "Column26";
            Column26.ReadOnly = true;
            // 
            // Column25
            // 
            Column25.FillWeight = 79.85747F;
            Column25.HeaderText = "";
            Column25.MinimumWidth = 8;
            Column25.Name = "Column25";
            Column25.ReadOnly = true;
            // 
            // Column28
            // 
            Column28.FillWeight = 79.85747F;
            Column28.HeaderText = "";
            Column28.MinimumWidth = 8;
            Column28.Name = "Column28";
            Column28.ReadOnly = true;
            // 
            // Column23
            // 
            Column23.FillWeight = 79.85747F;
            Column23.HeaderText = "";
            Column23.MinimumWidth = 8;
            Column23.Name = "Column23";
            Column23.ReadOnly = true;
            // 
            // Column24
            // 
            Column24.FillWeight = 60.7063255F;
            Column24.HeaderText = "";
            Column24.MinimumWidth = 8;
            Column24.Name = "Column24";
            Column24.ReadOnly = true;
            // 
            // Column27
            // 
            Column27.FillWeight = 79.85747F;
            Column27.HeaderText = "";
            Column27.MinimumWidth = 8;
            Column27.Name = "Column27";
            Column27.ReadOnly = true;
            // 
            // UC_Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 236, 236);
            Controls.Add(dgvRoom);
            Name = "UC_Admin";
            Size = new Size(1542, 1059);
            ((System.ComponentModel.ISupportInitialize)dgvRoom).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dgvRoom;
        private DataGridViewImageColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewTextBoxColumn Column20;
        private DataGridViewImageColumn Column21;
        private DataGridViewImageColumn Column22;
        private DataGridViewTextBoxColumn Column26;
        private DataGridViewTextBoxColumn Column25;
        private DataGridViewTextBoxColumn Column28;
        private DataGridViewTextBoxColumn Column23;
        private DataGridViewTextBoxColumn Column24;
        private DataGridViewTextBoxColumn Column27;
    }
}
