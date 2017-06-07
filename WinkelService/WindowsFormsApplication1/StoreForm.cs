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
    public partial class StoreForm : Form
    {
        String username;
        String password;
        WinkelService service = new WinkelService();

        public StoreForm(string username, string password)
        {
            this.username = username;
            this.password = password;

            InitializeComponent();
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            
            List<Product> productList = service.GetProducts(username, password);
            listBox1.Items.Clear();
            foreach (Product p in productList)
            {
                if (p.Aantal > 0) {
                    listBox1.Items.Add(p.Id + " | " + p.Naam + " | " + p.Prijs + " | " + p.Aantal);
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> productList = service.GetProducts(username, password);
            int ProductIndex = listBox1.SelectedIndex;
            if (ProductIndex >= 0)
            {
                Product selectedProduct = productList[ProductIndex];
                if (service.BuyProduct(username, password, selectedProduct))
                {
                    MessageBox.Show("aankoop success");
                }
                else {
                    MessageBox.Show("error");
                }
            }
            else {

                MessageBox.Show("geen selectie gemaakt");
            }

            
        }
    }
}
