using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomezyDomotique
{
    public partial class dashboardStatique : Form
    {
        public dashboardStatique()
        {
            InitializeComponent();

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            livingroom.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            bedroom.Visible = true;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            kidsroom.Visible = true;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            toilet.Visible = true;
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            hallway.Visible = true;
        }

        private void dashboardStatique_Load(object sender, EventArgs e)
        {
            lbl_username.Text = userLogName.userName;
           label7.Text = userLogName.userName;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_MouseDown(object sender, MouseEventArgs e)
        {
            guna2Button8.DoDragDrop(guna2Button8.ButtonMode, DragDropEffects.Copy);
        }

        private void guna2Button13_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void guna2Button14_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void guna2Button15_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void guna2Button16_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void guna2Button17_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void guna2Button5_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void bedroom_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void bedroom_DragLeave(object sender, EventArgs e)
        {

        }

        private void bedroom_DragDrop(object sender, DragEventArgs e)
        {
            Guna2Button bedroom = (Guna2Button)e.Data.GetData(DataFormats.Text);


        }
        Random rnd = new Random();
        private void guna2Panel1_DragDrop(object sender, DragEventArgs e)
        {

            Control c = e.Data.GetData(e.Data.GetFormats()[0]) as Control;
            // Declare rnd globally for creating random id for dynamic button(eg : Random rnd = new Random();)
            Guna2Button btn = new Guna2Button();
            btn.Name = "Button" + rnd.Next();
            btn.Size = c.Size;
            btn.Click += new System.EventHandler(guna2Button8_Click);
            if (c != null)
            {
                btn.Text = c.Text;
                btn.Location = this.guna2Panel1.PointToClient(new Point(e.X, e.Y));
                this.guna2Panel1.Controls.Add(btn);
            }
        }

        private void guna2Button11_Click_1(object sender, EventArgs e)
        {

            kitchen.Visible = true;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            livingroom.Visible = true;

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
           bedroom.Visible = true;
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {

            kidsroom.Visible = true;
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {

            toilet.Visible = true;
        }

        private void guna2Button19_Click_1(object sender, EventArgs e)
        {

            hallway.Visible = true;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void guna2Button8_Click_1(object sender, EventArgs e)
        {
            if (cbrooms.SelectedIndex == -1)
            {
                MessageBox.Show(" Please select a room first !");
            }
            else if(cbrooms.SelectedIndex == 2)
                {
                    bedTv.Visible = true;
                    Application.DoEvents();
                }
            else if (cbrooms.SelectedIndex == 3 )
                {
                    kidsTv.Visible = true;
                }
            else if (cbrooms.SelectedIndex == 0)
            {
                kitchenTv.Visible = true;
            }
            else if (cbrooms.SelectedIndex == 1)
            {
                livingTv.Visible = true;
            }

        }

        private void guna2Button13_Click_1(object sender, EventArgs e)
        {
            if (cbrooms.SelectedIndex == -1)
            {
                MessageBox.Show(" Please select a room first !");
            }
            else if (cbrooms.SelectedIndex == 1)
            {
                livingRouteur.Visible = true;
                Application.DoEvents();
            }
           
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            if (cbrooms.SelectedIndex == -1)
            {
                MessageBox.Show(" Please select a room first !");
            }
            else if (cbrooms.SelectedIndex == 0)
            {
                kitchenLight.Visible = true;
                Application.DoEvents();
            }
            else if (cbrooms.SelectedIndex == 1)
            {
                livingLight.Visible = true;
            }
            else if (cbrooms.SelectedIndex == 2)
            {
                bedLight.Visible = true;
            }
            else if (cbrooms.SelectedIndex == 3)
            {
                kidsLight.Visible = true;
            }
            else if (cbrooms.SelectedIndex == 4)
            {
                toiletLight.Visible = true;
            }
            else if (cbrooms.SelectedIndex == 5)
            {
                hallwaylight1.Visible = true;
            }
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            if (cbrooms.SelectedIndex == -1)
            {
                MessageBox.Show(" Please select a room first !");
            }
            else if (cbrooms.SelectedIndex == 2)
            {
                bedAlexa.Visible = true;
                Application.DoEvents();
            }
        }

        private void guna2Button16_Click_1(object sender, EventArgs e)
        {
            if (cbrooms.SelectedIndex == -1)
            {
                MessageBox.Show(" Please select a room first !");
            }
            else if (cbrooms.SelectedIndex == 2)
            {
                bedAir.Visible = true;
                Application.DoEvents();
            }
            else if (cbrooms.SelectedIndex == 1)
            {
                livingAir.Visible = true;
                Application.DoEvents();
            }
            else if (cbrooms.SelectedIndex == 0)
            {
                kitchenAir.Visible = true;
                Application.DoEvents();
            }
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            if (cbrooms.SelectedIndex == -1)
            {
                MessageBox.Show(" Please select a room first !");
            }
            else if (cbrooms.SelectedIndex == 1)
            {
                livingVaccum.Visible = true;
                Application.DoEvents();
            }
        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            if (cbrooms.SelectedIndex == -1)
            {
                MessageBox.Show(" Please select a room first !");
            }
            else if (cbrooms.SelectedIndex == 2)
            {
                bedDesk.Visible = true;
                Application.DoEvents();
            }
            else if (cbrooms.SelectedIndex == 3)
            {
                kidsDesk.Visible = true;
                Application.DoEvents();
            }
        }

        private void guna2Button33_Click(object sender, EventArgs e)
        {
            if (cbrooms.SelectedIndex == -1)
            {
                MessageBox.Show(" Please select a room first !");
            }
            else if (cbrooms.SelectedIndex == 0)
            {
                kitchenOven.Visible = true;
                Application.DoEvents();
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            p.Show();
        }

        private void bedLight_Click(object sender, EventArgs e)
        {
            bedLight.FillColor = Color.Green;
        }

        private void bedLight_DoubleClick(object sender, EventArgs e)
        {
            bedLight.FillColor = Color.Red;
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            rooms r = new rooms();
            r.Show();
            this.Hide();
        }

        private void bedTv_Click(object sender, EventArgs e)
        {
            bedTv.FillColor = Color.Green;
        }

        private void bedAir_Click(object sender, EventArgs e)
        {
            bedAir.FillColor = Color.Green;
        }

        private void bedAlexa_Click(object sender, EventArgs e)
        {
            bedAlexa.FillColor = Color.Green;
        }

        private void bedDesk_Click(object sender, EventArgs e)
        {
            bedDesk.FillColor = Color.Green;
        }

        private void toiletLight_Click(object sender, EventArgs e)
        {
            toiletLight.FillColor = Color.Green;
        }

        private void hallwaylight1_Click(object sender, EventArgs e)
        {
            hallwaylight1.FillColor = Color.Green;
        }

        private void kidsTv_Click(object sender, EventArgs e)
        {
            kidsTv.FillColor = Color.Green;
        }

        private void kidsLight_Click(object sender, EventArgs e)
        {
            kidsLight.FillColor = Color.Green;
        }

        private void kidsDesk_Click(object sender, EventArgs e)
        {
            kidsDesk.FillColor = Color.Green;
        }

        private void kitchenTv_Click(object sender, EventArgs e)
        {
            kitchenTv.FillColor = Color.Green;
        }

        private void kitchenLight_Click(object sender, EventArgs e)
        {
            kitchenLight.FillColor = Color.Green;
        }

        private void kitchenAir_Click(object sender, EventArgs e)
        {
            kitchenAir.FillColor = Color.Green;
        }

        private void kitchenOven_Click(object sender, EventArgs e)
        {
            kitchenOven.FillColor = Color.Green;
        }

        private void livingAir_Click(object sender, EventArgs e)
        {
            livingAir.FillColor = Color.Green;
        }

        private void livingLight_Click(object sender, EventArgs e)
        {
            livingLight.FillColor = Color.Green;
        }

        private void livingTv_Click(object sender, EventArgs e)
        {
            livingTv.FillColor = Color.Green;
        }

        private void livingVaccum_Click(object sender, EventArgs e)
        {
            livingVaccum.FillColor = Color.Green;
        }

        private void livingRouteur_Click(object sender, EventArgs e)
        {
            livingRouteur.FillColor = Color.Green;
        }

        private void bedTv_DoubleClick(object sender, EventArgs e)
        {
            bedTv.FillColor = Color.Red;
        }

        private void bedAir_DoubleClick(object sender, EventArgs e)
        {
            bedAir.FillColor = Color.Red;
        }

        private void bedAlexa_DoubleClick(object sender, EventArgs e)
        {
            bedAlexa.FillColor = Color.Red;
        }

        private void bedDesk_DoubleClick(object sender, EventArgs e)
        {
            bedDesk.FillColor = Color.Red;
        }

        private void toiletLight_DoubleClick(object sender, EventArgs e)
        {
            toiletLight.FillColor = Color.Red;
        }

        private void hallwaylight1_DoubleClick(object sender, EventArgs e)
        {
            hallwaylight1.FillColor = Color.Red;
        }

        private void kidsTv_DoubleClick(object sender, EventArgs e)
        {
            kidsTv.FillColor = Color.Red;
        }

        private void kidsLight_DoubleClick(object sender, EventArgs e)
        {
            kidsLight.FillColor = Color.Red;
        }

        private void kidsDesk_DoubleClick(object sender, EventArgs e)
        {
            kidsDesk.FillColor = Color.Red;
        }

        private void kitchenTv_DoubleClick(object sender, EventArgs e)
        {
          kitchenTv.FillColor = Color.Red;
        }

        private void kitchenLight_DoubleClick(object sender, EventArgs e)
        {
            kitchenLight.FillColor = Color.Red;
        }

        private void kitchenAir_DoubleClick(object sender, EventArgs e)
        {
            kitchenAir.FillColor = Color.Red;
        }

        private void kitchenOven_DoubleClick(object sender, EventArgs e)
        {
            kitchenOven.FillColor = Color.Red;
        }

        private void livingAir_DoubleClick(object sender, EventArgs e)
        {
            livingAir.FillColor = Color.Red;
        }

        private void livingLight_DoubleClick(object sender, EventArgs e)
        {
            livingLight.FillColor = Color.Red;
        }

        private void livingTv_DoubleClick(object sender, EventArgs e)
        {
            livingTv.FillColor = Color.Red;
        }

        private void livingRouteur_DoubleClick(object sender, EventArgs e)
        {
            livingVaccum.FillColor = Color.Red;
        }

        private void livingVaccum_DoubleClick(object sender, EventArgs e)
        {
            livingVaccum.FillColor = Color.Red;
        }
    }
}