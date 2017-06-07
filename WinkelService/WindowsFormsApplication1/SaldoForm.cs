using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinkelServiceLibrary;

namespace WindowsFormsApplication1
{
    public partial class SaldoForm : Form
    {
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
            WinkelService service = new WinkelService();
            label1.Text = service.GetKlantSaldo(username, password).ToString(); ;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
