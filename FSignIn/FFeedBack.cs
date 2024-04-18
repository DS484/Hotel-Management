using Hotel_Management.DAO;
using Hotel_Management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class FFeedBack : Form
    {
        HotelDAO hotelDAO = new HotelDAO();
        CustomerDAO customerDAO = new CustomerDAO();
        FeedBackDAO feedBackDAO = new FeedBackDAO();
        private int userId;
        private int hotelId;

        public FFeedBack(int userId, int hotelId)
        {
            InitializeComponent();
            this.userId = userId;
            this.hotelId = hotelId;
            FillInfo();

        }

        public void FillInfo()
        {
            DataTable dtHotel = hotelDAO.InfoHotel(hotelId);
            DataTable dtCustomer = customerDAO.UserInfomation(userId);

            for (int i = 0; i < dtHotel.Rows.Count; i++)
            {
                DataRow row = dtHotel.Rows[i];
                lblHotel.Text = row[1].ToString();
            }

            for (int i = 0; i < dtCustomer.Rows.Count; i++)
            {
                DataRow row = dtCustomer.Rows[i];
                lblHi.Text = "Xin chào, " + row[3].ToString() + " " + row[2].ToString();
            }
        }

        private void FFeedBack_Load(object sender, EventArgs e)
        {

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            bool check = feedBackDAO.InsertFeecBack(Convert.ToInt32(rsStar.Value), txtFeedBack.Text, userId, hotelId);
            if (check)
            {
                MessageBox.Show("Đánh giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi, không thể thêm dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExitt_Click(object sender, EventArgs e)
        {

        }
    }
}
