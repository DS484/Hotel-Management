using Guna.UI2.WinForms;
using Hotel_Management.All_Control;
using Hotel_Management.DAO;
using Hotel_Management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel_Management
{
    public partial class FFindRoom : Form
    {
        HotelDAO hotelDAO = new HotelDAO();
        CustomerDAO customerDAO = new CustomerDAO();
        RoomDAO roomDAO = new RoomDAO();
        BookingDAO bookingDAO = new BookingDAO();

        private List<int> hotelList = new List<int>();
        private int userId;
        private string? city;
        private int adult;
        private int child;
        private int quantityRoom;
        private DateTime checkInDate;
        private DateTime checkOutDate;


        public FFindRoom(List<int> hotelList, int userId, string city,
            int adult, int child, int quantityRoom, DateTime checkInDate, DateTime checkOutDate)
        {
            this.hotelList = hotelList;
            this.userId = userId;
            this.city = city;
            this.adult = adult;
            this.child = child;
            this.quantityRoom = quantityRoom;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;

            InitializeComponent();
            DataSearch();
            FillDataHotel(hotelList.Distinct().ToList());
        }

        public FFindRoom()
        {
            InitializeComponent();
        }

        public void DataSearch()
        {
            txtCity.Text = city;
            nudAdult.Value = adult;
            nudChild.Value = child;
            nudRoom.Value = quantityRoom;
            dtpCheckInDate.Value = checkInDate;
            dtpCheckOutDate.Value = checkOutDate;
        }

        public void FillDataHotel(List<int> hotelList)
        {
            bool checkRoomAvailable = false;
            for (int i = 0; i < hotelList.Count; i++)
            {
                DataTable dtDetailHotel = hotelDAO.FindHotel(hotelList[i]);
                DataTable dtRooms = customerDAO.SearchHotel(txtCity.Text, Convert.ToInt32(nudAdult.Value), Convert.ToInt32(nudChild.Value), Convert.ToInt32(nudRoom.Value),
                    dtpCheckInDate.Value, dtpCheckOutDate.Value);
                List<int> roomList = new List<int>();
                if (dtRooms != null && dtRooms.Rows.Count > 0)
                {
                    foreach (DataRow row in dtRooms.Rows)
                    {
                        if (Convert.ToInt32(row[0]) == hotelList[i])
                        {
                            roomList.Add(Convert.ToInt32(row[1]));
                            checkRoomAvailable = true;
                        }
                    }
                }
                if (checkRoomAvailable)
                {
                    LoadInfo(dtDetailHotel, hotelList[i], roomList);
                }
                checkRoomAvailable = false;
            }
        }

        public bool CheckRoom(int roomId)
        {
            bool middle = false;
            bool added = false;
            DataTable dtBooking = bookingDAO.CheckBooking(roomId);

            if (dtBooking != null && dtBooking.Rows.Count > 0)
            {
                if (dtBooking.Rows.Count == 1)
                {
                    if (dtpCheckOutDate.Value < Convert.ToDateTime(dtBooking.Rows[0][1]))
                        added = true;
                    if (dtpCheckInDate.Value > Convert.ToDateTime(dtBooking.Rows[0][2]))
                        added = true;
                }
                else
                {
                    //1 la checkin, 2 la checkout
                    for (int i = 0; i < dtBooking.Rows.Count; i++)
                    {
                        DataRow rowBehind;
                        DataRow rowCurr = dtBooking.Rows[i];
                        if (i != dtBooking.Rows.Count - 1)
                        {
                            rowBehind = dtBooking.Rows[i + 1];
                            if (dtpCheckInDate.Value > Convert.ToDateTime(rowCurr[2]) && dtpCheckOutDate.Value < Convert.ToDateTime(rowBehind[1]))
                                middle = true;
                        }
                        if (dtpCheckInDate.Value > Convert.ToDateTime(dtBooking.Rows[dtBooking.Rows.Count - 1][2]))
                            added = true;
                        if (dtpCheckOutDate.Value < Convert.ToDateTime(dtBooking.Rows[0][1]))
                            added = true;
                    }

                }
            }
            else
                added = true;

            if (middle || added)
                return true;
            return false;
        }

        public void LoadInfo(DataTable dtDetailHotel, int hotelId, List<int> roomList)
        {
            //Nhap
            List<int> tmpRoomList = new List<int>(roomList);
            for (int i = 0; i < tmpRoomList.Count; i++)
            {
                bool checkRoom = CheckRoom(tmpRoomList[i]);
                if (!checkRoom)
                    roomList.Remove(tmpRoomList[i]);
            }
            if (roomList.Count == 0)
                return;
            //Het nhap
            int prePrice = int.MaxValue;
            int currPrice = int.MaxValue;
            UC_AvtRoom uC_AvtRoom = new UC_AvtRoom();
            flpLoadingHotel.Controls.Add(uC_AvtRoom);
            bool check = false;
            for (int i = 0; i < dtDetailHotel.Rows.Count; i++)
            {
                DataRow row = dtDetailHotel.Rows[i];

                uC_AvtRoom.lblNameHotel.Text = row[0].ToString();
                uC_AvtRoom.lblAddrHotel.Text = ("     " + row[1].ToString() + ", " + row[2].ToString()).ToString();
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory)!.Parent!.Parent!.FullName;
                string imagePath = projectDirectory + @"\" + row[3].ToString();

                if (!string.IsNullOrEmpty(imagePath))
                {
                    uC_AvtRoom.picHotel.ImageLocation = imagePath;
                }
                else
                {
                    uC_AvtRoom.picHotel.Image = null;
                }
                if (Convert.ToInt32(row[5]) < prePrice && roomList.Contains(Convert.ToInt32(row[7])))
                    prePrice = Convert.ToInt32(row[5]);
                if (Convert.ToInt32(row[6]) < currPrice && roomList.Contains(Convert.ToInt32(row[7])))
                    currPrice = Convert.ToInt32(row[6]);
                uC_AvtRoom.lblStar.Text = row[8].ToString();

                if (!check)
                {
                    uC_AvtRoom.lblDetail.Click += (sender, e) =>
                    {
                        Detail_Click(sender!, e, int.Parse(row[7].ToString()!), hotelId);
                    };

                    check = true;
                }
            }

            uC_AvtRoom.FormatRealPrice(prePrice.ToString() + " VND", 13.8f, FontStyle.Bold | FontStyle.Strikeout);
            uC_AvtRoom.FormatSalePrice(currPrice.ToString() + " VND", 18f, FontStyle.Bold, Color.FromArgb(255, 128, 0));

            uC_AvtRoom.btnbookRoom.Click += (sender, e) =>
            {
                BookRoom_Click(sender!, e, hotelId, roomList);
            };

        }

        private void BookRoom_Click(object sender, EventArgs e, int hotelId, List<int> roomList)
        {
            this.Hide();
            FSelectRoom fSelectRoom = new FSelectRoom(roomList, hotelId, userId, checkInDate, checkOutDate);
            fSelectRoom.ShowDialog();
            this.Visible = true;
        }

        private void Detail_Click(object sender, EventArgs e, int roomId, int hotelId)
        {
            this.Hide();
            FDetailHotel fDetailHotel = new FDetailHotel(roomId, hotelId);
            fDetailHotel.ShowDialog();
            this.Visible = true;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        bool expand = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                cbbDropDownContainer.Height += 15;
                if (cbbDropDownContainer.Height >= cbbDropDownContainer.MaximumSize.Height)
                {
                    timer1.Stop();
                    expand = true;
                }
            }
            else
            {
                cbbDropDownContainer.Height -= 15;
                if (cbbDropDownContainer.Height <= cbbDropDownContainer.MinimumSize.Height)
                {
                    timer1.Stop();
                    expand = false;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeRangeSlider()
        {
            trackBarMin.Minimum = 0;
            trackBarMin.Maximum = 9999999;
            trackBarMin.Value = 0;
            trackBarMax.Minimum = 1;
            trackBarMax.Maximum = 10000000;
            trackBarMax.Value = 3000000;

            trackBarMin.Scroll += TrackBarMin_Scroll!;
            trackBarMax.Scroll += TrackBarMax_Scroll!;

            UpdateLabelValues();
        }

        private void UpdateLabelValues()
        {
            lblMin.Text = FormatCurrency(trackBarMin.Value);
            lblMax.Text = FormatCurrency(trackBarMax.Value);
        }

        private string FormatCurrency(int value)
        {
            return (value).ToString("N0") + " VND";
        }
        private void TrackBarMin_Scroll(object sender, ScrollEventArgs e)
        {
            if (trackBarMin.Value >= trackBarMax.Value)
            {
                trackBarMin.Value = trackBarMax.Value - 1;
            }
            UpdateLabelValues();
        }

        private void TrackBarMax_Scroll(object sender, ScrollEventArgs e)
        {
            if (trackBarMax.Value <= trackBarMin.Value)
            {
                trackBarMax.Value = trackBarMin.Value + 1;
            }

            UpdateLabelValues();
        }

        private void FFindRoom_Load(object sender, EventArgs e)
        {
            InitializeRangeSlider();
        }

        private void txtItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2Separator4_Click(object sender, EventArgs e)
        {

        }

        private void nudChild_ValueChanged(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void nudAdult_ValueChanged(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void nudRoom_ValueChanged(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void UpdateTextBox()
        {
            int adults = (int)nudAdult.Value;
            int children = (int)nudChild.Value;
            int rooms = (int)nudRoom.Value;

            txtItem.Text = string.Format("{0} người lớn, {1} trẻ em, {2} phòng", adults, children, rooms);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Control> controlsToRemove = new List<Control>();

            foreach (Control control in flpLoadingHotel.Controls)
            {
                if (control is UC_AvtRoom)
                {
                    controlsToRemove.Add(control);
                }
            }

            foreach (Control control in controlsToRemove)
            {
                flpLoadingHotel.Controls.Remove(control);
            }

            List<int> newListHotel = new List<int>();
            DataTable dt = customerDAO.SearchHotel(txtCity.Text, Convert.ToInt32(nudAdult.Value), Convert.ToInt32(nudChild.Value), Convert.ToInt32(nudRoom.Value), dtpCheckInDate.Value, dtpCheckOutDate.Value);
            foreach (DataRow dr in dt.Rows)
            {
                newListHotel.Add(Convert.ToInt32(dr[0]));
            }
            FillDataHotel(newListHotel.Distinct().ToList());
        }

        private void flpLoadingHotel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dtpCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckOutDate.Value <= dtpCheckInDate.Value)
            {
                dtpCheckOutDate.Value = dtpCheckInDate.Value.AddDays(1);
                MessageBox.Show(this, "Ngày trả phòng phải lớn hơn ngày nhận phòng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckOutDate.Value <= dtpCheckInDate.Value)
            {
                dtpCheckInDate.Value = dtpCheckOutDate.Value.AddDays(-1);
                MessageBox.Show(this, "Ngày nhận phòng phải nhỏ hơn ngày trả phòng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rsStart_ValueChanged(object sender, EventArgs e)
        {


        }

        private void rsStar_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
            List<UC_AvtRoom> controlsToRemove = new List<UC_AvtRoom>();
            int star = (int)rsStar.Value;

            foreach (Control control in flpLoadingHotel.Controls)
            {
                if (control is UC_AvtRoom avtRoomControl)
                {
                    if (Convert.ToInt32(avtRoomControl.lblStar.Text) != star)
                    {
                        controlsToRemove.Add(avtRoomControl);
                    }
                }
            }

            foreach (UC_AvtRoom controlToRemove in controlsToRemove)
            {
                flpLoadingHotel.Controls.Remove(controlToRemove);
                controlToRemove.Dispose();
            }
        }

        private void SearchWithPrice(object sender, ScrollEventArgs e)
        {
            int minValue = trackBarMin.Value;
            int maxValue = trackBarMax.Value;
            btnSearch_Click(sender, e);
            List<UC_AvtRoom> controlsToRemove = new List<UC_AvtRoom>();
            foreach (Control control in flpLoadingHotel.Controls)
            {
                if (control is UC_AvtRoom avtRoomControl)
                {
                    if (Convert.ToInt32(avtRoomControl.lblSalePrice.Text.Replace(" VND", "")) < minValue ||
                        Convert.ToInt32(avtRoomControl.lblSalePrice.Text.Replace(" VND", "")) > maxValue)
                    {
                        controlsToRemove.Add(avtRoomControl);
                    }
                }
            }

            foreach (UC_AvtRoom controlToRemove in controlsToRemove)
            {
                flpLoadingHotel.Controls.Remove(controlToRemove);
                controlToRemove.Dispose();
            }
        }

        private void trackBarMax_Scroll_1(object sender, ScrollEventArgs e)
        {
            SearchWithPrice(sender, e);
        }

        private void trackBarMin_Scroll_1(object sender, ScrollEventArgs e)
        {
            SearchWithPrice(sender, e);
        }
    }
}
