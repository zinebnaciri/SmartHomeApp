using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Controls;
using Image = System.Drawing.Image;
using System.Data.SqlClient;
using MySqlConnector;

namespace DomezyDomotique
{
    public partial class acount : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; username=root;password=;database=domezy");
        
        public acount()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            guna2CirclePictureBox1.Image.Save(ms, guna2CirclePictureBox1.Image.RawFormat);
            Byte[] img =ms.ToArray();
            string insertQuery = "INSERT INTO users (name,last_name,username,password,type,image) VALUES('" + name.Text + "','" + lastname.Text + "','" + username.Text + "','" + password.Text + "','" + guna2ComboBox1.Text + "',@img)";
            conn.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, conn);
            command.Parameters.Add("@img", MySqlDbType.Blob);
            command.Parameters["@img"].Value = img;


            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("account created succesfully ");
                    name.Clear();
                    lastname.Clear();
                    username.Clear();
                    password.Clear();
                    guna2ComboBox1.ResetText();
                    guna2CirclePictureBox1.ResetText();
                    Profile p = new Profile();
                    p.Show();
                  

                    this.Hide();
                 




                }
                else
                {
                    MessageBox.Show(" account not created. Try again!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            conn.Close();
        }

        private void acount_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "choose image(*.jpg; *.png)|*.jpg; *.png";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                guna2CirclePictureBox1.Image = Image.FromFile(opf.FileName);
            }
            
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
          
            

              
                string insertQuery = "Update users set name= '" + name.Text + "',last_name='" + lastname.Text + "',username='" + username.Text + "',password='" + password.Text + "',type= '" + guna2ComboBox1.Text + "' WHERE id ='" + textboxId.Text + "'";
                conn.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, conn);


                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("account updated succesfully ");
                        this.Hide();
                        p.Show();

                    }
                    else
                    {
                        MessageBox.Show(" account not updated. Try again!");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                conn.Close();
                }
            }
        }
    
