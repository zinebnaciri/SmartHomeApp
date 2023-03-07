using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace DomezyDomotique
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }
        

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lbl_username.Text = userLogName.userName;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            rooms r = new rooms();
            r.Show();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            rooms r = new rooms();
            r.Show();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            rooms r = new rooms();
            r.Show();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();  
            p.Show();
        }

        private void guna2Button11_Click_1(object sender, EventArgs e)
        {
            acount a = new acount();
            a.Show();
        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }
    }
    }

