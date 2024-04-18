using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using static System.Net.Mime.MediaTypeNames;

namespace Hotel_Management.All_Control
{
    public partial class UC_AvtRoom : UserControl
    {


        public UC_AvtRoom()
        {
            InitializeComponent();

            // Ấn vào bất cứ đâu sẽ ra Form chọn phòng
            picHotel.Click += Even!;
            lblNameHotel.Click += Even!;
            lblAddrHotel.Click += Even!;
            lblStatus.Click += Even!;
            lblVoucher.Click += Even!;
            panelBookRoom.Click += Even!;
            lblSale.Click += Even!;
            lblRealPrice.Click += Even!;
            lblSalePrice.Click += Even!;
            lblInfo.Click += Even!;
            btnbookRoom.Click += Even!;
            pnlHotel.Click += Even!;
        }

        public void FormatRealPrice(string text, float fontSize, FontStyle fontStyle)
        {
            Font font = new Font("Nirmala UI", fontSize, fontStyle);
            lblRealPrice.Text = text;
            lblRealPrice.Font = font;
        }

        public void FormatSalePrice(string text, float fontSize, FontStyle fontStyle, Color fontColor)
        {
            Font font = new Font("Nirmala UI", fontSize, fontStyle);

            lblSalePrice.Text = text;
            lblSalePrice.Font = font;
            lblSalePrice.ForeColor = fontColor;
        }



        private void Even(object sender, EventArgs e)
        {

        }

        private void lblDetail_Click(object sender, EventArgs e)
        {

        }

        private void UC_AvtRoom_Load(object sender, EventArgs e)
        {

        }



        private void picHotel_Click(object sender, EventArgs e)
        {

        }

        private void pnlHotel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNameHotel_Click(object sender, EventArgs e)
        {

        }

        private void btnbookRoom_Click(object sender, EventArgs e)
        {

        }
        private void lblEvaluate_Click(object sender, EventArgs e)
        {

        }
    }
}
