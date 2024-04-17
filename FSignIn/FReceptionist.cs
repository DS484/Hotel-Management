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
    public partial class FReceptionist : Form
    {
        public FReceptionist()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelMoving.Top = btnHome.Top + 1;
            pictureHome.Visible = true;
            pictureHome.BringToFront();
        }

        private void btnRoomManager_Click_1(object sender, EventArgs e)
        {
            panelMoving.Top = btnRoomManager.Top + 1;
            uC_Room1.Visible = true;
            uC_Room1.BringToFront();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            panelMoving.Top = btnBill.Top + 1;
            uC_Bill1.Visible = true;
            uC_Bill1.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            panelMoving.Top = btnCustomer.Top + 1;
            uC_Customers1.Visible = true;
            uC_Customers1.BringToFront();
        }

        private void btnLogOut_Click_2(object sender, EventArgs e)
        {
            this.Close();
            FSignIn f = new FSignIn();
            f.Show();
        }

        private void btnExit_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSignIn fSignIn = new FSignIn();
            fSignIn.ShowDialog();
            this.Visible = true;
        }
    }
}
