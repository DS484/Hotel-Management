namespace Hotel_Management.All_Control
{
    partial class UC_Feedback
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Feedback));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            txtSearchFeedBack = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            dgvFeedBack = new DataGridView();
            Column12 = new DataGridViewImageColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnSearchFeedBack = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFeedBack).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 10;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 30;
            // 
            // txtSearchFeedBack
            // 
            txtSearchFeedBack.BorderColor = Color.Gray;
            txtSearchFeedBack.BorderRadius = 18;
            txtSearchFeedBack.Cursor = Cursors.Hand;
            txtSearchFeedBack.CustomizableEdges = customizableEdges3;
            txtSearchFeedBack.DefaultText = "";
            txtSearchFeedBack.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchFeedBack.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchFeedBack.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchFeedBack.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchFeedBack.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchFeedBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchFeedBack.ForeColor = Color.DimGray;
            txtSearchFeedBack.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchFeedBack.IconLeft = (Image)resources.GetObject("txtSearchFeedBack.IconLeft");
            txtSearchFeedBack.IconLeftSize = new Size(40, 40);
            txtSearchFeedBack.Location = new Point(14, 20);
            txtSearchFeedBack.Margin = new Padding(6, 7, 6, 7);
            txtSearchFeedBack.Name = "txtSearchFeedBack";
            txtSearchFeedBack.PasswordChar = '\0';
            txtSearchFeedBack.PlaceholderForeColor = Color.DimGray;
            txtSearchFeedBack.PlaceholderText = "|Nhập mã đánh giá cần tìm...";
            txtSearchFeedBack.SelectedText = "";
            txtSearchFeedBack.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSearchFeedBack.Size = new Size(279, 32);
            txtSearchFeedBack.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvFeedBack);
            panel1.Location = new Point(15, 59);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1140, 565);
            panel1.TabIndex = 15;
            // 
            // dgvFeedBack
            // 
            dgvFeedBack.AllowUserToAddRows = false;
            dgvFeedBack.AllowUserToDeleteRows = false;
            dgvFeedBack.AllowUserToResizeColumns = false;
            dgvFeedBack.AllowUserToResizeRows = false;
            dgvFeedBack.Anchor = AnchorStyles.None;
            dgvFeedBack.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFeedBack.BackgroundColor = Color.FromArgb(222, 241, 241);
            dgvFeedBack.BorderStyle = BorderStyle.None;
            dgvFeedBack.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvFeedBack.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(155, 215, 215);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(155, 215, 215);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFeedBack.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFeedBack.ColumnHeadersHeight = 50;
            dgvFeedBack.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvFeedBack.Columns.AddRange(new DataGridViewColumn[] { Column12, Column13, Column14, Column15, Column16, Column17 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 241, 241);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(187, 228, 228);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFeedBack.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFeedBack.EnableHeadersVisualStyles = false;
            dgvFeedBack.GridColor = SystemColors.ControlDark;
            dgvFeedBack.Location = new Point(2, 2);
            dgvFeedBack.Margin = new Padding(2, 2, 2, 2);
            dgvFeedBack.MultiSelect = false;
            dgvFeedBack.Name = "dgvFeedBack";
            dgvFeedBack.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(154, 215, 215);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(154, 215, 215);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvFeedBack.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvFeedBack.RowHeadersVisible = false;
            dgvFeedBack.RowHeadersWidth = 62;
            dgvFeedBack.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvFeedBack.RowTemplate.Height = 33;
            dgvFeedBack.RowTemplate.ReadOnly = true;
            dgvFeedBack.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFeedBack.Size = new Size(1060, 561);
            dgvFeedBack.TabIndex = 37;
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
            Column13.HeaderText = "Mã đánh giá";
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
            Column15.HeaderText = "Số phòng";
            Column15.MinimumWidth = 100;
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            // 
            // Column16
            // 
            Column16.FillWeight = 79.85747F;
            Column16.HeaderText = "Ý kiến đóng góp";
            Column16.MinimumWidth = 400;
            Column16.Name = "Column16";
            Column16.ReadOnly = true;
            // 
            // Column17
            // 
            Column17.FillWeight = 79.85747F;
            Column17.HeaderText = "Số sao";
            Column17.MinimumWidth = 125;
            Column17.Name = "Column17";
            Column17.ReadOnly = true;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 30;
            // 
            // btnSearchFeedBack
            // 
            btnSearchFeedBack.BackColor = Color.FromArgb(222, 241, 241);
            btnSearchFeedBack.BorderRadius = 18;
            btnSearchFeedBack.CustomizableEdges = customizableEdges1;
            btnSearchFeedBack.DisabledState.BorderColor = Color.DarkGray;
            btnSearchFeedBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearchFeedBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearchFeedBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearchFeedBack.FillColor = Color.SeaGreen;
            btnSearchFeedBack.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchFeedBack.ForeColor = Color.White;
            btnSearchFeedBack.Location = new Point(302, 23);
            btnSearchFeedBack.Margin = new Padding(2, 2, 2, 2);
            btnSearchFeedBack.Name = "btnSearchFeedBack";
            btnSearchFeedBack.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSearchFeedBack.Size = new Size(95, 30);
            btnSearchFeedBack.TabIndex = 35;
            btnSearchFeedBack.Text = "Tìm kiếm";
            btnSearchFeedBack.Click += btnSearchFeedBack_Click;
            // 
            // UC_Feedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 241, 241);
            Controls.Add(btnSearchFeedBack);
            Controls.Add(txtSearchFeedBack);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_Feedback";
            Size = new Size(1079, 635);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFeedBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public Guna.UI2.WinForms.Guna2TextBox txtSearchFeedBack;
        public Panel panel1;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Button btnSearchFeedBack;
        public DataGridView dgvFeedBack;
        private DataGridViewImageColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
    }
}
