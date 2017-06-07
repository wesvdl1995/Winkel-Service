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
            InitializeComponent();


            List<Product> productList = service.GetProducts(username, password);
            productsBox.Items.Clear();
            foreach (Product p in productList)
            {

                productsBox.Items.Add(p.Id + " | " + p.Naam + " | " + p.Prijs + " | " + p.Aantal);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    }
}
