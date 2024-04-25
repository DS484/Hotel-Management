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
    public partial class UC_VIPCustomer : UserControl
    {
        private AdminDAO adminDAO = new AdminDAO();

        public UC_VIPCustomer()
        {
            InitializeComponent();
        }

        public void LoadVIPCustomer()
        {
            dgvVIPCustomer.DataSource = null;
            dgvVIPCustomer.Rows.Clear();
            DataTable dtService = adminDAO.VIPCustomer();
            FillServiceData(dtService);
        }

        public void FillServiceData(DataTable dtService)
        {
            foreach (DataRow row in dtService.Rows)
            {
                dgvVIPCustomer.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
            }

            foreach (DataGridViewRow row in dgvVIPCustomer.Rows)
            {
                row.Height = 50;
            }
        }
    }
}
