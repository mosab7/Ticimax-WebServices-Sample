using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicimaxWebServicesSample
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            StaticVariables.alanAdi = Properties.Settings.Default.AlanAdi;
            StaticVariables.uyeKodu = Properties.Settings.Default.YetkiKodu;
            StaticVariables.kategoriList = StaticVariables.urunServisClient.SelectKategori(StaticVariables.uyeKodu, 0, "");
            StaticVariables.markaList = StaticVariables.urunServisClient.SelectMarka(StaticVariables.uyeKodu, 0);
            StaticVariables.tedarikciList = StaticVariables.urunServisClient.SelectTedarikci(StaticVariables.uyeKodu, 0);
            StaticVariables.etiketList = StaticVariables.urunServisClient.SelectEtiket(StaticVariables.uyeKodu, 0);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void urunServisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUrunServis frmUrunServis = new frmUrunServis();
            frmUrunServis.Show();
        }
        private void siparisServisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSiparisServis frmSiparisServis = new frmSiparisServis();
            frmSiparisServis.Show();
        }
        private void customServisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomServis frmCustomServis = new frmCustomServis();
            frmCustomServis.Show();
        }
        private void uyeServisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUyeServis frmUyeServis = new frmUyeServis();
            frmUyeServis.Show();
        }
        private void alanAdiAyarlariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlanAdiControl frmAlanAdiAyar = new frmAlanAdiControl(true);
            frmAlanAdiAyar.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Uygulamayı kapatmak istediğinize emin misiniz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                    Environment.Exit(0);
                else e.Cancel = true;
            }
            catch (Exception eex)
            {
            }
        }
    }
}
