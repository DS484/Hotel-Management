﻿using Hotel_Management.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel_Management.All_Control
{
    public partial class UC_TopCustomer : UserControl
    {
        AdminDAO adminDAO = new AdminDAO();

        public UC_TopCustomer()
        {
            InitializeComponent();
        }

        public void LoadTopCustomer()
        {
            dgvCustomer.DataSource = null;
            dgvCustomer.Rows.Clear();
            DataTable dtService = adminDAO.TopCustomer();
            FillServiceData(dtService);
        }

        public void FillServiceData(DataTable dtService)
        {
            foreach (DataRow row in dtService.Rows)
            {
                dgvCustomer.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
            }

            foreach (DataGridViewRow row in dgvCustomer.Rows)
            {
                row.Height = 50;
            }
        }
    }
}
