namespace TicimaxWebServicesSample
{
    partial class frmAlanAdiControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAlanAdi = new System.Windows.Forms.TextBox();
            this.tbUyeKodu = new System.Windows.Forms.TextBox();
            this.btnAlanAdiUyeKoduOnayla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alan Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Üye kodu";
            // 
            // tbAlanAdi
            // 
            this.tbAlanAdi.Location = new System.Drawing.Point(110, 118);
            this.tbAlanAdi.Name = "tbAlanAdi";
            this.tbAlanAdi.Size = new System.Drawing.Size(246, 20);
            this.tbAlanAdi.TabIndex = 2;
            this.tbAlanAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAlanAdi_KeyPress);
            // 
            // tbUyeKodu
            // 
            this.tbUyeKodu.Location = new System.Drawing.Point(110, 152);
            this.tbUyeKodu.Name = "tbUyeKodu";
            this.tbUyeKodu.Size = new System.Drawing.Size(246, 20);
            this.tbUyeKodu.TabIndex = 3;
            this.tbUyeKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUyeKodu_KeyPress);
            // 
            // btnAlanAdiUyeKoduOnayla
            // 
            this.btnAlanAdiUyeKoduOnayla.Location = new System.Drawing.Point(281, 188);
            this.btnAlanAdiUyeKoduOnayla.Name = "btnAlanAdiUyeKoduOnayla";
            this.btnAlanAdiUyeKoduOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnAlanAdiUyeKoduOnayla.TabIndex = 4;
            this.btnAlanAdiUyeKoduOnayla.Text = "ONAYLA";
            this.btnAlanAdiUyeKoduOnayla.UseVisualStyleBackColor = true;
            this.btnAlanAdiUyeKoduOnayla.Click += new System.EventHandler(this.btnAlanAdiYetkiKoduGuncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicimaxWebServicesSample.Properties.Resources.ticimax_logo;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmAlanAdiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 223);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAlanAdiUyeKoduOnayla);
            this.Controls.Add(this.tbUyeKodu);
            this.Controls.Add(this.tbAlanAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(384, 262);
            this.MinimumSize = new System.Drawing.Size(384, 262);
            this.Name = "frmAlanAdiControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alan Adı Kontrol";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAlanAdi;
        private System.Windows.Forms.TextBox tbUyeKodu;
        private System.Windows.Forms.Button btnAlanAdiUyeKoduOnayla;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}