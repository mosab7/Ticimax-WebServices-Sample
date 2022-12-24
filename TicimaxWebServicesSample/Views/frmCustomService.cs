using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TicimaxWebServicesSample.CustomServis;
using TicimaxWebServicesSample.Methods;

namespace TicimaxWebServicesSample
{
    public partial class frmCustomServis : Form
    {
        public frmCustomServis()
        {
            InitializeComponent();


            
        }
        private void btnAddFavoriUrun_Click(object sender, EventArgs e)
        {
            AddFavoriUrunResponse addFavoriUrunResponse = CustomServiceMethods.AddFavoriUrun();
        }
        private void btnAddFiyatAlarmUrun_Click(object sender, EventArgs e)
        {
            AddFiyatAlarmUrunResponse addFiyatAlarmUrunResponse = CustomServiceMethods.AddFiyatAlarmUrun();
        }
        private void btnAddStokAlarmUrun_Click(object sender, EventArgs e)
        {
            AddStokAlarmUrunResponse addStokAlarmUrunResponse = CustomServiceMethods.AddStokAlarmUrun();
        }
        private void btnGetFavoriUrunler_Click(object sender, EventArgs e)
        {
            GetFavoriUrunlerResponse getFavoriUrunlerResponse = CustomServiceMethods.GetFavoriUrunler();
        }
        private void btnGetFiyatAlarmUrunler_Click(object sender, EventArgs e)
        {
            GetFiyatAlarmUrunlerResponse getFiyatAlarmUrunlerResponse = CustomServiceMethods.GetFiyatAlarmUrunler();
        }
        private void btnGetStokAlarmUrunler_Click(object sender, EventArgs e)
        {
            GetStokAlarmUrunlerResponse getStokAlarmUrunlerResponse = CustomServiceMethods.GetStokAlarmUrunler();
        }
        private void btnRemoveFavoriUrun_Click(object sender, EventArgs e)
        {
            RemoveFavoriUrunResponse removeFavoriUrunResponse = CustomServiceMethods.RemoveFavoriUrun();
        }
        private void btnRemoveFiyatAlarmUrun_Click(object sender, EventArgs e)
        {
            RemoveFiyatAlarmUrunResponse removeFiyatAlarmUrunResponse = CustomServiceMethods.RemoveFiyatAlarmUrun();
        }
        private void btnRemoveStokAlarmUrun_Click(object sender, EventArgs e)
        {
            RemoveStokAlarmUrunResponse removeStokAlarmUrunResponse = CustomServiceMethods.RemoveStokAlarmUrun();
        }
        private void btnDeleteEntegrasyonId_Click(object sender, EventArgs e)
        {
            CustomServiceMethods.DeleteEntegrasyonId();
        }
        private void btnSaveEntegrasyonId_Click(object sender, EventArgs e)
        {
            CustomServiceMethods.SaveEntegrasyonId();
        }
        private void btnSelectEntegrasyonId_Click(object sender, EventArgs e)
        {
            string response = CustomServiceMethods.SelectEntegrasyonId();
        }
        private void btnGuncelleKargoDesiFiyat_Click(object sender, EventArgs e)
        {
            KargoDesiFiyatSelectResponse kargoDesiFiyatSelectResponse = CustomServiceMethods.GuncelleKargoDesiFiyat();
        }
        private void btnSelectKargoDesiFiyat_Click(object sender, EventArgs e)
        {
            KargoDesiFiyatSelectResponse kargoDesiFiyatSelectResponse = CustomServiceMethods.SelectKargoDesiFiyat();
        }
        private void btnSelectKargoFirmalari_Click(object sender, EventArgs e)
        {
            List<KargoFirma> kargoFirmaListe = CustomServiceMethods.SelectKargoFirmalari();
        }
        private void btnSelectIadeTalebi_Click(object sender, EventArgs e)
        {
            WebIadeTalepResponse webIadeTalepResponse = CustomServiceMethods.SelectIadeTalebi();
        }
        private void btnUpdateIadeTalebi_Click(object sender, EventArgs e)
        {
          WebIadeTalepResponse webIadeTalepResponse=   CustomServiceMethods.UpdateIadeTalebi();
        }
        private void btnGetTaksitSecenek_Click(object sender, EventArgs e)
        {
           WebTaksitSecenekResponse webTaksitSecenekResponse= CustomServiceMethods.GetTaksitSecenek();
        }
        private void btnSelectIlceler_Click(object sender, EventArgs e)
        {
          List<KargoIlce> kargoIlceListe = CustomServiceMethods.SelectIlceler();
        }
        private void btnSelectIller_Click(object sender, EventArgs e)
        {
           List<KargoIl> kargoIlListe= CustomServiceMethods.SelectIller();
        }
        private void btnSelectMailList_Click(object sender, EventArgs e)
        {
          List<MailList> mailListe=  CustomServiceMethods.SelectMailList();
        }
        private void btnSelectUlkeler_Click(object sender, EventArgs e)
        {
           List<KargoUlke> kargoUlkeListe =  CustomServiceMethods.SelectUlkeler();
        }
        private void btnSelectEntegrasyon_Click(object sender, EventArgs e)
        {
           List<Entegrasyon> entegrasyonListe =  CustomServiceMethods.SelectEntegrasyon();
        }
        private void btnGetMenu_Click(object sender, EventArgs e)
        {
            GetMenuResponse getMenuResponse =  CustomServiceMethods.GetMenu();
        }
        private void btnSaveMenu_Click(object sender, EventArgs e)
        {
            SaveMenuResponse saveMenuResponse = CustomServiceMethods.SaveManu();
        }
        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            DeleteMenuResponse deleteMenuResponse = CustomServiceMethods.DeleteMenu();
        }
    }
}
