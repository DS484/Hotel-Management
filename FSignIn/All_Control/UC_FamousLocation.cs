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
    public partial class UC_FamousLocation : UserControl
    {
        private AdminDAO adminDAO = new AdminDAO();
        public UC_FamousLocation()
        {
            InitializeComponent();
        }

        public DataTable LoadFamousLocation()
        {
            return adminDAO.GetFamousLocation();
        }

        private void dgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
