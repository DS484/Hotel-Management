﻿using Hotel_Management.Add_Item;
using Hotel_Management.All_Control;
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
    public partial class FAdmin : Form
    {
        public FAdmin(string usernames)
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            uC_HotelRevenue1.btnChart.Click += DrawChart!;
            LoadFamousLocation();
            LoadTopCustomer();
            LoadVIPCustomer();
            LoadHotelManyReview();
            LoadHotelRevenue();
        }

        private void LoadFamousLocation()
        {
            DataTable dt = uC_FamousLocation1.LoadFamousLocation();
            uC_FamousLocation1.dgvRoom.DataSource = dt;
        }

        private void DrawChart(object sender, EventArgs e)
        {
            this.Hide();
            FStatistical fStatistical = new FStatistical(uC_HotelRevenue1.dgvRoom);
            fStatistical.ShowDialog();
            this.Visible = true;
        }

        private void LoadTopCustomer()
        {
            uC_TopCustomer1.LoadTopCustomer();
        }

        private void LoadVIPCustomer()
        {
            uC_vipCustomer1.LoadVIPCustomer();
        }

        private void LoadHotelManyReview()
        {
            uC_HotelManyReview1.LoadHotelManyReview();
        }

        private void LoadHotelRevenue()
        {
            DataTable hotelRevenue = uC_HotelRevenue1.LoadHotelRevenue();
            uC_HotelRevenue1.dgvRoom.DataSource = hotelRevenue;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFamouslocation_Click(object sender, EventArgs e)
        {
            panelMoving.Top = btnFamouslocation.Top + 1;
            uC_FamousLocation1.Visible = true;
            uC_FamousLocation1.BringToFront();
        }

        private void btnTopCustomer_Click(object sender, EventArgs e)
        {
            panelMoving.Top = btnTopCustomer.Top + 1;
            uC_TopCustomer1.Visible = true;
            uC_TopCustomer1.BringToFront();
        }

        private void btnVIPCustomer_Click(object sender, EventArgs e)
        {
            panelMoving.Top = btnVIPCustomer.Top + 1;
            uC_vipCustomer1.Visible = true;
            uC_vipCustomer1.BringToFront();
        }

        private void btnHotelManyReview_Click(object sender, EventArgs e)
        {
            panelMoving.Top = btnHotelManyReview.Top + 1;
            uC_HotelManyReview1.Visible = true;
            uC_HotelManyReview1.BringToFront();
        }

        private void btnHotelRevenue_Click(object sender, EventArgs e)
        {
            panelMoving.Top = btnHotelRevenue.Top + 1;
            uC_HotelRevenue1.Visible = true;
            uC_HotelRevenue1.BringToFront();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            FHome f = new FHome();
            f.Show();
        }
    }
}
