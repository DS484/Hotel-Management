using Hotel_Management.Add_Item;
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

namespace Hotel_Management
{
    public partial class FHome : Form
    {
        CustomerDAO customerDAO = new CustomerDAO();
        private int userId = 0;
        private bool isMenuVisible = true;
        private FMenu ?menuForm;

        public FHome()
        {
            InitializeComponent();
            //btnHistory.Visible = false;
        }
        public FHome(string nameLogged)
        {
            InitializeComponent();
            btnLogin.Visible = false;
            //btnHistory.Visible = true;
            //btnRegisterHotel.Visible = false;
            btnLogged.Text = nameLogged;
            btnLogged.BringToFront();
            userId = customerDAO.FindId(nameLogged);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int imageNumber = 1;
        private void LoadNeztImage()
        {
            if (imageNumber == 5)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private bool isImageVisible = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNeztImage();
            Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            int four = rand.Next(0, 255);
            lblPanel.ForeColor = Color.FromArgb(one, two, three, four);

        }

        bool expand = false;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                cbbDropDownContainer.Height += 15;
                if (cbbDropDownContainer.Height >= cbbDropDownContainer.MaximumSize.Height)
                {
                    timer2.Stop();
                    expand = true;
                }
            }
            else
            {
                cbbDropDownContainer.Height -= 15;
                if (cbbDropDownContainer.Height <= cbbDropDownContainer.MinimumSize.Height)
                {
                    timer2.Stop();
                    expand = false;
                }
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FSignIn fSignIn = new FSignIn();
            fSignIn.ShowDialog();
        }

        private void txtItem_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isImageVisible)
            {
                PicFlashingLogo.Visible = false;
            }
            else
            {
                PicFlashingLogo.Visible = true;
            }
            isImageVisible = !isImageVisible;
        }

        private void btnLogged_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = customerDAO.SearchHotel(txtCity.Text, Convert.ToInt32(nudAdult.Value),
                Convert.ToInt32(nudChildren.Value), Convert.ToInt32(nudRoom.Value),
                Convert.ToDateTime(dtpCheckInDate.Value), Convert.ToDateTime(dtpCheckOutDate.Value));

            List<int> listHotel = new List<int>();
            foreach (DataRow dr in dt.Rows)
            {
                listHotel.Add(Convert.ToInt32(dr[0]));
            }
            try
            {
                this.Hide();
                FFindRoom fFindRoom = new FFindRoom(listHotel, userId, txtCity.Text,
                    Convert.ToInt32(nudAdult.Value), Convert.ToInt32(nudChildren.Value), Convert.ToInt32(nudRoom.Value), Convert.ToDateTime(dtpCheckInDate.Value),
                    Convert.ToDateTime(dtpCheckOutDate.Value));
                fFindRoom.ShowDialog();
                this.Visible = true;
            }
            catch (ObjectDisposedException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void guna2NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void guna2NumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void UpdateTextBox()
        {
            int adults = (int)nudAdult.Value;
            int children = (int)nudChildren.Value;
            int rooms = (int)nudRoom.Value;

            txtItem.Text = string.Format("{0} người lớn, {1} trẻ em, {2} phòng", adults, children, rooms);
        }

        private void FHome_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterHotel_Click(object sender, EventArgs e)
        {

        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text != "Đăng nhập")
            {
                MessageBox.Show("Vui lòng đăng nhập để xem lịch sử!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Hide();
                FHistory fHistory = new FHistory(userId);
                fHistory.ShowDialog();
                this.Visible = true;
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (btnLogged.Text == "")
            {
                MessageBox.Show("Vui lòng đăng nhập để xem lịch sử!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (isMenuVisible)
                {

                    menuForm = new FMenu(userId);
                    menuForm.StartPosition = FormStartPosition.Manual;
                    menuForm.SetLocation(btnMenu.Location.X - 250, btnMenu.Location.Y + 80);
                    menuForm.Show();
                    isMenuVisible = false;
                }
                else
                {
                    menuForm!.Close();
                    isMenuVisible = true;
                }
            }

        }
        private void dtpCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckOutDate.Value <= dtpCheckInDate.Value)
            {
                dtpCheckOutDate.Value = dtpCheckInDate.Value.AddDays(1);
                MessageBox.Show(this, "Ngày trả phòng phải lớn hơn ngày nhận phòng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void slidePic_Click(object sender, EventArgs e)
        {

        }

        private void dtpCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckOutDate.Value <= dtpCheckInDate.Value)
            {
                dtpCheckInDate.Value = dtpCheckOutDate.Value.AddDays(-1);
                MessageBox.Show(this, "Ngày nhận phòng phải nhỏ hơn ngày trả phòng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegisterHotel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FSignUp fSignUp = new FSignUp();
            fSignUp.ShowDialog();
        }
    }
}
