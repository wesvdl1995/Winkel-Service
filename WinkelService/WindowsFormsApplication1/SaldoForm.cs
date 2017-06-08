using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using WinkelServiceLibrary;

namespace WindowsFormsApplication1
{
    public partial class SaldoForm : Form
    {
        WinkelServiceRefrence.WinkelServiceClient service = new WinkelServiceRefrence.WinkelServiceClient();
        string username;
        string password;

        public SaldoForm(string username, string password)
        {
            this.username = username;
            this.password = password;
            InitializeComponent();
        }

        private void SaldoForm_Load(object sender, EventArgs e)
        {
            //WinkelService service = new WinkelService();
            label1.Text = "€ "+service.GetKlantSaldo(username, password).ToString();
            int saldopersentage = (int)Math.Ceiling(service.GetKlantSaldo(username, password)) * 2;
            progressBar1.Value = (saldopersentage);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
