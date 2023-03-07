using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace DomezyDomotique
{
    public partial class Profile : Form

    {

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlCommand cmd1;
        MySqlDataReader dr;
        MySqlDataAdapter da;

       
        public Profile()
        {
            InitializeComponent();
            conn = new MySqlConnection();
            conn.ConnectionString = "datasource=localhost; username=root;password=;database=domezy";
        }

        private void Profile_Load(object sender, EventArgs e)
        {

            FillGrid();

        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }
        //afficher
        private void FillGrid()
        {
            dataGrid.Rows.Clear();

            conn.Open();

            cmd = new MySqlCommand("SELECT * FROM users ", conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGrid.Rows.Add(dr["id"].ToString(), dr["name"].ToString(), dr["last_name"].ToString(), dr["username"].ToString(), dr["password"].ToString(), dr["image"]);
            }

            dr.Close();
            conn.Close();
            for (var i = 0; i <= dataGrid.Rows.Count - 1; i++)
            {
                DataGridViewRow r = dataGrid.Rows[i];
                r.Height = 50;
               

            }
            var imagecolumn = (DataGridViewImageColumn)dataGrid.Columns["Column6"];
            imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch;


        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            acount a = new acount();
            a.Show();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {




        }



        //SUPPRIMER
        private void guna2Button4_Click(object sender, EventArgs e)
            
        {

            if (DialogResult.Yes == MessageBox.Show("are you sure you want to delete account ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                foreach(DataGridViewRow item in this.dataGrid.SelectedRows)
                {

                    

                        int id = Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value);
                        string deleteQuery = "DELETE FROM users WHERE id='" + id + "'";
                        try
                        {
                            conn.Open();
                            MySqlCommand command = new MySqlCommand(deleteQuery, conn);
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Account deleted successfully");

                            }
                            else
                            {
                                MessageBox.Show(" try again !");

                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                        conn.Close();
                        FillGrid();
                    


                }
            }

            
            }
        //ajouter
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            acount a = new acount();
            a.Show();
          
            FillGrid();
        }
        //modifier
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            acount a = new acount();
            a.Show();
            a.textboxId.Text = this.dataGrid.CurrentRow.Cells[0].Value.ToString();
            a.name.Text = this.dataGrid.CurrentRow.Cells[1].Value.ToString();
            a.lastname.Text = this.dataGrid.CurrentRow.Cells[2].Value.ToString();
            a.username.Text = this.dataGrid.CurrentRow.Cells[3].Value.ToString();
            a.password.Text = this.dataGrid.CurrentRow.Cells[4].Value.ToString();
            a.guna2Button3.Visible= true;
            a.guna2Button1.Visible=false;
         
            
        }

       

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            acount a = new acount();
            
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        //______________
    }
}
