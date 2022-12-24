using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TicimaxWebServicesSample.CustomServis;

namespace TicimaxWebServicesSample.Methods
{
    public static class CustomServiceMethods
    {
     
        public static AddFavoriUrunResponse AddFavoriUrun()
        {
            try
            {              
                AddFavoriUrunRequest addFavoriUrunRequest = new AddFavoriUrunRequest
                {
                    Adet = 1,
                    UrunKartiID = 1,
                    UyeID = 1
                };
                AddFavoriUrunResponse addFavoriUrunResponse = StaticVariables.customServisClient.AddFavoriUrun(StaticVariables.uyeKodu, addFavoriUrunRequest);

                if (addFavoriUrunResponse.IsError)
                    MessageBox.Show(addFavoriUrunResponse.ErrorMessage);
                else
                    MessageBox.Show("Favori ürün eklendi.");

                return addFavoriUrunResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static AddFiyatAlarmUrunResponse AddFiyatAlarmUrun()
        {
            try
            {
                AddFiyatAlarmUrunRequest addFiyatAlarmUrunRequest = new AddFiyatAlarmUrunRequest
                {
                    Fiyat = 100,
                    UyeID = 1,
                    UrunKartiID = 1
                };
                AddFiyatAlarmUrunResponse addFiyatAlarmUrunResponse = StaticVariables.customServisClient.AddFiyatAlarmUrun(StaticVariables.uyeKodu, addFiyatAlarmUrunRequest);

                if (addFiyatAlarmUrunResponse.IsError)
                    MessageBox.Show(addFiyatAlarmUrunResponse.ErrorMessage);
                else
                    MessageBox.Show("Fiyat alarm eklendi");

                return addFiyatAlarmUrunResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static AddStokAlarmUrunResponse AddStokAlarmUrun()
        {
            try
            {
                AddStokAlarmUrunRequest addStokAlarmUrunRequest = new AddStokAlarmUrunRequest
                {
                    UrunKartiID = 1,
                    UyeID = 1
                };
                AddStokAlarmUrunResponse addStokAlarmUrunResponse = StaticVariables.customServisClient.AddStokAlarmUrun(StaticVariables.uyeKodu, addStokAlarmUrunRequest);

                if (addStokAlarmUrunResponse.IsError)
                    MessageBox.Show(addStokAlarmUrunResponse.ErrorMessage);
                else
                    MessageBox.Show("Stok alarm eklendi.");

                return addStokAlarmUrunResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static GetFavoriUrunlerResponse GetFavoriUrunler()
        {
            try
            {
                GetFavoriUrunlerRequest getFavoriUrunlerRequest = new GetFavoriUrunlerRequest { UyeID = 1 };

                GetFavoriUrunlerResponse getFavoriUrunlerResponse = StaticVariables.customServisClient.GetFavoriUrunler(StaticVariables.uyeKodu, getFavoriUrunlerRequest);

                if (getFavoriUrunlerResponse.IsError)
                    MessageBox.Show(getFavoriUrunlerResponse.ErrorMessage);
                else
                {
                    MessageBox.Show("Favori ürünler listelendi");
                    StaticFunctions.CevapListele(getFavoriUrunlerResponse.Urunler.Cast<object>().ToList(), "Favori Ürünler");
                }

                return getFavoriUrunlerResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static GetFiyatAlarmUrunlerResponse GetFiyatAlarmUrunler()
        {
            try
            {
                GetFiyatAlarmUrunlerRequest getFiyatAlarmUrunlerRequest = new GetFiyatAlarmUrunlerRequest
                {
                    UyeID = 1
                };
                GetFiyatAlarmUrunlerResponse getFiyatAlarmUrunlerResponse = StaticVariables.customServisClient.GetFiyatAlarmUrunler(StaticVariables.uyeKodu, getFiyatAlarmUrunlerRequest);

                if (getFiyatAlarmUrunlerResponse.IsError)
                    MessageBox.Show(getFiyatAlarmUrunlerResponse.ErrorMessage);
                else
                {
                    MessageBox.Show("Fiyat alarmlı ürünler listelendi.");
                    StaticFunctions.CevapListele(getFiyatAlarmUrunlerResponse.Urunler.Cast<object>().ToList(), "Fiyat Alarm Ürünler");
                }
                return getFiyatAlarmUrunlerResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static GetStokAlarmUrunlerResponse GetStokAlarmUrunler()
        {
            try
            {
                GetStokAlarmUrunlerRequest getStokAlarmUrunlerRequest = new GetStokAlarmUrunlerRequest
                {
                    UyeID = 1
                };

                GetStokAlarmUrunlerResponse getStokAlarmUrunlerResponse = StaticVariables.customServisClient.GetStokAlarmUrunler(StaticVariables.uyeKodu, getStokAlarmUrunlerRequest);

                if (getStokAlarmUrunlerResponse.IsError)
                    MessageBox.Show(getStokAlarmUrunlerResponse.ErrorMessage);
                else
                {
                    MessageBox.Show("Stok alarmlı ürünler listelendi.");
                    StaticFunctions.CevapListele(getStokAlarmUrunlerResponse.Urunler.Cast<object>().ToList(), "Stok Alarm Ürünler");
                }
                return getStokAlarmUrunlerResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static RemoveFavoriUrunResponse RemoveFavoriUrun()
        {
            try
            {
                RemoveFavoriUrunRequest removeFavoriUrunRequest = new RemoveFavoriUrunRequest
                {
                    FavoriUrunID = 1,
                    UyeID = 1
                };

                RemoveFavoriUrunResponse removeFavoriUrunResponse = StaticVariables.customServisClient.RemoveFavoriUrun(StaticVariables.uyeKodu, removeFavoriUrunRequest);

                if (removeFavoriUrunResponse.IsError)
                    MessageBox.Show(removeFavoriUrunResponse.ErrorMessage);
                else
                    MessageBox.Show("Favori ürün silindi.");

                return removeFavoriUrunResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static RemoveFiyatAlarmUrunResponse RemoveFiyatAlarmUrun()
        {
            try
            {
                RemoveFiyatAlarmUrunRequest removeFiyatAlarmUrunRequest = new RemoveFiyatAlarmUrunRequest
                {
                    FiyatAlarmUrunID = 1,
                    UyeID = 1
                };

                RemoveFiyatAlarmUrunResponse removeFiyatAlarmUrunResponse = StaticVariables.customServisClient.RemoveFiyatAlarmUrun(StaticVariables.uyeKodu, removeFiyatAlarmUrunRequest);

                if (removeFiyatAlarmUrunResponse.IsError)
                    MessageBox.Show(removeFiyatAlarmUrunResponse.ErrorMessage);
                else
                    MessageBox.Show("Fiyat alarm ürün silindi.");

                return removeFiyatAlarmUrunResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static RemoveStokAlarmUrunResponse RemoveStokAlarmUrun()
        {
            try
            {
                RemoveStokAlarmUrunRequest removeStokAlarmUrunRequest = new RemoveStokAlarmUrunRequest
                {
                    StokAlarmUrunID = 1,
                    UyeID = 1
                };
                RemoveStokAlarmUrunResponse removeStokAlarmUrunResponse = StaticVariables.customServisClient.RemoveStokAlarmUrun(StaticVariables.uyeKodu, removeStokAlarmUrunRequest);

                if (removeStokAlarmUrunResponse.IsError)
                    MessageBox.Show(removeStokAlarmUrunResponse.ErrorMessage);
                else
                    MessageBox.Show("Stok alarm ürün silindi.");

                return removeStokAlarmUrunResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static void DeleteEntegrasyonId()
        {
            try
            {
                Entegrasyon entegrasyon = new Entegrasyon
                {
                    EntegrasyonKodu = "entegrasyonkod",
                    TabloAlan = "tablo alan ",
                    AlanDeger = "alan değer ",
                    Tanim = "tanım",
                    //Deger = "",
                    //EklemeTarihi= new DateTime(2018,9,12)
                };

                StaticVariables.customServisClient.DeleteEntegrasyonId(StaticVariables.uyeKodu, entegrasyon);
                MessageBox.Show("Entegrasyon  silindi.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public static void SaveEntegrasyonId()
        {
            try
            {
                Entegrasyon entegrasyon = new Entegrasyon
                {
                    AlanDeger = "entegrasyon Alan değer",
                    Deger = "değer",
                    EntegrasyonKodu = "entregrasyon kodu",
                    TabloAlan = "tablo alan",
                    Tanim = "tanım"
                };

                StaticVariables.customServisClient.SaveEntegrasyonId(StaticVariables.uyeKodu, entegrasyon);
                MessageBox.Show("Entegrasyon eklendi.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public static List<Entegrasyon> SelectEntegrasyon()
        {
            try
            {
                List<Entegrasyon> entegrasyonListe = StaticVariables.customServisClient.SelectEntegrasyon(StaticVariables.uyeKodu, "entregrasyon kodu", 1);

                MessageBox.Show("Bulunan entegrasyon sayısı " + entegrasyonListe.Count);

                StaticFunctions.CevapListele(entegrasyonListe.Cast<object>().ToList(), "Entegrasyonlar");

                return entegrasyonListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }

        }
        public static string SelectEntegrasyonId()
        {
            try
            {
                Entegrasyon entegrasyon = new Entegrasyon
                {
                    AlanDeger = "entegrasyon Alan değer",
                    EntegrasyonKodu = "entregrasyon kodu",
                    TabloAlan = "tablo alan",
                    Tanim = "tanım"
                };

                string entegrasyonDeger = StaticVariables.customServisClient.SelectEntegrasyonId(StaticVariables.uyeKodu, entegrasyon);

                MessageBox.Show("Entegrasyon id bulundu :" + entegrasyonDeger);

                return entegrasyonDeger;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static KargoDesiFiyatSelectResponse GuncelleKargoDesiFiyat()
        {
            try
            {
                KargoDesiFiyatBilgisi kargoDesiFiyatBilgisi = new KargoDesiFiyatBilgisi
                {
                    DesiBas = 3,
                    DesiSon = 7,
                    ID = 1, // güncellenecek kargo desi fiyat id 
                    SehirIci = true,
                    Fiyat = 8,
                    KargoID = 2, // kayıtlı kargo id 
                    SehirID = 1, // kayıtlı şehir id 
                    UlkeID = 1   // kayıtlı ülke id 
                };

                KargoDesiFiyatGuncelleRequest kargoDesiFiyatGuncelleRequest = new KargoDesiFiyatGuncelleRequest
                {
                    KargoDesiFiyatBilgisi = kargoDesiFiyatBilgisi,
                    //SadeceSehirIcineGonderim = true,
                    //KargoKapsami=1,
                    //UlkeBelirle=true,
                    //UlkeID=1
                };

                KargoDesiFiyatSelectResponse kargoDesiFiyatSelectResponse = StaticVariables.customServisClient.GuncelleKargoDesiFiyat(StaticVariables.uyeKodu, kargoDesiFiyatGuncelleRequest);

                if (kargoDesiFiyatSelectResponse.IsError)
                    MessageBox.Show(kargoDesiFiyatSelectResponse.ErrorMessage);
                else
                    MessageBox.Show("Kargo desi fiyat bilgisi güncellendi.");

                return kargoDesiFiyatSelectResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static KargoDesiFiyatSelectResponse SelectKargoDesiFiyat()
        {
            try
            {
                // tüm parametreler boş gönderilir ise filtre olmadan tüm kayıtlar döner.
                //parametreler tek veya ikili olarak da kullanılabilir örnek olarak sadece FiltreKargoID gönderilip girilen FiltreKargoID li tüm kayıtlar getirilebilir. 
                KargoDesiFiyatSelectRequest kargoDesiFiyatSelectRequest = new KargoDesiFiyatSelectRequest
                {
                    FiltreKargoID = 0,
                    FiltreSehirID = 0,
                    FiltreUlkeID = 0
                };

                KargoDesiFiyatSelectResponse kargoDesiFiyatSelectResponse = StaticVariables.customServisClient.SelectKargoDesiFiyat(StaticVariables.uyeKodu, kargoDesiFiyatSelectRequest);

                if (kargoDesiFiyatSelectResponse.IsError)
                    MessageBox.Show(kargoDesiFiyatSelectResponse.ErrorMessage);
                else
                {
                    MessageBox.Show("Kargo desi fiyatları listelendi.");
                    StaticFunctions.CevapListele(kargoDesiFiyatSelectResponse.KargoDesiFiyatListesi.Cast<object>().ToList(), "Kargo Desi Fiyatları");
                }

                return kargoDesiFiyatSelectResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<KargoFirma> SelectKargoFirmalari()
        {
            try
            {
                List<KargoFirma> kargoFirmaListe = StaticVariables.customServisClient.SelectKargoFirmalari(StaticVariables.uyeKodu);

                MessageBox.Show("Kargo firmaları  listelendi. " + kargoFirmaListe.Count + " adet kargo firmanız bulunmaktadır.");

                StaticFunctions.CevapListele(kargoFirmaListe.Cast<object>().ToList(), "Kargo Firmaları");

                return kargoFirmaListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static WebIadeTalepResponse SelectIadeTalebi()
        {
            try
            {
                // integer alanlar -1 gönderilir ise filtre yapılmaz 
                IadeTalepFiltre iadeTalepFiltre = new IadeTalepFiltre
                {
                    DurumID = -1,
                    ParaIadeTipi = 1,
                    SiparisID = -1,
                    UyeID = -1,
                    ID = -1,
                    //EklemeTarihi1 = new DateTime(2016, 10, 10),
                    //EklemeTarihi2 = new DateTime(2018, 10, 10),
                    //UyeAdi = ""
                };
                WebIadeTalepSelectRequest webIadeTalepSelectRequest = new WebIadeTalepSelectRequest
                {
                    Filtre = iadeTalepFiltre
                };

                WebIadeTalepResponse webIadeTalepResponse = StaticVariables.customServisClient.SelectIadeTalebi(StaticVariables.uyeKodu, webIadeTalepSelectRequest);

                if (webIadeTalepResponse.IsError)
                    MessageBox.Show(webIadeTalepResponse.ErrorMessage);
                else
                {
                    MessageBox.Show("iade talepleri listelendi.");
                    StaticFunctions.CevapListele(webIadeTalepResponse.IadeTalepList.Cast<object>().ToList(), "İade Talepleri");
                }

                return webIadeTalepResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static WebIadeTalepResponse UpdateIadeTalebi()
        {
            try
            {
                IadeTalep iadeTalep = new IadeTalep
                {
                    ID = 0, // id 0 gönderilir ise yeni kayıt ekler 0 dan büyük gönderilir ise gönderilen id li kayıt güncellenir. 
                    Cevap = "cevap",
                    Cevaplayan = "cevaplayan ismi",
                    CevaplayanID = 1,
                    Durum = "durum",
                    DurumID = 1,
                    SiparisID = 1,
                    UyeID = 1,
                    ParaIadeTipi = 2,
                };
                WebIadeTalepGuncelleRequest webIadeTalepGuncelleRequest = new WebIadeTalepGuncelleRequest
                {
                    Talep = iadeTalep,
                    MailGonder = false,
                };

                WebIadeTalepResponse webIadeTalepResponse = StaticVariables.customServisClient.UpdateIadeTalebi(StaticVariables.uyeKodu, webIadeTalepGuncelleRequest);

                if (webIadeTalepResponse.IsError)
                    MessageBox.Show(webIadeTalepResponse.ErrorMessage);
                else
                    MessageBox.Show("iade talep eklendi");

                return webIadeTalepResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static WebTaksitSecenekResponse GetTaksitSecenek()
        {
            try
            {
                WebTaksitSecenekRequest webTaksitSecenekRequest = new WebTaksitSecenekRequest
                {
                    MaksTaksitSayisi = 1,
                    Tutar = 0
                };

                WebTaksitSecenekResponse webTaksitSecenekResponse = StaticVariables.customServisClient.GetTaksitSecenek(StaticVariables.uyeKodu, webTaksitSecenekRequest);

                if (webTaksitSecenekResponse.IsError)
                    MessageBox.Show(webTaksitSecenekResponse.ErrorMessage);
                else
                {
                    MessageBox.Show("Taksit seçenekleri veri tabanından çekildi");
                    StaticFunctions.CevapListele(webTaksitSecenekResponse.TaksitSecenekleri.Cast<object>().ToList(), "Taksit Seçenekleri");
                }

                return webTaksitSecenekResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<KargoIlce> SelectIlceler()
        {
            try
            {
                // -1 gönderilen alanda filtreleme yapılmaz. alttaki kullanımda FiltreIlID=1 olan tüm ilçeler getirilir
                SelectIlceRequest selectIlceRequest = new SelectIlceRequest
                {
                    FiltreIlceID = -1,
                    FiltreIlID = -1
                };
                List<KargoIlce> ilceListe = StaticVariables.customServisClient.SelectIlceler(StaticVariables.uyeKodu, selectIlceRequest);

                MessageBox.Show("Filtrelere göre bulunan ilçe sayısı: " + ilceListe.Count);

                StaticFunctions.CevapListele(ilceListe.Cast<object>().ToList(), "İlçeler");

                return ilceListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }


        }
        public static List<KargoIl> SelectIller()
        {
            try
            {
                // -1 gönderilen alanda filtreleme yapılmaz. alttaki kullanımda FiltreUlkeID=1 olan tüm iller getirilir
                SelectIlRequest selectIlRequest = new SelectIlRequest
                {
                    FiltreIlID = -1,
                    FiltreUlkeID = -1
                };

                List<KargoIl> ilListe = StaticVariables.customServisClient.SelectIller(StaticVariables.uyeKodu, selectIlRequest);

                MessageBox.Show("Filtrelere göre bulunan il sayısı: " + ilListe.Count);

                StaticFunctions.CevapListele(ilListe.Cast<object>().ToList(), "İller");

                return ilListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<MailList> SelectMailList()
        {
            try
            {
                List<MailList> mailListe = StaticVariables.customServisClient.SelectMailList(StaticVariables.uyeKodu, new DateTime(2014, 1, 1), new DateTime(2018, 11, 20));

                MessageBox.Show("Filtrelere göre bulunan mail sayısı: " + mailListe.Count);

                StaticFunctions.CevapListele(mailListe.Cast<object>().ToList(), "Mailler");

                return mailListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<KargoUlke> SelectUlkeler()
        {
            try
            {
                // parametreler gönderilmez ise tüm kayıtlar gelir
                // FiltreUlkeKodu  veya FiltreUlkeID parametreleri tek gönderilerek de cevap alınabilir
                SelectUlkeRequest selectUlkeRequest = new SelectUlkeRequest
                {
                    FiltreUlkeID = 1,
                    FiltreUlkeKodu = "TR"
                };
                List<KargoUlke> ulkeListe = StaticVariables.customServisClient.SelectUlkeler(StaticVariables.uyeKodu, selectUlkeRequest);

                MessageBox.Show("Filtrelere göre bulunan ülke sayısı: " + ulkeListe.Count);

                StaticFunctions.CevapListele(ulkeListe.Cast<object>().ToList(), "Ülkeler");
                return ulkeListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static GetMenuResponse GetMenu()
        {
            GetMenuRequest getMenuRequest = new GetMenuRequest
            {
                Aktif = -1, // -1 gönderilir ise filtreye dahil olmaz hem aktif olanlar hem olmayanları kapsar. 
                Dil = "", // dil parametresi zorunlu değil
                MenuID = 0 // id girilirse girilen idli menu gelir girilmez ise tüm menuleri getirir.
            };

            GetMenuResponse getMenuResponse = StaticVariables.customServisClient.GetMenu(StaticVariables.uyeKodu, getMenuRequest);
            StaticFunctions.CevapListele(getMenuResponse.Menuler.Cast<object>().ToList(), "Menüler");

            return getMenuResponse;
        }
        public static SaveMenuResponse SaveManu()
        {
            List<WebMenu> webMenus = new List<WebMenu>();
            WebMenu webMenu = new WebMenu
            {
                Aktif = true, 
                Baslik = "Menu Başlık",
                BitisTarihi = DateTime.Now.AddYears(1),
                Icerik = "Menü İçerik",
                ID = 0, // 0 gönderilir ise yeni menu eklenir 0 dan büyük gönderilirse gönderilen id li ürün güncellenir. 
                PID = 0, // üst menü id 
                Resim = "", 
                ResimTargetUrl = "", 
                ResimYolu = "",
                Sira = 1,
                Target = "",
                Tip = 1,
                Url = ""
            };
            webMenus.Add(webMenu);
            SaveMenuRequest saveMenuRequest = new SaveMenuRequest
            {
                Dil = "tr",
                Menuler = webMenus
            };
            SaveMenuResponse saveMenuResponse = StaticVariables.customServisClient.SaveMenu(StaticVariables.uyeKodu, saveMenuRequest);
            return saveMenuResponse;
        }
        public static DeleteMenuResponse DeleteMenu()
        {
            List<WebMenu> webMenus = new List<WebMenu>();
            webMenus.Add(new WebMenu { ID = 1  }); // id değerleri dikkate alınarak silinir. 
            DeleteMenuRequest deleteMenuRequest = new DeleteMenuRequest
            {
                Menuler = webMenus
            };
            DeleteMenuResponse deleteMenuResponse = StaticVariables.customServisClient.DeleteMenu(StaticVariables.uyeKodu, deleteMenuRequest);
            return deleteMenuResponse;
        }

    }
}
