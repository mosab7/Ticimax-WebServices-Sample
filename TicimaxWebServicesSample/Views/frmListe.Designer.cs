namespace TicimaxWebServicesSample.Views
{
    partial class frmListe
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
            this.dtgResultList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgResultList
            // 
            this.dtgResultList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgResultList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultList.Location = new System.Drawing.Point(0, 0);
            this.dtgResultList.Name = "dtgResultList";
            this.dtgResultList.Size = new System.Drawing.Size(900, 642);
            this.dtgResultList.TabIndex = 0;
            this.dtgResultList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgResultList_CellContentClick);
            // 
            // frmListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 643);
            this.Controls.Add(this.dtgResultList);
            this.Name = "frmListe";
            this.Text = "Liste Form";
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgResultList;
    }
}