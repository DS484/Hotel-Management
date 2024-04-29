using Guna.Charts.WinForms;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using Point = System.Drawing.Point;

using System;
using System.Linq;
using System.Windows;

namespace Hotel_Management
{
    public partial class FStatistical : Form
    {
        private string selected = "";
        private DataGridView dgv;

        public FStatistical(DataGridView dgv)
        {
            InitializeComponent();
            this.dgv = dgv;
        }

        private void DoughnutChart()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Value", typeof(int));

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    dataTable.Rows.Add(row.Cells[0].Value.ToString(),
                                       Convert.ToInt32(row.Cells[1].Value));
                }
            }

            var dataset = new GunaDoughnutDataset();

            int total = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                total += Convert.ToInt32(row["Value"]);
            }

            foreach (DataRow row in dataTable.Rows)
            {
                int value = Convert.ToInt32(row["Value"]);
                double percentage = ((double)value / total) * 100;
                string label = $"{row["Name"].ToString()} ({percentage.ToString("0.00")}%)";
                dataset.DataPoints.Add(label, value);
            }

            chartInfo.Datasets.Add(dataset);

            chartInfo.Update();
        }

        public void HorizontalBarChart()
        {
            List<string> hotelName = new List<string>();
            List<int> totalRevenue = new List<int>();

            int total = totalRevenue.Sum();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    hotelName.Add(row.Cells[0].Value.ToString()!);
                    totalRevenue.Add(Convert.ToInt32(row.Cells[1].Value!));
                }
            }

            var dataset = new Guna.Charts.WinForms.GunaHorizontalBarDataset();
            for (int i = 0; i < hotelName.Count; i++)
            {
                dataset.DataPoints.Add(hotelName[i], totalRevenue[i]);
            }

            chartInfo.Datasets.Add(dataset);

            chartInfo.Update();

        }

        private void FStatistical_Load(object sender, EventArgs e)
        {
            string[] typeChart = { "Cột", "Tròn" };
            panel1.BackColor = Color.FromArgb(20, 0, 0, 0);


            for (int i = typeChart.Length - 1; i >= 0; i--)
            {
                var button = new System.Windows.Forms.Button()
                {
                    BackColor = Color.Empty,
                    Text = typeChart[i],
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Top,
                    Height = 25,
                    FlatStyle = FlatStyle.Flat,
                    Padding = new Padding(10, 0, 0, 0),
                    FlatAppearance =
                    {
                         BorderSize = 0,
                         MouseOverBackColor = Color.DodgerBlue
                    }
                };
                button.Click += (s, evnt) =>
                {
                    selected = button.Text;
                    SelectBasicExamples(selected);
                    panel2.Size = new Size(5, button.Height);
                    panel2.Location = new Point(panel1.Width - 5, button.Top);
                    panel2.BringToFront();
                };
                panel1.Controls.Add(button);
            }
        }

        private void SelectBasicExamples(string name)
        {
            chartInfo.Datasets.Clear();

            if (name == "Cột")
            {
                HorizontalBarChart();
            }
            else if (name == "Tròn")
            {
                DoughnutChart();
            }
        }
    }
}
