﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartExpress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            using (dbchartEntities db = new dbchartEntities())
            {
                chartRevenue.DataSource = db.Revenues.ToList();
                chartRevenue.Series["Revenue"].XValueMember = "Year";
                chartRevenue.Series["Revenue"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                chartRevenue.Series["Revenue"].YValueMembers = "Total";
                chartRevenue.Series["Revenue"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //chartSalary.Series["Salary"].Points.AddXY("Peter", 1000);
            //chartSalary.Series["Salary"].Points.AddXY("John", 5000);
            //chartSalary.Series["Salary"].Points.AddXY("Tan", 1500);
            //chartSalary.Series["Salary"].Points.AddXY("Luck", 7000);
            chartSalary.Series["Salary"].Points.Add(1000);
            chartSalary.Series["Salary"].Points[0].Color=Color.Red;
            chartSalary.Series["Salary"].Points[0].AxisLabel="Peter";
            chartSalary.Series["Salary"].Points[0].LegendText = "Peter";
            chartSalary.Series["Salary"].Points[0].Label = "1000";
            //
            chartSalary.Series["Salary"].Points.Add(5000);
            chartSalary.Series["Salary"].Points[1].Color = Color.Green;
            chartSalary.Series["Salary"].Points[1].AxisLabel = "John";
            chartSalary.Series["Salary"].Points[1].LegendText = "John";
            chartSalary.Series["Salary"].Points[1].Label = "5000";
            //
            chartSalary.Series["Salary"].Points.Add(1500);
            chartSalary.Series["Salary"].Points[2].Color = Color.Yellow;
            chartSalary.Series["Salary"].Points[2].AxisLabel = "Tan";
            chartSalary.Series["Salary"].Points[2].LegendText = "Tan";
            chartSalary.Series["Salary"].Points[2].Label = "1500";
            //
            chartSalary.Series["Salary"].Points.Add(7000);
            chartSalary.Series["Salary"].Points[3].Color = Color.Blue;
            chartSalary.Series["Salary"].Points[3].AxisLabel = "Luck";
            chartSalary.Series["Salary"].Points[3].LegendText = "Luck";
            chartSalary.Series["Salary"].Points[3].Label = "7000";

        }
    }
}
