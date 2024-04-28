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
    public partial class UC_HotelRevenue : UserControl
    {
        private AdminDAO adminDAO = new AdminDAO();
        public UC_HotelRevenue()
        {
            InitializeComponent();
        }

        public DataTable LoadHotelRevenue()
        {
            return adminDAO.GetHotelRevenue();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {

        }
    }
}
