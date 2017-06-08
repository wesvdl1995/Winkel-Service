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
//using WinkelServiceLibrary;

namespace WindowsFormsApplication1
{
    public partial class LoginForm : Form
    {

        //WinkelService service = new WinkelService();
        WinkelServiceRefrence.WinkelServiceClient service = new WinkelServiceRefrence.WinkelServiceClient();
        
        public LoginForm()
        {
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
            Clipboard.SetText(label5.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (service.RegistreerKlant(textBox3.Text))
            {
                label5.Text = service.GetWachtwoord(textBox3.Text);
            }
            else
            {
                label8.Text = "Gebruikersnaam bestaat al";
            }
            
        }

        
        private void button2_Click(object sender, EventArgs e)
        {

            if (service.Login(textBox1.Text, textBox2.Text))
            {
                  Main_MDIParent mdi = new Main_MDIParent(textBox1.Text, textBox2.Text);
                  mdi.Show();
                  this.Visible = false;
            }
            else
            {
                label6.Text = "Gebruikersnaam en/of wachtwoord is incorrect";
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //gebruikersnaam error
            
        }


        public string Username
        {
            get { return textBox1.Text; }
        }
    }
}
