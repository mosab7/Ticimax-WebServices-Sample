using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TicimaxWebServicesSample.Methods;
using TicimaxWebServicesSample.UyeServis;

namespace TicimaxWebServicesSample
{
    public partial class frmUyeServis : Form
    {
        public frmUyeServis()
        {
            InitializeComponent();
        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            UyeGirisiSonuc uyeGirisiSonuc = UyeServiceMethods.GirisYap();
        }
        private void btnSaveUye_Click(object sender, EventArgs e)
        {
            int eklenenUyeId = UyeServiceMethods.SaveUye();
        }
        private void btnSaveUyeAdres_Click(object sender, EventArgs e)
        {
            int eklenenAdresId = UyeServiceMethods.SaveUyeAdres();
        }
        private void btnSaveUyeTuru_Click(object sender, EventArgs e)
        {
            int eklenenUyeTuruId = UyeServiceMethods.SaveUyeTuru();
        }
        private void btnSelectUyeAdres_Click(object sender, EventArgs e)
        {
            List<UyeAdres> uyeAdresListe = UyeServiceMethods.SelectUyeAdres();
        }
        private void btnSelectUyeler_Click(object sender, EventArgs e)
        {
            List<Uye> uyeListe = UyeServiceMethods.SelectUyeler();
        }
        private void btnSelectUyeTuru_Click(object sender, EventArgs e)
        {
            List<UyeTuru> uyeTuruListe = UyeServiceMethods.SelectUyeTuru();
        }
    }
}
