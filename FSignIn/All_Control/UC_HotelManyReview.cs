using Hotel_Management.DAO;
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
    public partial class UC_HotelManyReview : UserControl
    {
        private AdminDAO adminDAO = new AdminDAO();

        public UC_HotelManyReview()
        {
            InitializeComponent();
        }

        public void LoadHotelManyReview()
        {
            dgvHotel.DataSource = null;
            dgvHotel.Rows.Clear();
            DataTable dtService = adminDAO.HotelRevenue();
            FillServiceData(dtService);
        }

        public void FillServiceData(DataTable dtService)
        {
            foreach (DataRow row in dtService.Rows)
            {
                dgvHotel.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
            }

            foreach (DataGridViewRow row in dgvHotel.Rows)
            {
                row.Height = 50;
            }
        }

    }
}
