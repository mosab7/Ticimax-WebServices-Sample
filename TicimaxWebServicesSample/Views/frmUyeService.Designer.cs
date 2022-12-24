namespace TicimaxWebServicesSample
{
    partial class frmUyeServis
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
            this.btnSelectUyeler = new System.Windows.Forms.Button();
            this.btnSelectUyeTuru = new System.Windows.Forms.Button();
            this.btnSaveUyeTuru = new System.Windows.Forms.Button();
            this.btnSaveUyeAdres = new System.Windows.Forms.Button();
            this.btnSelectUyeAdres = new System.Windows.Forms.Button();
            this.btnSaveUye = new System.Windows.Forms.Button();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectUyeler
            // 
            this.btnSelectUyeler.Location = new System.Drawing.Point(220, 145);
            this.btnSelectUyeler.Name = "btnSelectUyeler";
            this.btnSelectUyeler.Size = new System.Drawing.Size(178, 41);
            this.btnSelectUyeler.TabIndex = 18;
            this.btnSelectUyeler.Text = "SelectUyeler";
            this.btnSelectUyeler.UseVisualStyleBackColor = true;
            this.btnSelectUyeler.Click += new System.EventHandler(this.btnSelectUyeler_Click);
            // 
            // btnSelectUyeTuru
            // 
            this.btnSelectUyeTuru.Location = new System.Drawing.Point(24, 205);
            this.btnSelectUyeTuru.Name = "btnSelectUyeTuru";
            this.btnSelectUyeTuru.Size = new System.Drawing.Size(178, 41);
            this.btnSelectUyeTuru.TabIndex = 17;
            this.btnSelectUyeTuru.Text = "SelectUyeTuru";
            this.btnSelectUyeTuru.UseVisualStyleBackColor = true;
            this.btnSelectUyeTuru.Click += new System.EventHandler(this.btnSelectUyeTuru_Click);
            // 
            // btnSaveUyeTuru
            // 
            this.btnSaveUyeTuru.Location = new System.Drawing.Point(220, 83);
            this.btnSaveUyeTuru.Name = "btnSaveUyeTuru";
            this.btnSaveUyeTuru.Size = new System.Drawing.Size(178, 41);
            this.btnSaveUyeTuru.TabIndex = 16;
            this.btnSaveUyeTuru.Text = "SaveUyeTuru";
            this.btnSaveUyeTuru.UseVisualStyleBackColor = true;
            this.btnSaveUyeTuru.Click += new System.EventHandler(this.btnSaveUyeTuru_Click);
            // 
            // btnSaveUyeAdres
            // 
            this.btnSaveUyeAdres.Location = new System.Drawing.Point(24, 83);
            this.btnSaveUyeAdres.Name = "btnSaveUyeAdres";
            this.btnSaveUyeAdres.Size = new System.Drawing.Size(178, 41);
            this.btnSaveUyeAdres.TabIndex = 15;
            this.btnSaveUyeAdres.Text = "SaveUyeAdres";
            this.btnSaveUyeAdres.UseVisualStyleBackColor = true;
            this.btnSaveUyeAdres.Click += new System.EventHandler(this.btnSaveUyeAdres_Click);
            // 
            // btnSelectUyeAdres
            // 
            this.btnSelectUyeAdres.Location = new System.Drawing.Point(24, 145);
            this.btnSelectUyeAdres.Name = "btnSelectUyeAdres";
            this.btnSelectUyeAdres.Size = new System.Drawing.Size(178, 41);
            this.btnSelectUyeAdres.TabIndex = 12;
            this.btnSelectUyeAdres.Text = "SelectUyeAdres";
            this.btnSelectUyeAdres.UseVisualStyleBackColor = true;
            this.btnSelectUyeAdres.Click += new System.EventHandler(this.btnSelectUyeAdres_Click);
            // 
            // btnSaveUye
            // 
            this.btnSaveUye.Location = new System.Drawing.Point(220, 21);
            this.btnSaveUye.Name = "btnSaveUye";
            this.btnSaveUye.Size = new System.Drawing.Size(178, 41);
            this.btnSaveUye.TabIndex = 11;
            this.btnSaveUye.Text = "SaveUye";
            this.btnSaveUye.UseVisualStyleBackColor = true;
            this.btnSaveUye.Click += new System.EventHandler(this.btnSaveUye_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(24, 21);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(178, 41);
            this.btnGirisYap.TabIndex = 10;
            this.btnGirisYap.Text = "GirisYap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // frmUyeServis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 269);
            this.Controls.Add(this.btnSelectUyeler);
            this.Controls.Add(this.btnSelectUyeTuru);
            this.Controls.Add(this.btnSaveUyeTuru);
            this.Controls.Add(this.btnSaveUyeAdres);
            this.Controls.Add(this.btnSelectUyeAdres);
            this.Controls.Add(this.btnSaveUye);
            this.Controls.Add(this.btnGirisYap);
            this.MaximumSize = new System.Drawing.Size(439, 308);
            this.MinimumSize = new System.Drawing.Size(439, 308);
            this.Name = "frmUyeServis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Servis";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectUyeler;
        private System.Windows.Forms.Button btnSelectUyeTuru;
        private System.Windows.Forms.Button btnSaveUyeTuru;
        private System.Windows.Forms.Button btnSaveUyeAdres;
        private System.Windows.Forms.Button btnSelectUyeAdres;
        private System.Windows.Forms.Button btnSaveUye;
        private System.Windows.Forms.Button btnGirisYap;
    }
}