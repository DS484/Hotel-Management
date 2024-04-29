using Hotel_Management.All_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Management.Add_Item;
using Hotel_Management.Properties;
using Hotel_Management.DAO;
using Hotel_Management.DTO;
using System.ComponentModel.Design.Serialization;

namespace Hotel_Management
{

    public partial class FManager : Form
    {
        private int hotelId;
        private string username;

        ManagerDAO managerDAO = new ManagerDAO();
        HotelDAO hotelDAO = new HotelDAO();
        Manager manager = new Manager();
        Hotel hotel = new Hotel();

        public FManager(string username)
        {
            InitializeComponent();
            this.username = username;
            GetInfoManager(username);
            this.hotelId = managerDAO.GetHotelId(username);
            GetInfoHotel();
            lblShowPersonLogin.Text = manager.LastName + " " + manager.FirstName;
            LoadHotelImageHome();
            uC_Room1.btnAddRoom.Click += AddRoom!;
            uC_Service1.btnAddService.Click += AddService!;
            LoadData();
        }

        private void LoadService()
        {
            uC_Service1.TransmitUserName(username);
            uC_Service1.LoadService();
        }

        private void LoadRoom()
        {
            uC_Room1.TransmitUserName(username);
            uC_Room1.LoadRoom();
        }

        private void LoadCustomer()
        {
            uC_Customers1.TransmitHotelID(hotelId);
            uC_Customers1.LoadCustomer();
        }

        private void LoadBill()
        {
            uC_Bill1.TransmitHotelID(hotelId);
            uC_Bill1.LoadBill();
        }

        private void LoadFeedBack()
        {
            uC_Feedback1.TransmitHotelID(hotelId);
            uC_Feedback1.LoadFeedBack();
        }

        private void LoadHotelImageHome()
        {
            string picture = managerDAO.GetImageHotelHome(manager.UserName);
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory)!.Parent!.Parent!.FullName;
            pictureHome.ImageLocation = projectDirectory + @"\" + picture;
        }


        private void LoadData()
        {
            LoadHotelImageHome();
            LoadRoom();
            LoadService();
            LoadCustomer();
            LoadBill();
            LoadFeedBack();
            GetInfoManager(username);
            GetInfoHotel();
        }

        private void GetInfoManager(string username)
        {
            manager.UserName = username;
            DataTable dtManager = managerDAO.GetInfor(username);
            if (dtManager != null)
            {
                foreach (DataRow dr in dtManager.Rows)
                {
                    manager.Id = int.Parse(dr[0].ToString()!);
                    manager.FirstName = dr[2].ToString()!;
                    manager.LastName = dr[3].ToString()!;
                    manager.Gender = int.Parse(dr[4].ToString()!);
                    manager.UserName = dr[5].ToString()!;
                    manager.IdentifyCard = dr[6].ToString()!;
                    manager.PhoneNumber = dr[7].ToString()!;
                }
            }
        }

        private void GetInfoHotel()
        {
            hotel.Id = hotelId;
            DataTable dtHotel = hotelDAO.InfoHotel(hotelId);
            if (dtHotel != null)
            {
                foreach (DataRow row in dtHotel.Rows)
                {
                    hotel.HotelName = row[1].ToString()!;
                    hotel.Address = row[2].ToString()!;
                    hotel.City = row[3].ToString()!;
                    hotel.StarAvg = Convert.ToInt32(row[4]);
                    hotel.Picture = row[5].ToString()!;
                    hotel.Review = row[6].ToString()!;
                    hotel.Voucher = row[7].ToString()!;
                }
            }
        }

        private void btnRoomManager_Click(object sender, EventArgs e)
        {
            panelMoving.Top = btnRoomManager.Top + 1;
            uC_Room1.Visible = true;
            uC_Room1.BringToFront();
        }
        private void btnServiceManager_Click(object sender, EventArgs e)
        {
            panelMoving.Top = btnServiceManager.Top + 1;
            uC_Service1.Visible = true;
            uC_Service1.BringToFront();
        }

        private void btnRevenueManager_Click(object sender, EventArgs e)
        {
            //panelMoving.Top = btnRevenueManager.Top + 1;
            /*control_Revenue1.Visible = true;
            control_Revenue1.BringToFront();*/
        }


        private void FManager_Load(object sender, EventArgs e)
        {
            btnHome.PerformClick();
            uC_Feedback1.Visible = false;
            //control_Revenue1.Visible = false;
            uC_Service1.Visible = false;
            uC_Room1.Visible = false;
            pictureHome.Visible = false;
            uC_Bill1.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelMoving.Top = btnHome.Top + 1;
            pictureHome.Visible = true;
            pictureHome.BringToFront();

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

        private void ResetData(object sender, EventArgs e)
        {

        }

        private void AddRoom(object sender, EventArgs e)
        {
            this.Hide();
            FAddRoom fAddRoom = new FAddRoom(hotelId);
            fAddRoom.ShowDialog();
            this.Visible = true;
        }
        private void AddEmployee(object sender, EventArgs e)
        {
            FAddEmployee f = new FAddEmployee();
            f.Show();
        }
        private void AddService(object sender, EventArgs e)
        {
            FAddService f = new FAddService(hotelId);
            f.Show();
        }
        
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {

        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnFeedBack_Click(object sender, EventArgs e)
        {
            panelMoving.Top = btnFeedBack.Top + 1;
            uC_Feedback1.Visible = true;
            uC_Feedback1.BringToFront();
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSignIn fSignIn = new FSignIn();
            fSignIn.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void lblEditInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSignUp fSignUp = new FSignUp(manager.LastName + " " + manager.FirstName,
                manager.IdentifyCard, manager.PhoneNumber, manager.Gender, manager.UserName,
                manager.Password, manager.Password, hotel.Voucher, hotel.HotelName,
                hotel.Address, hotel.City, hotel.Picture, hotel.Review, manager.Id, hotelId);
            fSignUp.ShowDialog();
            this.Visible = true;

        }

        private void btnExit_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click_2(object sender, EventArgs e)
        {
            this.Close();
            FHome f = new FHome();
            f.Show();
        }
    }
}
