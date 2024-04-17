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

namespace Hotel_Management.All_Control
{
    public partial class UC_Bill : UserControl
    {
        private int hotelId;
        private Image billIcon = Properties.Resources.bill;

        ManagerDAO managerDAO = new ManagerDAO();

        public UC_Bill()
        {
            InitializeComponent();
        }

        public void TransmitHotelID(int hotelId)
        {
            this.hotelId = hotelId;
        }

        public void LoadBill()
        {
            dgvBill.DataSource = null;
            dgvBill.Rows.Clear();
            DataTable dtBill = managerDAO.HotelBill(hotelId);
            FillBillData(dtBill);
        }

        public void FillBillData(DataTable dtBill)
        {
            string voucher = "";
            double price;
            foreach (DataRow row in dtBill.Rows)
            {
                double totalDays = (Convert.ToDateTime(row[6]) - Convert.ToDateTime(row[5])).TotalDays;
                if (Convert.ToInt32(row[7]) == 1)
                {
                    voucher = "Có sử dụng mã giảm giá";
                    price = (Convert.ToInt32(row[3]) - 99999) * totalDays;
                }
                else
                {
                    price = Convert.ToInt32(row[3]) * totalDays;
                    voucher = "Không sử dụng mã giảm giá";
                }
                dgvBill.Rows.Add(billIcon, row[0], row[1], row[2], price, row[4], voucher);
            }

            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                row.Height = 50;
            }
        }

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadBill();
            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                if (Convert.ToDateTime(row.Cells[5].Value) < dtpStartDay.Value)
                    row.Visible = false;
            }
        }
    }
}
