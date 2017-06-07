namespace WindowsFormsApplication1
{
    partial class Main_MDIParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_MDIParent));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.saldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wPFClientInterfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.productsToolStripMenuItem.Text = "Store";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.profileToolStripMenuItem.Text = "Inventory";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.saldoToolStripMenuItem,
            this.uitloggenToolStripMenuItem,
            this.wPFClientInterfaceToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(637, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // saldoToolStripMenuItem
            // 
            this.saldoToolStripMenuItem.Name = "saldoToolStripMenuItem";
            this.saldoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.saldoToolStripMenuItem.Text = "Saldo";
            this.saldoToolStripMenuItem.Click += new System.EventHandler(this.saldoToolStripMenuItem_Click);
            // 
            // uitloggenToolStripMenuItem
            // 
            this.uitloggenToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uitloggenToolStripMenuItem.Name = "uitloggenToolStripMenuItem";
            this.uitloggenToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.uitloggenToolStripMenuItem.Text = "Uitloggen";
            this.uitloggenToolStripMenuItem.Click += new System.EventHandler(this.uitloggenToolStripMenuItem_Click);
            // 
            // wPFClientInterfaceToolStripMenuItem
            // 
            this.wPFClientInterfaceToolStripMenuItem.Name = "wPFClientInterfaceToolStripMenuItem";
            this.wPFClientInterfaceToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.wPFClientInterfaceToolStripMenuItem.Text = "WPF client interface";
            this.wPFClientInterfaceToolStripMenuItem.Click += new System.EventHandler(this.wPFClientInterfaceToolStripMenuItem_Click);
            // 
            // Main_MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._50c;
            this.ClientSize = new System.Drawing.Size(637, 511);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main_MDIParent";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIParent1_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem saldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uitloggenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wPFClientInterfaceToolStripMenuItem;
    }
}



