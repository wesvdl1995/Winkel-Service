using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using WinkelServiceLibrary;


namespace ExtraPuntenWPFclient
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WinkelService service = new WinkelService();
        string username;
        string password;

        public MainWindow(string username, string password)
        {
            this.username = username;
            this.password = password;
            //ResizeMode = "CanMinimize";
            InitializeComponent();
            
            


            refresh();




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Product> productList = service.GetProducts(username, password);
            int ProductIndex = productsBox.SelectedIndex;
            if (ProductIndex >= 0)
            {
                Product selectedProduct = productList[ProductIndex];
                if (service.BuyProduct(username, password, selectedProduct))
                {
                    MessageBox.Show("aankoop success");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else
            {
                MessageBox.Show("geen selectie gemaakt");
            }
            refresh();
        }

        //public static explicit operator MainWindow(System.Windows.Forms.Form v)
        //{
        //    throw new NotImplementedException();
        //}

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            refresh();
        }

        private void productsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void inventoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
        private void refresh() {
            //refresh saldo
            moneyLabel.Content = "Money left: € " + (service.GetKlantSaldo(username, password)).ToString();

            //refresh product list
            List<Product> productList = service.GetProducts(username, password);
            productsBox.Items.Clear();
            if (productList != null)
            {
                foreach (Product p in productList)
                {
                    if (p.Aantal > 0)
                        productsBox.Items.Add(p.Id + " \t " + p.Naam + " \t\t " + p.Prijs + " \t " + p.Aantal);
                }
            }
            else
                productsBox.Items.Add("* Niets om weer te geven *");

            //refresh inventory list
            List<Product> aankoopList = service.GetAankopen(username, password);
            inventoryBox.Items.Clear();
            if (aankoopList != null)
            {
                foreach (Product p in aankoopList)
                {
                    inventoryBox.Items.Add(p.Naam + " \t\t " + p.Prijs);
                }
            }
            else
                inventoryBox.Items.Add("* Niets om weer te geven *");
        }
    }
}
