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
    public partial class Main_MDIParent : Form
    {
        private int childFormNumber = 0;
        String username;
        String password;

        public Main_MDIParent(string username, string password)
        {
            this.username = username;
            this.password = password;
            InitializeComponent();
        }

        private void Main_MDIParent_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        InventoryForm inv;
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inv == null)
            {
                inv = new InventoryForm(username, password);
                inv.MdiParent = this;
                inv.FormClosed += Inv_FormClosed;
                inv.Show();
            }
            else
            {
                inv.Activate();
            }
        }

        private void Inv_FormClosed(object sender, FormClosedEventArgs e)
        {
            inv = null;
        }

        StoreForm f2;
        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f2 == null)
            {
                f2 = new StoreForm(username, password);
                f2.MdiParent = this;
                f2.FormClosed += F2_FormClosed;
                f2.Show();
            }
            else
            {
                f2.Activate();
            }
        }

        private void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f2 = null;
        }

        private void MDIParent1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm f1 = (LoginForm)Application.OpenForms["LoginForm"];
            if (f1 != null)
                f1.Visible = true;
            else
            {
                f1 = new LoginForm();
                f1.Visible = true;
            }
        }

        private void uitloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SaldoForm sal;
        private void saldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sal == null)
            {
                sal = new SaldoForm(username, password);
                sal.MdiParent = this;
                sal.FormClosed += Sal_FormClosed;
                sal.Show();
            }
            else
            {
                sal.Activate();
            }
        }

        private void Sal_FormClosed(object sender, FormClosedEventArgs e)
        {
            sal = null;
        }

        private void wPFClientInterfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ExtraPuntenWPFclient.MainWindow wpfwindow = new ExtraPuntenWPFclient.MainWindow(username, password);
            wpfwindow.Show();


        }


    }
}
