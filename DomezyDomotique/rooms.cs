using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

using Guna.UI2.WinForms.Suite;
using RestSharp;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using domitiqueProject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using MySqlConnector;

namespace DomezyDomotique
{

    public partial class rooms : Form
    {
       MySqlConnection conn = new MySqlConnection("datasource=localhost; username=root;password=;database=domezy");
        MySqlCommand cmd;
        MySqlCommand cmd1;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        public rooms()
        {

            InitializeComponent();
            FillGrid();
        }
    
        private void guna2Button3_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void guna2Button3_DragEnter(object sender, DragEventArgs e)
        {
          
        }

        private void guna2Button3_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_MouseDown(object sender, MouseEventArgs e)
        { 

        }

        private void guna2Panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void rooms_Load(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT label from rooms", conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString("label");
                cbrooms.Items.Add(name);

            }
            cmd.Dispose();
            reader.Close();
            MySqlCommand cmd1 = new MySqlCommand("SELECT label from devices", conn);
            MySqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                string name1 = reader1.GetString("label");
                cbdevices.Items.Add(name1);

            }
            cmd1.Dispose();
            reader1.Close();
            conn.Close();

        

    }
        //mouse down
        //light
     
        private void guna2PictureBox11_MouseDown(object sender, MouseEventArgs e)
        {
           
        }
        //smart tv
        private void guna2PictureBox13_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        //air conditioner
        private void guna2PictureBox14_MouseDown(object sender, MouseEventArgs e)
        {
           
        }
        //curtens
        private void guna2PictureBox15_MouseDown(object sender, MouseEventArgs e)
        {
          
        }
        private void FillGrid()
        {
            dataGridv.Rows.Clear();

            conn.Open();

            cmd = new MySqlCommand("SELECT * FROM devices ", conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridv.Rows.Add(dr["pic"], dr["label"].ToString());
            }

            dr.Close();
            conn.Close();
            for (var i = 0; i <= dataGridv.Rows.Count - 1; i++)
            {
                DataGridViewRow r = dataGridv.Rows[i];
                r.Height = 50;


            }
            var imagecolumn = (DataGridViewImageColumn)dataGridv.Columns["Column1"];
            imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch;


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            kitchen.Visible = true;
            string insertQuery = "INSERT INTO rooms (label) VALUES('Kitchen')";
            conn.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, conn);



            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    // MessageBox.Show("Bedroom created succesfully ");



                }
                else
                {
                    MessageBox.Show(" Kitchen already exist ");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitchen already exist ");
            }


            conn.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            kidsroom.Visible = true;
            string insertQuery = "INSERT INTO rooms (label) VALUES('Kids Room')";
            conn.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, conn);



            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    // MessageBox.Show("Bedroom created succesfully ");



                }
                else
                {
                    MessageBox.Show(" Kids Room already exist ");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kids Room already exist ");
            }


            conn.Close();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.Close();
                 }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            
        }
        static int cmp = 0;

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (cbrooms.Text == "")
            {
                MessageBox.Show("choose the room you want to insert the device in ");
            }
            else
            {
                String nom = cbrooms.Text;

                rooms zone = (rooms)cbdevices.SelectedValue;
                int connect = 0;
                int demarre = 0;


                if (cbdevices.SelectedItem.ToString().Equals(kitchen.Name) && cmp < 5)
                {
                    ObjetServices o = new ObjetServices();
                    int[] a = { 6, 6, 6, 6, 6 };
                    int[] c = { 10, 40, 70, 100, 130 };
                    Objet objet = new Objet(zone, nom, connect, demarre);
                    o.create(objet);
                    Guna2Button b = new Guna2Button();
                    b.Name = objet.getNom();
                    b.Text = objet.getNom();
                    b.Size = new System.Drawing.Size(64, 24);

                    b.Location = new System.Drawing.Point(a[cmp], c[cmp]);
                    b.Click += new EventHandler(buttoncolors);

                    kitchen.Controls.Add(b);
                    cmp++;

                }
                if (cbdevices.SelectedItem.ToString().Equals(livingroom.Name) && cmp < 4)
                {
                    ObjetServices o = new ObjetServices();
                    int[] a = { 6, 6, 6, 6, 6 };
                    int[] c = { 10, 40, 70, 100, 130 };
                    Objet objet = new Objet(zone, nom, connect, demarre);
                    o.create(objet);
                    Guna2Button b = new Guna2Button();
                    b.Name = objet.getNom();
                    b.Text = objet.getNom();
                    b.Size = new System.Drawing.Size(64, 24);

                    b.Location = new System.Drawing.Point(a[cmp], c[cmp]);
                    b.Click += new EventHandler(buttoncolors);

                    livingroom.Controls.Add(b);
                    cmp++;

                }
                if (cbdevices.SelectedItem.ToString().Equals(toilet.Name) && cmp < 3)
                {
                    ObjetServices o = new ObjetServices();
                    int[] a = { 6, 6, 6, 6, 6 };
                    int[] c = { 10, 40, 70, 100, 130 };
                    Objet objet = new Objet(zone, nom, connect, demarre);
                    o.create(objet);
                    Guna2Button b = new Guna2Button();
                    b.Name = objet.getNom();
                    b.Text = objet.getNom();
                    b.Size = new System.Drawing.Size(64, 24);

                    b.Location = new System.Drawing.Point(a[cmp], c[cmp]);
                    b.Click += new EventHandler(buttoncolors);

                    toilet.Controls.Add(b);
                    cmp++;

                }
                if (cbdevices.SelectedItem.ToString().Equals(kidsroom.Name) && cmp < 2)
                {
                    ObjetServices o = new ObjetServices();
                    int[] a = { 6, 6, 6, 6, 6 };
                    int[] c = { 10, 40, 70, 100, 130 };
                    Objet objet = new Objet(zone, nom, connect, demarre);
                    o.create(objet);
                    Guna2Button b = new Guna2Button();
                    b.Name = objet.getNom();
                    b.Text = objet.getNom();
                    b.Size = new System.Drawing.Size(64, 24);

                    b.Location = new System.Drawing.Point(a[cmp], c[cmp]);
                    b.Click += new EventHandler(buttoncolors);

                    kidsroom.Controls.Add(b);
                    cmp++;

                }
                if (cbdevices.SelectedItem.ToString().Equals(bedroom.Name) && cmp < 1)
                {
                    ObjetServices o = new ObjetServices();
                    int[] a = { 6, 6, 6, 6, 6 };
                    int[] c = { 10, 40, 70, 100, 130 };
                    Objet objet = new Objet(zone, nom, connect, demarre);
                    o.create(objet);
                    Guna2Button b = new Guna2Button();
                    b.Name = objet.getNom();
                    b.Text = objet.getNom();
                    b.Size = new System.Drawing.Size(64, 24);

                    b.Location = new System.Drawing.Point(a[cmp], c[cmp]);
                    b.Click += new EventHandler(buttoncolors);

                    bedroom.Controls.Add(b);
                    cmp++;

                }

            }
            }

        private void guna2Button5_Click(object sender, EventArgs e, ObjetServices objetServices)
        {

           
        }
        private void buttoncolors(object sender, EventArgs e)
        {
            var button = (Guna2Button)sender;
            if (button.BackColor != Color.Lime)
            {
                button.BackColor = Color.Lime;


            }
            else
                button.BackColor = Color.Red;
        }
            private void guna2Button10_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            p.Show();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       

        private void searchtext_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            bedroom.Visible = true;
            string insertQuery = "INSERT INTO rooms (label) VALUES('Bedroom')";
            conn.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, conn);
         


            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                   // MessageBox.Show("Bedroom created succesfully ");
                   
                  

                }
                else
                {
                    MessageBox.Show(" bedroom already exist ");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("bedroom already exist ");
            }


            conn.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            livingroom.Visible = true;
            string insertQuery = "INSERT INTO rooms (label) VALUES('Living Room')";
            conn.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, conn);



            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    // MessageBox.Show("Bedroom created succesfully ");



                }
                else
                {
                    MessageBox.Show(" Living Room already exist ");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Living Room already exist ");
            }


            conn.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            toilet.Visible = true;
            string insertQuery = "INSERT INTO rooms (label) VALUES('Toilet')";
            conn.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, conn);



            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    // MessageBox.Show("Bedroom created succesfully ");



                }
                else
                {
                    MessageBox.Show(" Toilet already exist ");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Toilet already exist ");
            }


            conn.Close();
        }

        internal object getId()
        {
            throw new NotImplementedException();
        }

        private void bedroom_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click_1(object sender, EventArgs e)
        {
            dashboardStatique d = new dashboardStatique();
            d.Show();
            this.Hide();
        }
    }
    }

