using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class InventoryForm : Form
    {
        WinkelServiceRefrence.WinkelServiceClient service = new WinkelServiceRefrence.WinkelServiceClient();
        String username;
        String password;
        public InventoryForm(string username, string password)
        {
            this.username = username;
            this.password = password;
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            List<Product> aankoopList = service.GetAankopen(username, password);
            listBox1.Items.Clear();

            if (aankoopList != null)
            {
                foreach (Product p in aankoopList)
                {
                    listBox1.Items.Add(p.Naam + " \t\t € " + p.Prijs);
                }
            }
            else
            {
                listBox1.Items.Add("* Niets om weer te geven *");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
