using Hotel_Management.All_Control;
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

namespace Hotel_Management
{
    public partial class FHistory : Form
    {
        CustomerDAO customerDAO = new CustomerDAO();
        FeedBackDAO feedBackDAO = new FeedBackDAO();
        private UC_History uC_History;
        private int usedId;

        public FHistory(int userId)
        {
            InitializeComponent();
            this.usedId = userId;

            UserHistory();
        }

        public void UserHistory()
        {
            DataTable dt = customerDAO.CheckHistory(usedId);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                uC_History = new UC_History();
                flpHistory.Controls.Add(uC_History);

                DataRow row = dt.Rows[i];
                uC_History.lblHotel.Text = row[5].ToString();
                uC_History.lblRoomName.Text = "Phòng: " + row[2].ToString();
                uC_History.dtpCheckInDaten.Value = Convert.ToDateTime(row[3]);
                uC_History.dtpCheckOutDaten.Value = Convert.ToDateTime(row[4]);
                lblUserName.Text = "Xin chào, " + row[7].ToString() + " " + row[6].ToString();
                uC_History.btnEvaluate.Click += (sender, e) =>
                {
                    Evaluate_Click(sender, e, usedId, Convert.ToInt32(row[1]));
                };
            }
        }

        private void Evaluate_Click(object sender, EventArgs e, int userId, int hotelId)
        {
            DataTable dt = feedBackDAO.checkFeedBack(userId, hotelId);
            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show("Bạn đã đánh giá khách sạn này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Hide();
                FFeedBack fFeedBack = new FFeedBack(userId, hotelId);
                fFeedBack.ShowDialog();
                this.Visible = true;
            }
        }

        private void FHistory_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FHome f = new FHome();
            f.Show();
        }
    }
}
