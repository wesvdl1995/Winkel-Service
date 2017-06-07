﻿using System;
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
            
            moneyLabel.Content = "Money left: € " + (service.GetKlantSaldo(username, password)).ToString();

            List<Product> productList = service.GetProducts(username, password);
            productsBox.Items.Clear();
            //productsBox.Items.Add("id \t naam \t\t prijs \t aantal");
            if (productList != null)
            {
                foreach (Product p in productList)
                {
                    productsBox.Items.Add(p.Id + " \t " + p.Naam + " \t\t " + p.Prijs + " \t " + p.Aantal);
                }
            }
            else
            {
                productsBox.Items.Add("* Niets om weer te geven *");
            }
            List<Aankoop> aankoopList = service.GetAankopen(username, password);
            inventoryBox.Items.Clear();
            //listBox1.Items.Add("naam \t\t aantal");
            if (aankoopList != null)
            {
                foreach (Aankoop r in aankoopList)
                {
                    foreach (AankoopRegel a in r.AankoopRegels)
                    {
                        inventoryBox.Items.Add(a.Product.Naam + " \t\t " + a.Product.Aantal);
                    }
                }
            }
            else
            {
                inventoryBox.Items.Add("* Niets om weer te geven *");
            }

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
            List<Product> productList = service.GetProducts(username, password);
            productsBox.Items.Clear();
            //productsBox.Items.Add("id \t naam \t\t prijs \t aantal");
            if (productList != null) {
                foreach (Product p in productList)
                {
                    if (p.Aantal > 0)
                    {
                        productsBox.Items.Add(p.Id + " \t " + p.Naam + " \t\t " + p.Prijs + " \t " + p.Aantal);
                    }
                }
            }
            else
            {
                productsBox.Items.Add("* Niets om weer te geven *");
            }

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
    }
}
