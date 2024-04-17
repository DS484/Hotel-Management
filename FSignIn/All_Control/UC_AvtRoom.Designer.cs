namespace Hotel_Management.All_Control
{
    partial class UC_AvtRoom
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AvtRoom));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlHotel = new Guna.UI2.WinForms.Guna2Panel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            lblStar = new Label();
            lblDetail = new Label();
            lblNameHotel = new Label();
            picHotel = new PictureBox();
            lblVoucher = new Label();
            lblStatus = new Label();
            lblAddrHotel = new Label();
            panelBookRoom = new Guna.UI2.WinForms.Guna2Panel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnbookRoom = new Guna.UI2.WinForms.Guna2Button();
            lblSalePrice = new Label();
            lblRealPrice = new Label();
            lblSale = new Label();
            lblInfo = new Label();
            pnlHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHotel).BeginInit();
            panelBookRoom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHotel
            // 
            pnlHotel.BorderColor = Color.Black;
            pnlHotel.BorderRadius = 10;
            pnlHotel.BorderThickness = 2;
            pnlHotel.Controls.Add(guna2PictureBox1);
            pnlHotel.Controls.Add(lblStar);
            pnlHotel.Controls.Add(lblDetail);
            pnlHotel.Controls.Add(lblNameHotel);
            pnlHotel.Controls.Add(picHotel);
            pnlHotel.Controls.Add(lblVoucher);
            pnlHotel.Controls.Add(lblStatus);
            pnlHotel.Controls.Add(lblAddrHotel);
            pnlHotel.Cursor = Cursors.Hand;
            pnlHotel.CustomizableEdges = customizableEdges3;
            pnlHotel.Location = new Point(4, 4);
            pnlHotel.Margin = new Padding(4);
            pnlHotel.Name = "pnlHotel";
            pnlHotel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnlHotel.Size = new Size(975, 305);
            pnlHotel.TabIndex = 0;
            pnlHotel.Paint += pnlHotel_Paint;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.FillColor = SystemColors.MenuHighlight;
            guna2PictureBox1.Image = Properties.Resources.star;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(901, 33);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(42, 43);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 22;
            guna2PictureBox1.TabStop = false;
            // 
            // lblStar
            // 
            lblStar.AutoSize = true;
            lblStar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblStar.ForeColor = Color.Gold;
            lblStar.Location = new Point(869, 33);
            lblStar.Name = "lblStar";
            lblStar.Size = new Size(33, 38);
            lblStar.TabIndex = 21;
            lblStar.Text = "5";
            // 
            // lblDetail
            // 
            lblDetail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblDetail.ForeColor = Color.DarkBlue;
            lblDetail.Location = new Point(869, 265);
            lblDetail.Margin = new Padding(4, 0, 4, 0);
            lblDetail.Name = "lblDetail";
            lblDetail.Size = new Size(88, 31);
            lblDetail.TabIndex = 20;
            lblDetail.Text = "Chi tiết";
            lblDetail.Click += lblDetail_Click;
            // 
            // lblNameHotel
            // 
            lblNameHotel.BackColor = Color.Transparent;
            lblNameHotel.Cursor = Cursors.Hand;
            lblNameHotel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameHotel.ForeColor = Color.Black;
            lblNameHotel.ImageAlign = ContentAlignment.MiddleLeft;
            lblNameHotel.Location = new Point(369, 0);
            lblNameHotel.Margin = new Padding(4, 0, 4, 0);
            lblNameHotel.Name = "lblNameHotel";
            lblNameHotel.Size = new Size(606, 108);
            lblNameHotel.TabIndex = 19;
            lblNameHotel.Text = "Hotel Nikko Saigon";
            lblNameHotel.TextAlign = ContentAlignment.MiddleLeft;
            lblNameHotel.Click += lblNameHotel_Click;
            // 
            // picHotel
            // 
            picHotel.BackColor = Color.Transparent;
            picHotel.Cursor = Cursors.Hand;
            picHotel.Image = (Image)resources.GetObject("picHotel.Image");
            picHotel.Location = new Point(4, 4);
            picHotel.Margin = new Padding(4);
            picHotel.Name = "picHotel";
            picHotel.Size = new Size(361, 298);
            picHotel.SizeMode = PictureBoxSizeMode.StretchImage;
            picHotel.TabIndex = 18;
            picHotel.TabStop = false;
            picHotel.Click += picHotel_Click;
            // 
            // lblVoucher
            // 
            lblVoucher.BackColor = Color.Transparent;
            lblVoucher.Cursor = Cursors.Hand;
            lblVoucher.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblVoucher.ForeColor = Color.FromArgb(255, 128, 128);
            lblVoucher.Image = (Image)resources.GetObject("lblVoucher.Image");
            lblVoucher.ImageAlign = ContentAlignment.MiddleLeft;
            lblVoucher.Location = new Point(367, 196);
            lblVoucher.Margin = new Padding(4, 0, 4, 0);
            lblVoucher.Name = "lblVoucher";
            lblVoucher.Size = new Size(606, 55);
            lblVoucher.TabIndex = 17;
            lblVoucher.Text = "      Áp dụng phiếu giảm giá để nhận được mức giá tốt";
            lblVoucher.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Cursor = Cursors.Hand;
            lblStatus.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.FromArgb(255, 128, 128);
            lblStatus.Image = (Image)resources.GetObject("lblStatus.Image");
            lblStatus.ImageAlign = ContentAlignment.MiddleLeft;
            lblStatus.Location = new Point(367, 144);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(604, 52);
            lblStatus.TabIndex = 16;
            lblStatus.Text = "      Đang bán chạy! Mới được đặt cách đây 3 tiếng";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAddrHotel
            // 
            lblAddrHotel.BackColor = Color.Transparent;
            lblAddrHotel.Cursor = Cursors.Hand;
            lblAddrHotel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddrHotel.Image = (Image)resources.GetObject("lblAddrHotel.Image");
            lblAddrHotel.ImageAlign = ContentAlignment.MiddleLeft;
            lblAddrHotel.Location = new Point(367, 94);
            lblAddrHotel.Margin = new Padding(4, 0, 4, 0);
            lblAddrHotel.Name = "lblAddrHotel";
            lblAddrHotel.Size = new Size(604, 50);
            lblAddrHotel.TabIndex = 15;
            lblAddrHotel.Text = "    235 Nguyễn Văn Cừ, Quận 1 , Quận 1, Hồ Chí Minh";
            lblAddrHotel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelBookRoom
            // 
            panelBookRoom.BorderColor = Color.Black;
            panelBookRoom.BorderRadius = 10;
            panelBookRoom.BorderThickness = 2;
            panelBookRoom.Controls.Add(guna2HtmlLabel1);
            panelBookRoom.Controls.Add(btnbookRoom);
            panelBookRoom.Controls.Add(lblSalePrice);
            panelBookRoom.Controls.Add(lblRealPrice);
            panelBookRoom.Controls.Add(lblSale);
            panelBookRoom.Controls.Add(lblInfo);
            panelBookRoom.Cursor = Cursors.Hand;
            panelBookRoom.CustomizableEdges = customizableEdges7;
            panelBookRoom.Location = new Point(980, 4);
            panelBookRoom.Margin = new Padding(4);
            panelBookRoom.Name = "panelBookRoom";
            panelBookRoom.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panelBookRoom.Size = new Size(395, 305);
            panelBookRoom.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(255, 128, 0);
            guna2HtmlLabel1.Location = new Point(6, 135);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(116, 34);
            guna2HtmlLabel1.TabIndex = 5;
            guna2HtmlLabel1.Text = "Giá chỉ từ:";
            // 
            // btnbookRoom
            // 
            btnbookRoom.BackColor = Color.White;
            btnbookRoom.BorderRadius = 10;
            btnbookRoom.BorderThickness = 2;
            btnbookRoom.Cursor = Cursors.Hand;
            btnbookRoom.CustomizableEdges = customizableEdges5;
            btnbookRoom.DisabledState.BorderColor = Color.DarkGray;
            btnbookRoom.DisabledState.CustomBorderColor = Color.DarkGray;
            btnbookRoom.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnbookRoom.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnbookRoom.FillColor = Color.FromArgb(255, 128, 0);
            btnbookRoom.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnbookRoom.ForeColor = Color.White;
            btnbookRoom.Location = new Point(161, 224);
            btnbookRoom.Margin = new Padding(4);
            btnbookRoom.Name = "btnbookRoom";
            btnbookRoom.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnbookRoom.Size = new Size(215, 55);
            btnbookRoom.TabIndex = 4;
            btnbookRoom.Text = "Chọn phòng";
            btnbookRoom.Click += btnbookRoom_Click;
            // 
            // lblSalePrice
            // 
            lblSalePrice.Cursor = Cursors.Hand;
            lblSalePrice.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSalePrice.ForeColor = Color.FromArgb(255, 128, 0);
            lblSalePrice.ImageAlign = ContentAlignment.MiddleLeft;
            lblSalePrice.Location = new Point(12, 118);
            lblSalePrice.Margin = new Padding(4, 0, 4, 0);
            lblSalePrice.Name = "lblSalePrice";
            lblSalePrice.Padding = new Padding(0, 0, 6, 0);
            lblSalePrice.Size = new Size(372, 62);
            lblSalePrice.TabIndex = 2;
            lblSalePrice.Text = "975.000 VND";
            lblSalePrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRealPrice
            // 
            lblRealPrice.Cursor = Cursors.Hand;
            lblRealPrice.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold | FontStyle.Strikeout, GraphicsUnit.Point);
            lblRealPrice.ForeColor = Color.Black;
            lblRealPrice.ImageAlign = ContentAlignment.MiddleLeft;
            lblRealPrice.Location = new Point(6, 78);
            lblRealPrice.Margin = new Padding(4, 0, 4, 0);
            lblRealPrice.Name = "lblRealPrice";
            lblRealPrice.Padding = new Padding(0, 0, 6, 0);
            lblRealPrice.Size = new Size(372, 40);
            lblRealPrice.TabIndex = 1;
            lblRealPrice.Text = "2.475.000 VND";
            lblRealPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSale
            // 
            lblSale.Cursor = Cursors.Hand;
            lblSale.ForeColor = Color.Green;
            lblSale.Image = (Image)resources.GetObject("lblSale.Image");
            lblSale.ImageAlign = ContentAlignment.MiddleLeft;
            lblSale.Location = new Point(6, 11);
            lblSale.Margin = new Padding(4, 0, 4, 0);
            lblSale.Name = "lblSale";
            lblSale.Padding = new Padding(25, 0, 6, 0);
            lblSale.Size = new Size(370, 66);
            lblSale.TabIndex = 0;
            lblSale.Text = "Ưu đãi chỉ dành cho riêng bạn!";
            lblSale.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblInfo
            // 
            lblInfo.Cursor = Cursors.Hand;
            lblInfo.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.ForeColor = Color.Black;
            lblInfo.ImageAlign = ContentAlignment.MiddleLeft;
            lblInfo.Location = new Point(4, 170);
            lblInfo.Margin = new Padding(4, 0, 4, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Padding = new Padding(0, 0, 6, 0);
            lblInfo.Size = new Size(372, 40);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "phòng/đêm";
            lblInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UC_AvtRoom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelBookRoom);
            Controls.Add(pnlHotel);
            ForeColor = SystemColors.ActiveCaption;
            Margin = new Padding(4);
            Name = "UC_AvtRoom";
            Size = new Size(1379, 312);
            Load += UC_AvtRoom_Load;
            pnlHotel.ResumeLayout(false);
            pnlHotel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHotel).EndInit();
            panelBookRoom.ResumeLayout(false);
            panelBookRoom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHotel;
        public PictureBox picHotel;
        public Label lblVoucher;
        public Label lblStatus;
        public Label lblAddrHotel;
        public Label lblNameHotel;
        public Guna.UI2.WinForms.Guna2Panel panelBookRoom;
        public Label lblSale;
        public Label lblInfo;
        public Label lblSalePrice;
        public Label lblRealPrice;
        public Guna.UI2.WinForms.Guna2Button btnbookRoom;
        public Label lblDetail;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public Label lblStar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
