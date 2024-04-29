namespace Hotel_Management.All_Control
{
    partial class UC_HotelManyReview
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HotelManyReview));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            dgvHotel = new DataGridView();
            Column1 = new DataGridViewImageColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            txtHotelName = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            ((System.ComponentModel.ISupportInitialize)dgvHotel).BeginInit();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 10;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 30;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(207, 236, 236);
            btnSearch.BorderRadius = 18;
            btnSearch.CustomizableEdges = customizableEdges1;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.SeaGreen;
            btnSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(281, 17);
            btnSearch.Margin = new Padding(1);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSearch.Size = new Size(95, 30);
            btnSearch.TabIndex = 51;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvHotel
            // 
            dgvHotel.AllowUserToAddRows = false;
            dgvHotel.AllowUserToDeleteRows = false;
            dgvHotel.AllowUserToResizeColumns = false;
            dgvHotel.AllowUserToResizeRows = false;
            dgvHotel.Anchor = AnchorStyles.None;
            dgvHotel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHotel.BackgroundColor = Color.FromArgb(222, 241, 241);
            dgvHotel.BorderStyle = BorderStyle.None;
            dgvHotel.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvHotel.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(155, 215, 215);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(155, 215, 215);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHotel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHotel.ColumnHeadersHeight = 50;
            dgvHotel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHotel.Columns.AddRange(new DataGridViewColumn[] { Column1, Column13, Column14, Column15, Column16, Column17 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 241, 241);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(187, 228, 228);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHotel.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHotel.EnableHeadersVisualStyles = false;
            dgvHotel.GridColor = SystemColors.ControlDark;
            dgvHotel.Location = new Point(2, 2);
            dgvHotel.Margin = new Padding(2);
            dgvHotel.MultiSelect = false;
            dgvHotel.Name = "dgvHotel";
            dgvHotel.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(154, 215, 215);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(154, 215, 215);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvHotel.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvHotel.RowHeadersVisible = false;
            dgvHotel.RowHeadersWidth = 62;
            dgvHotel.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvHotel.RowTemplate.Height = 33;
            dgvHotel.RowTemplate.ReadOnly = true;
            dgvHotel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHotel.Size = new Size(1049, 559);
            dgvHotel.TabIndex = 35;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column13
            // 
            Column13.HeaderText = "ID";
            Column13.MinimumWidth = 100;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            // 
            // Column14
            // 
            Column14.FillWeight = 79.85747F;
            Column14.HeaderText = "Tên khách sạn";
            Column14.MinimumWidth = 100;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            // 
            // Column15
            // 
            Column15.FillWeight = 79.85747F;
            Column15.HeaderText = "Khu vực";
            Column15.MinimumWidth = 100;
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            // 
            // Column16
            // 
            Column16.FillWeight = 79.85747F;
            Column16.HeaderText = "Thành phố";
            Column16.MinimumWidth = 125;
            Column16.Name = "Column16";
            Column16.ReadOnly = true;
            // 
            // Column17
            // 
            Column17.FillWeight = 79.85747F;
            Column17.HeaderText = "Số lượt đánh giá";
            Column17.MinimumWidth = 125;
            Column17.Name = "Column17";
            Column17.ReadOnly = true;
            // 
            // txtHotelName
            // 
            txtHotelName.BorderColor = Color.Gray;
            txtHotelName.BorderRadius = 18;
            txtHotelName.Cursor = Cursors.Hand;
            txtHotelName.CustomizableEdges = customizableEdges3;
            txtHotelName.DefaultText = "";
            txtHotelName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtHotelName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtHotelName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtHotelName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtHotelName.FillColor = Color.FromArgb(207, 236, 236);
            txtHotelName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtHotelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHotelName.ForeColor = Color.DimGray;
            txtHotelName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtHotelName.IconLeft = (Image)resources.GetObject("txtHotelName.IconLeft");
            txtHotelName.IconLeftSize = new Size(30, 30);
            txtHotelName.Location = new Point(13, 15);
            txtHotelName.Margin = new Padding(6, 7, 6, 7);
            txtHotelName.Name = "txtHotelName";
            txtHotelName.Padding = new Padding(8, 0, 0, 0);
            txtHotelName.PasswordChar = '\0';
            txtHotelName.PlaceholderForeColor = Color.DimGray;
            txtHotelName.PlaceholderText = "|Nhập tên khách sạn cần tìm...";
            txtHotelName.SelectedText = "";
            txtHotelName.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtHotelName.Size = new Size(259, 32);
            txtHotelName.TabIndex = 48;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(dgvHotel);
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
            // UC_HotelManyReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 236, 236);
            Controls.Add(btnSearch);
            Controls.Add(txtHotelName);
            Controls.Add(guna2ShadowPanel1);
            Margin = new Padding(2);
            Name = "UC_HotelManyReview";
            Size = new Size(1079, 635);
            ((System.ComponentModel.ISupportInitialize)dgvHotel).EndInit();
            guna2ShadowPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        public DataGridView dgvHotel;
        public Guna.UI2.WinForms.Guna2TextBox txtHotelName;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private DataGridViewImageColumn Column1;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
    }
}
