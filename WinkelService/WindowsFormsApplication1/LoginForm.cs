using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ServiceModel;
using WinkelServiceLibrary;

namespace WindowsFormsApplication1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            //using (ServiceHost host = new ServiceHost(typeof(WinkelService)))
            //{
            //    host.Open();
            //}
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //TabPage1.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = "Gebruikersnaam bestaat al test";
        }

        
        private void button2_Click(object sender, EventArgs e)
        {

            //if login = true
            Main_MDIParent mdi = new Main_MDIParent();
            mdi.Show();
            this.Visible = false;

            //else
            label6.Text = "Gebruikersnaam error test";
            label7.Text = "Wachtwoord error test";


            //Form2 f2;
            //if (f2 == null)
            //{
            //    f2 = new Form2();
            //    f2.MdiParent = this;
            //    f2.Show();
            //}
            //else
            //    f2.Activate();

            //f2.MdiParent = this;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //gebruikersnaam error
            
        }
    }
}
