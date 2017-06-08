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
            //listBox1.Items.Add("id \t naam \t\t prijs \t aantal");
            if (productList != null) {
                foreach (Product p in productList)
                {
                    if (p.Aantal > 0) {
                        listBox1.Items.Add(p.Id + " \t " + p.Naam + " \t\t " + p.Prijs + " \t " + p.Aantal);
                    }
                }
            }
            else
            {
                listBox1.Items.Add("* Niets om weer te geven *");
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
            //refresh product list
            List<Product> productList = service.GetProducts(username, password);
            listBox1.Items.Clear();
            //listBox1.Items.Add("id \t naam \t\t prijs \t aantal");
            if(productList != null)
            {
                foreach (Product p in productList)
                {
                    if (p.Aantal > 0)
                    {
                        listBox1.Items.Add(p.Id + " \t " + p.Naam + " \t\t " + p.Prijs + " \t " + p.Aantal);
                    }
                }
            }
            else
            {
                listBox1.Items.Add("* Niets om weer te geven *");
            }


            //refresh forms
            InventoryForm inv = (InventoryForm)Application.OpenForms["InventoryForm"];
            if (inv != null)
            {
                inv.Close();
                inv = new InventoryForm(username, password);
                inv.MdiParent = (Main_MDIParent)Application.OpenForms["Main_MDIParent"];
                inv.Show();
            }
            SaldoForm sal = (SaldoForm)Application.OpenForms["SaldoForm"];
            if (sal != null)
            {
                sal.Close();
                sal = new SaldoForm(username, password);
                sal.MdiParent = (Main_MDIParent)Application.OpenForms["Main_MDIParent"];
                sal.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Product> productList = service.GetProducts(username, password);
            int ProductIndex = listBox1.SelectedIndex;
            if (ProductIndex >= 0)
            {
                Product selectedProduct = productList[ProductIndex];
                if (service.BuyProduct(username, password, selectedProduct))
                {
                    MessageBox.Show("aankoop success");
                    productList = service.GetProducts(username, password);
                    listBox1.Items.Clear();
                    //listBox1.Items.Add("id \t naam \t\t prijs \t aantal");
                    if (productList != null)
                    {
                        foreach (Product p in productList)
                        {
                            if (p.Aantal > 0)
                            {
                                listBox1.Items.Add(p.Id + " \t " + p.Naam + " \t\t " + p.Prijs + " \t " + p.Aantal);
                            }
                        }
                    }
                    else
                    {
                        listBox1.Items.Add("* Niets om weer te geven *");
                    }
                    //refresh forms
                    InventoryForm inv = (InventoryForm)Application.OpenForms["InventoryForm"];
                    if (inv != null) {
                        inv.Close();
                        inv = new InventoryForm(username, password);
                        inv.MdiParent = (Main_MDIParent)Application.OpenForms["Main_MDIParent"];
                        inv.Show();
                    }
                    SaldoForm sal = (SaldoForm)Application.OpenForms["SaldoForm"];
                    if (sal != null)
                    {
                        sal.Close();
                        sal = new SaldoForm(username, password);
                        sal.MdiParent = (Main_MDIParent)Application.OpenForms["Main_MDIParent"];
                        sal.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Uw saldo is te laag!");
                }
            }
            else
            {

                MessageBox.Show("geen selectie gemaakt");
            }
        }
    }
}
