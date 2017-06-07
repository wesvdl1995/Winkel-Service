﻿using System;
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
    public partial class InventoryForm : Form
    {
        WinkelService service = new WinkelService();
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
            List<AankoopRegel> aankoopList = service.GetAankopen(username, password);
            listBox1.Items.Clear();
            //listBox1.Items.Add("naam \t\t aantal");
            if (aankoopList != null)
            {
                foreach (AankoopRegel r in aankoopList)
                {
                    listBox1.Items.Add(r.Product.Naam + " \t\t " + r.Product.Aantal);
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
