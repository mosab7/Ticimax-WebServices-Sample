namespace TicimaxWebServicesSample
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünServisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünServisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişServisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customServisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeServisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alanAdıAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünServisToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünServisToolStripMenuItem
            // 
            this.ürünServisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünServisToolStripMenuItem1,
            this.siparişServisToolStripMenuItem,
            this.customServisToolStripMenuItem,
            this.üyeServisToolStripMenuItem});
            this.ürünServisToolStripMenuItem.Name = "ürünServisToolStripMenuItem";
            this.ürünServisToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ürünServisToolStripMenuItem.Text = "Servisler";
            // 
            // ürünServisToolStripMenuItem1
            // 
            this.ürünServisToolStripMenuItem1.Name = "ürünServisToolStripMenuItem1";
            this.ürünServisToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.ürünServisToolStripMenuItem1.Text = "Ürün Servis";
            this.ürünServisToolStripMenuItem1.Click += new System.EventHandler(this.urunServisToolStripMenuItem1_Click);
            // 
            // siparişServisToolStripMenuItem
            // 
            this.siparişServisToolStripMenuItem.Name = "siparişServisToolStripMenuItem";
            this.siparişServisToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.siparişServisToolStripMenuItem.Text = "Sipariş Servis";
            this.siparişServisToolStripMenuItem.Click += new System.EventHandler(this.siparisServisToolStripMenuItem_Click);
            // 
            // customServisToolStripMenuItem
            // 
            this.customServisToolStripMenuItem.Name = "customServisToolStripMenuItem";
            this.customServisToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.customServisToolStripMenuItem.Text = "Custom Servis";
            this.customServisToolStripMenuItem.Click += new System.EventHandler(this.customServisToolStripMenuItem_Click);
            // 
            // üyeServisToolStripMenuItem
            // 
            this.üyeServisToolStripMenuItem.Name = "üyeServisToolStripMenuItem";
            this.üyeServisToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.üyeServisToolStripMenuItem.Text = "Üye Servis";
            this.üyeServisToolStripMenuItem.Click += new System.EventHandler(this.uyeServisToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alanAdıAyarlarıToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // alanAdıAyarlarıToolStripMenuItem
            // 
            this.alanAdıAyarlarıToolStripMenuItem.Name = "alanAdıAyarlarıToolStripMenuItem";
            this.alanAdıAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alanAdıAyarlarıToolStripMenuItem.Text = "Alan adı ayarları";
            this.alanAdıAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.alanAdiAyarlariToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::TicimaxWebServicesSample.Properties.Resources.mainIMage1;
            this.pictureBox1.Location = new System.Drawing.Point(120, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 171);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1000, 590);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Ticimax Services";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünServisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünServisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem siparişServisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customServisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeServisToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alanAdıAyarlarıToolStripMenuItem;
    }
}

