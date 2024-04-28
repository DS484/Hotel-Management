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
            foreach (DataRow row in dtBill.Rows)
            {
                if (Convert.ToInt32(row[6]) == 1)
                {
                    voucher = "Có sử dụng mã giảm giá";
                }
                else
                {
                    voucher = "Không sử dụng mã giảm giá";
                }
                dgvBill.Rows.Add(billIcon, row[0], row[1], row[2], row[3], voucher);
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
