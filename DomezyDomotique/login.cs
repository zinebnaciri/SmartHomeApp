using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySqlConnector;

namespace DomezyDomotique
{

    public partial class login : Form
    {
       
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)

        {
            MySqlConnection con = new MySqlConnection("datasource= localhost; database=domezy; username = root; password="); //open connection
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from users where username = '" + user.Text + "' AND password = '" + pass.Text + "'", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            try {
            if (reader.Read())
            {
                 userLogName.userName = user.Text;
                    this.Hide();
                    dashboardStatique p = new dashboardStatique();
                    p.Show();
            }
            else
            {
                MessageBox.Show("username or password incorrect. please try again !", "Oups !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           user.Text = string.Empty;
            pass.Text = string.Empty;
            reader.Close();
            cmd.Dispose();
            con.Close(); // always close connection }
        }
    

   
               
           

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
