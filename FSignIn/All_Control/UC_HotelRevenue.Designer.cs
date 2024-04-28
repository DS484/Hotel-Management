namespace Hotel_Management.All_Control
{
    partial class UC_HotelRevenue
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HotelRevenue));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnChart = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            dgvRoom = new DataGridView();
            txtSearchRoom = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoom).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 10;
            // 
            // btnChart
            // 
            btnChart.BackColor = Color.FromArgb(207, 236, 236);
            btnChart.BorderRadius = 18;
            btnChart.Cursor = Cursors.Hand;
            btnChart.CustomizableEdges = customizableEdges1;
            btnChart.DisabledState.BorderColor = Color.DarkGray;
            btnChart.DisabledState.CustomBorderColor = Color.DarkGray;
            btnChart.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnChart.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnChart.FillColor = Color.DarkOliveGreen;
            btnChart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChart.ForeColor = Color.White;
            btnChart.Location = new Point(827, 15);
            btnChart.Margin = new Padding(3, 2, 3, 2);
            btnChart.Name = "btnChart";
            btnChart.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnChart.Size = new Size(164, 32);
            btnChart.TabIndex = 50;
            btnChart.Text = "Biểu đồ";
            btnChart.Click += btnChart_Click;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 30;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(207, 236, 236);
            btnSearch.BorderRadius = 18;
            btnSearch.CustomizableEdges = customizableEdges3;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.SeaGreen;
            btnSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(281, 17);
            btnSearch.Margin = new Padding(1, 1, 1, 1);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSearch.Size = new Size(95, 30);
            btnSearch.TabIndex = 51;
            btnSearch.Text = "Tìm kiếm";
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(dgvRoom);
            guna2ShadowPanel1.FillColor = Color.WhiteSmoke;
            guna2ShadowPanel1.Location = new Point(13, 57);
            guna2ShadowPanel1.Margin = new Padding(3, 2, 3, 2);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.DimGray;
            guna2ShadowPanel1.ShadowShift = 10;
            guna2ShadowPanel1.Size = new Size(1053, 563);
            guna2ShadowPanel1.TabIndex = 52;
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
            dgvRoom.Location = new Point(2, 2);
            dgvRoom.Margin = new Padding(2, 2, 2, 2);
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
            dgvRoom.Size = new Size(1049, 559);
            dgvRoom.TabIndex = 35;
            // 
            // txtSearchRoom
            // 
            txtSearchRoom.BorderColor = Color.Gray;
            txtSearchRoom.BorderRadius = 18;
            txtSearchRoom.Cursor = Cursors.Hand;
            txtSearchRoom.CustomizableEdges = customizableEdges5;
            txtSearchRoom.DefaultText = "";
            txtSearchRoom.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchRoom.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchRoom.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchRoom.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchRoom.FillColor = Color.FromArgb(207, 236, 236);
            txtSearchRoom.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchRoom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchRoom.ForeColor = Color.DimGray;
            txtSearchRoom.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchRoom.IconLeft = (Image)resources.GetObject("txtSearchRoom.IconLeft");
            txtSearchRoom.IconLeftSize = new Size(30, 30);
            txtSearchRoom.Location = new Point(13, 15);
            txtSearchRoom.Margin = new Padding(6, 7, 6, 7);
            txtSearchRoom.Name = "txtSearchRoom";
            txtSearchRoom.Padding = new Padding(8, 0, 0, 0);
            txtSearchRoom.PasswordChar = '\0';
            txtSearchRoom.PlaceholderForeColor = Color.DimGray;
            txtSearchRoom.PlaceholderText = "|Nhập mã phòng cần tìm...";
            txtSearchRoom.SelectedText = "";
            txtSearchRoom.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtSearchRoom.Size = new Size(259, 32);
            txtSearchRoom.TabIndex = 48;
            // 
            // UC_HotelRevenue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 236, 236);
            Controls.Add(btnChart);
            Controls.Add(btnSearch);
            Controls.Add(guna2ShadowPanel1);
            Controls.Add(txtSearchRoom);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UC_HotelRevenue";
            Size = new Size(1079, 635);
            guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoom).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public Guna.UI2.WinForms.Guna2Button btnChart;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        public DataGridView dgvRoom;
        public Guna.UI2.WinForms.Guna2TextBox txtSearchRoom;
    }
}
