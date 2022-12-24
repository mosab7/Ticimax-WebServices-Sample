using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TicimaxWebServicesSample.Methods;
using TicimaxWebServicesSample.UrunServis;

namespace TicimaxWebServicesSample
{
    public partial class frmUrunServis : Form
    {
        public frmUrunServis()
        {
            InitializeComponent();
        }

        private void btnDeleteKategori_Click(object sender, EventArgs e)
        {
            WebServisResponse webServisResponse = UrunServiceMethods.DeleteKategori();
        }
        private void btnSaveKategori_Click(object sender, EventArgs e)
        {
            int eklenenKategoriId = UrunServiceMethods.SaveKategori();
        }
        private void btnSaveKategoriParent_Click(object sender, EventArgs e)
        {
            UrunServiceMethods.SaveKategoriParent();
        }
        private void btnSelectKategori_Click(object sender, EventArgs e)
        {
            List<Kategori> kategoriListe = UrunServiceMethods.SelectKategori();
        }
        private void btnUpdateKategoriDil_Click(object sender, EventArgs e)
        {
            WebServisResponse webServisResponse = UrunServiceMethods.UpdateKategoriDil();
        }
        private void btnDeleteMarka_Click(object sender, EventArgs e)
        {
            WebServisResponse webServisResponse = UrunServiceMethods.DeleteMarka();
        }
        private void btnSaveMarka_Click(object sender, EventArgs e)
        {
            int eklenenMarkaId = UrunServiceMethods.SaveMarka();
        }
        private void btnSelectMarka_Click(object sender, EventArgs e)
        {
            List<Marka> MarkaListe = UrunServiceMethods.SelectMarka();
        }
        private void btnDeleteTedarikci_Click(object sender, EventArgs e)
        {
            WebServisResponse webServisResponse = UrunServiceMethods.DeleteTedarikci();
        }
        private void btnSaveTedarikci_Click(object sender, EventArgs e)
        {
            int eklenenTedarikciId = UrunServiceMethods.SaveTedarikci();
        }
        private void btnSelectTedarikci_Click(object sender, EventArgs e)
        {
            List<Tedarikci> TedarikciListe = UrunServiceMethods.SelectTedarikci();
        }
        private void btnSaveUrun_Click(object sender, EventArgs e)
        {
            UrunServiceMethods.SaveUrun();
        }
        private void btnSelectUrun_Click(object sender, EventArgs e)
        {
            List<UrunKarti> UrunListe = UrunServiceMethods.SelectUrun();
        }
        private void btnSelectUrunCount_Click(object sender, EventArgs e)
        {
            int urunSayisi = UrunServiceMethods.SelectUrunCount();
        }
        private void btnSelectUrunOdemeSecenek_Click(object sender, EventArgs e)
        {
            List<UrunOdemeSecenek> odemeSecenekListe = UrunServiceMethods.SelectUrunOdemeSecenek();
        }
        private void btnSelectUrunYorum_Click(object sender, EventArgs e)
        {
            List<UrunYorum> urunYorumListe = UrunServiceMethods.SelectUrunYorum();
        }
        private void btnSelectUrunKategori_Click(object sender, EventArgs e)
        {
            List<UrunKategori> urunKategoriListe = UrunServiceMethods.SelectUrunKategori();
        }
        private void btnSaveResim_Click(object sender, EventArgs e)
        {
            UrunServiceMethods.SaveResim();
        }
        private void btnSaveMagazaStok_Click(object sender, EventArgs e)
        {
            SaveMagazaStokResponse saveMagazaStokResponse = UrunServiceMethods.SaveMagazaStok();
        }
        private void btnUpdateUrunDil_Click(object sender, EventArgs e)
        {
            WebServisResponse webServisResponse = UrunServiceMethods.UpdateUrunDil();
        }
        private void btnSaveTeknikDetayDeger_Click(object sender, EventArgs e)
        {
            int eklenenTeknikDetayDegerId = UrunServiceMethods.SaveTeknikDetayDeger();
        }
        private void btnSaveTeknikDetayGrup_Click(object sender, EventArgs e)
        {
            int eklenenTeknikDetayGrupId = UrunServiceMethods.SaveTeknikDetayGrup();
        }
        private void btnSaveTeknikDetayOzellik_Click(object sender, EventArgs e)
        {
            int eklenenTeknikDetayOzellikId = UrunServiceMethods.SaveTeknikDetayOzellik();
        }
        private void btnSelectTeknikDetayDeger_Click(object sender, EventArgs e)
        {
            List<TeknikDetayDeger> teknikDetayDegerListe = UrunServiceMethods.SelectTeknikDetayDeger();
        }
        private void btnSelectTeknikDetayGrup_Click(object sender, EventArgs e)
        {
            List<TeknikDetayGrup> teknikDetayGrupListe = UrunServiceMethods.SelectTeknikDetayGrup();
        }
        private void btnSelectTeknikDetayOzellik_Click(object sender, EventArgs e)
        {
            List<TeknikDetayOzellik> teknikDetayOzeelikListe = UrunServiceMethods.SelectTeknikDetayOzellik();
        }
        private void btnUpdateTeknikDetayDegerDil_Click(object sender, EventArgs e)
        {
            WebServisResponse webServisResponse = UrunServiceMethods.UpdateTeknikDetayDegerDil();
        }
        private void btnUpdateTeknikDetayGrupDil_Click(object sender, EventArgs e)
        {
            WebServisResponse webServisResponse = UrunServiceMethods.UpdateTeknikDetayGrupDil();
        }
        private void btnUpdateTeknikDetayOzellikDil_Click(object sender, EventArgs e)
        {
            WebServisResponse webServisResponse = UrunServiceMethods.UpdateTeknikDetayOzellikDil();
        }
        private void btnSaveEtiket_Click(object sender, EventArgs e)
        {
            int eklenenEtiketId = UrunServiceMethods.SaveEtiket();
        }
        private void btnSelectEtiket_Click(object sender, EventArgs e)
        {
            List<Etiket> etiketListe = UrunServiceMethods.SelectEtiket();
        }
        private void btnSelectVaryasyon_Click(object sender, EventArgs e)
        {
            List<Varyasyon> VaryasyonListe = UrunServiceMethods.SelectVaryasyon();
        }
        private void btnSelectVaryasyonCount_Click(object sender, EventArgs e)
        {
            int varyasyonSayisi = UrunServiceMethods.SelectVaryasyonCount();
        }
        private void btnVaryasyonGuncelle_Click(object sender, EventArgs e)
        {
            UrunServiceMethods.VaryasyonGuncelle();
        }
        private void btnSaveAsortiGrup_Click(object sender, EventArgs e)
        {
            SaveResponse saveResponse = UrunServiceMethods.SaveAsortiGrup();
        }
        private void btnSaveAsortiMiktar_Click(object sender, EventArgs e)
        {
            SaveResponse saveResponse = UrunServiceMethods.SaveAsortiMiktar();
        }
        private void btnSelectAsortiGrup_Click(object sender, EventArgs e)
        {
            List<AsortiGrup> asortiGrupListe = UrunServiceMethods.SelectAsortiGrup();
        }
        private void btnSelectAsortiMiktar_Click(object sender, EventArgs e)
        {
            List<AsortiMiktar> asortiGrupListe = UrunServiceMethods.SelectAsortiMiktar();
        }
        private void btnSelectEkSecenekDeger_Click(object sender, EventArgs e)
        {
            List<EkSecenekDeger> ekSecenekDegerListe = UrunServiceMethods.SelectEkSecenekDeger();
        }
        private void btnSelectEkSecenekGrup_Click(object sender, EventArgs e)
        {
            List<EkSecenekGrup> ekSecenekDegerListe = UrunServiceMethods.SelectEkSecenekGrup();
        }
        private void btnUpdateEkSecenekDegerDil_Click(object sender, EventArgs e)
        {
            WebServisResponse webServisResponse = UrunServiceMethods.UpdateEkSecenekDegerDil();
        }
        private void btnUpdateEkSecenekGrupDil_Click(object sender, EventArgs e)
        {
            WebServisResponse webServisResponse = UrunServiceMethods.UpdateEkSecenekGrupDil();
        }
        private void btnSaveParaBirimi_Click(object sender, EventArgs e)
        {
            int eklenenParaBirimiId = UrunServiceMethods.SaveParaBirimi();
        }
        private void btnSelectParaBirimi_Click(object sender, EventArgs e)
        {
            List<ParaBirimi> paraBirimiListe = UrunServiceMethods.SelectParaBirimi();
        }
        private void btnGetProductStatus_Click(object sender, EventArgs e)
        {
            List<SiparisUrunDurumlari> siparisUrunDurumlariListe = UrunServiceMethods.GetProductStatus();
        }
        private void btnUpdateUrl_Click(object sender, EventArgs e)
        {
            UpdateUrlResponse updateUrlResponse = UrunServiceMethods.UpdateUrl();
        }
        private void btnGetTaksitSecenekleri_Click(object sender, EventArgs e)
        {
            List<UrunOdemeSecenekBanka> urunOdemeSecenekListe = UrunServiceMethods.GetTaksitSecenekleri();
        }
        private void btnSelectMagazaStok_Click(object sender, EventArgs e)
        {
            SelectMagazaStokResponse selectMagazaStokResponse = UrunServiceMethods.selectMagazaStok();
        }
        private void btnStokAdediGuncelle_Click(object sender, EventArgs e)
        {
            UrunServiceMethods.StokAdediGuncelle();
            //UrunServiceMethods.SaveUrunEtiket();
        }
        private void btnSaveIlgiliUrun_Click(object sender, EventArgs e)
        {
            UrunServiceMethods.SaveIlgiliUrun();
        }

        private void btnSaveVaryasyon_Click(object sender, EventArgs e)
        {
            UrunServiceMethods.SaveVaryasyon();
        }

        private void btnSelectIlgiliUrun_Click(object sender, EventArgs e)
        {
            UrunServiceMethods.SelectIlgiliUrun();
        }
    }
}
