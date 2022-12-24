using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TicimaxWebServicesSample.Methods;
using TicimaxWebServicesSample.SiparisServis;

namespace TicimaxWebServicesSample
{
    public partial class frmSiparisServis : Form
    {
        public frmSiparisServis()
        {
            InitializeComponent();
        }
        private void btnSaveSiparis_Click(object sender, EventArgs e)
        {
            WebSiparisSaveResponse webSiparisSaveResponse = SiparisServiceMethods.SaveSiparis();
        }
        private void btnSaveSiparisKargoPaket_Click(object sender, EventArgs e)
        {
            string response = SiparisServiceMethods.SaveSiparisKargoPaket();
        }
        private void btnSaveSiparisKargoPaketKargoTakipNo_Click(object sender, EventArgs e)
        {
            SaveSiparisKargoPaketKargoTakipNoResponse saveSiparisKargoPaketKargoTakipNoResponse = SiparisServiceMethods.SaveSiparisKargoPaketKargoTakipNo();
        }
        private void btnSelectSiparis_Click(object sender, EventArgs e)
        {
            List<WebSiparis> webSiparisListe = SiparisServiceMethods.SelectSiparis();
        }
        private void btnSelectSiparisKargoPaket_Click(object sender, EventArgs e)
        {
            List<WebKargoPaket> webKargoPaketListe = SiparisServiceMethods.SelectSiparisKargoPaket();
        }
        private void btnSelectSiparisOdeme_Click(object sender, EventArgs e)
        {
            List<WebSiparisOdeme> webSiparisOdemeListe = SiparisServiceMethods.SelectSiparisOdeme();
        }
        private void btnSelectSiparisUrun_Click(object sender, EventArgs e)
        {
            List<WebSiparisUrun> webSiparisUrunListe = SiparisServiceMethods.SelectSiparisUrun();
        }
        private void btnSelectSiparisUrunDurumlari_Click(object sender, EventArgs e)
        {
            List<SiparisUrunDurumlari> siparisUrunDurumlariListe = SiparisServiceMethods.SelectSiparisUrunDurumlari();
        }
        private void btnSetSiparisAktarildi_Click(object sender, EventArgs e)
        {
            SiparisServiceMethods.SetSiparisAktarildi();
        }
        private void btnSetSiparisAktarildiIptal_Click(object sender, EventArgs e)
        {
            SiparisServiceMethods.SetSiparisAktarildiIptal();
        }
        private void btnSetSiparisDurum_Click(object sender, EventArgs e)
        {
           SetSiparisDurumResponse setSiparisDurumResponse= SiparisServiceMethods.SetSiparisDurum();
        }
        private void btnSetSiparisKargoyaVerildi_Click(object sender, EventArgs e)
        {
            SiparisServiceMethods.SetSiparisKargoyaVerildi();
        }
        private void btnSetSiparisTeslimEdildi_Click(object sender, EventArgs e)
        {
            SiparisServiceMethods.SetSiparisTeslimEdildi();
        }
        private void btnGetKargoSecenek_Click(object sender, EventArgs e)
        {
          List<WebKargoFirma> webKargoFirmaListe =   SiparisServiceMethods.GetKargoSecenek();
        }
        private void btnSaveKargoTakipNo_Click(object sender, EventArgs e)
        {
           string response =  SiparisServiceMethods.SaveKargoTakipNo();
        }
        private void btnGetOdemeTipleri_Click(object sender, EventArgs e)
        {
          List<SiparisOdemeTipleri> siparisOdemeTipleriListe =  SiparisServiceMethods.GetOdemeTipleri();
        }
        private void btnGetSepet_Click(object sender, EventArgs e)
        {

            ServisSepet servisSepet = SiparisServiceMethods.GetSepet();
         
        }
        private void btnSelectCariOdeme_Click(object sender, EventArgs e)
        {
           List<WebSiparisOdeme> webSiparisOdemeListe =  SiparisServiceMethods.SelectCariOdeme();
        }
        private void btnSelectSepet_Click(object sender, EventArgs e)
        {
          List<WebSepet> WebSepetListe =   SiparisServiceMethods.SelectSepet();
        }
        private void btnSelectWebSepet_Click(object sender, EventArgs e)
        {
          List<WebSepet> webSepetListe =   SiparisServiceMethods.SelectWebSepet();
        }
        private void btnSetFaturaNo_Click(object sender, EventArgs e)
        {
            SiparisServiceMethods.SetFaturaNo();
        }
        private void btnSetSiparisUrunDurum_Click(object sender, EventArgs e)
        {
            SetSiparisUrunDurumResponse setSiparisUrunDurumResponse = SiparisServiceMethods.SetSiparisUrunDurum();
        }
    }
}
