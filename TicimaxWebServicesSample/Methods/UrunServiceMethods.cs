using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TicimaxWebServicesSample.UrunServis;

namespace TicimaxWebServicesSample.Methods
{
    public static class UrunServiceMethods
    {
        public static void StokAdediGuncelle()
        {
            try
            {
                List<Varyasyon> urunListe = new List<Varyasyon>();

                // id ve stok adedi göndermek yeterlidir. 
                Varyasyon varyasyon = new Varyasyon
                {
                    ID = 1, // kayıtlı varyasyon id değeri
                    StokAdedi = 30
                };
                urunListe.Add(varyasyon);
                StaticVariables.urunServisClient.StokAdediGuncelle(StaticVariables.uyeKodu, urunListe);
                MessageBox.Show(varyasyon.ID + " ID'li varyasyonun stok adedi güncellendi.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public static SelectMagazaStokResponse selectMagazaStok()
        {
            try
            {
                SelectMagazaStokRequest selectMagazaStokRequest = new SelectMagazaStokRequest
                {
                    MagazaKodu = "mağaza kodu"
                };
                SelectMagazaStokResponse selectMagazaStokResponse = StaticVariables.urunServisClient.SelectMagazaStok(StaticVariables.uyeKodu, selectMagazaStokRequest);

                if (selectMagazaStokResponse.IsError)
                    MessageBox.Show(selectMagazaStokResponse.ErrorMessage);
                else
                {
                    MessageBox.Show("Mağaza stok bilgisi Listelendi.");
                    StaticFunctions.CevapListele(selectMagazaStokResponse.MagazaStokList.Cast<object>().ToList(), "Mağaza Stoklar");
                }
                return selectMagazaStokResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static WebServisResponse UpdateEkSecenekGrupDil()
        {
            try
            {
                List<EkSecenekGrupDil> ekSecenekGrupDilListe = new List<EkSecenekGrupDil>();
                EkSecenekGrupDil ekSecenekGrupDil = new EkSecenekGrupDil
                {
                    ID = 1,
                    Tanim = "tanım ingilizce"
                };
                ekSecenekGrupDilListe.Add(ekSecenekGrupDil);
                UpdateEkSecenekGrupDilRequest updateEkSecenekGrupDilRequest = new UpdateEkSecenekGrupDilRequest
                {
                    Dil = "en", // dil kodu
                    Liste = ekSecenekGrupDilListe
                };
                UrunServis.WebServisResponse webServisResponse = StaticVariables.urunServisClient.UpdateEkSecenekGrupDil(StaticVariables.uyeKodu, updateEkSecenekGrupDilRequest);

                if (webServisResponse.IsError)
                    MessageBox.Show(webServisResponse.ErrorMessage);
                else
                    MessageBox.Show("Ek seçenek grup dili güncellendi");

                return webServisResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static WebServisResponse UpdateEkSecenekDegerDil()
        {
            try
            {
                List<EkSecenekDegerDil> ekSecenekDegerDilListe = new List<EkSecenekDegerDil>();
                EkSecenekDegerDil ekSecenekDegerDil = new EkSecenekDegerDil
                {
                    ID = 1,
                    Tanim = "tanım ingilizce"
                };
                ekSecenekDegerDilListe.Add(ekSecenekDegerDil);

                UpdateEkSecenekDegerDilRequest updateEkSecenekDegerDilRequest = new UpdateEkSecenekDegerDilRequest
                {
                    Dil = "en", // dil kodu 
                    Liste = ekSecenekDegerDilListe
                };

                UrunServis.WebServisResponse webServisResponse = StaticVariables.urunServisClient.UpdateEkSecenekDegerDil(StaticVariables.uyeKodu, updateEkSecenekDegerDilRequest);

                if (webServisResponse.IsError)
                    MessageBox.Show(webServisResponse.ErrorMessage);
                else
                    MessageBox.Show("Ek seçenek değer dili güncellendi");

                return webServisResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static WebServisResponse UpdateTeknikDetayOzellikDil()
        {
            try
            {
                List<TeknikDetayOzellikDil> teknikDetayOzellikDilListe = new List<TeknikDetayOzellikDil>();
                TeknikDetayOzellikDil teknikDetayOzellikDil = new TeknikDetayOzellikDil
                {
                    ID = 1,
                    Tanim = "tanım ingilizce"
                };
                teknikDetayOzellikDilListe.Add(teknikDetayOzellikDil);

                UpdateTeknikDetayOzellikDilRequest updateTeknikDetayOzellikDilRequest = new UpdateTeknikDetayOzellikDilRequest
                {
                    Dil = "en", // dil kodu 
                    Liste = teknikDetayOzellikDilListe
                };

                UrunServis.WebServisResponse webServisResponse = StaticVariables.urunServisClient.UpdateTeknikDetayOzellikDil(StaticVariables.uyeKodu, updateTeknikDetayOzellikDilRequest);

                if (webServisResponse.IsError)
                    MessageBox.Show(webServisResponse.ErrorMessage);
                else
                    MessageBox.Show("Teknik detay özellik dili güncellendi");

                return webServisResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static WebServisResponse UpdateTeknikDetayGrupDil()
        {
            try
            {
                List<TeknikDetayGrupDil> teknikDetayGrupDilListe = new List<TeknikDetayGrupDil>();
                TeknikDetayGrupDil teknikDetayGrupDil = new TeknikDetayGrupDil
                {
                    ID = 1,
                    Tanim = "tanım ingilizce"
                };
                teknikDetayGrupDilListe.Add(teknikDetayGrupDil);

                UpdateTeknikDetayGrupDilRequest updateTeknikDetayGrupDilRequest = new UpdateTeknikDetayGrupDilRequest
                {
                    Dil = "en", // dil kodu
                    Liste = teknikDetayGrupDilListe
                };

                UrunServis.WebServisResponse webServisResponse = StaticVariables.urunServisClient.UpdateTeknikDetayGrupDil(StaticVariables.uyeKodu, updateTeknikDetayGrupDilRequest);

                if (webServisResponse.IsError)
                    MessageBox.Show(webServisResponse.ErrorMessage);
                else
                    MessageBox.Show("Teknik detay grup dili güncellendi");

                return webServisResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static WebServisResponse UpdateTeknikDetayDegerDil()
        {
            try
            {
                List<TeknikDetayDegerDil> teknikDetayDegerDilListe = new List<TeknikDetayDegerDil>();
                TeknikDetayDegerDil teknikDetayDegerDil = new TeknikDetayDegerDil
                {
                    ID = 1,
                    Tanim = "tanım ingilizce"
                };

                teknikDetayDegerDilListe.Add(teknikDetayDegerDil);

                UpdateTeknikDetayDegerDilRequest updateTeknikDetayDegerDilRequest = new UpdateTeknikDetayDegerDilRequest
                {
                    Dil = "en", // dil kodu 
                    Liste = teknikDetayDegerDilListe
                };

                UrunServis.WebServisResponse webServisResponse = StaticVariables.urunServisClient.UpdateTeknikDetayDegerDil(StaticVariables.uyeKodu, updateTeknikDetayDegerDilRequest);

                if (webServisResponse.IsError)
                    MessageBox.Show(webServisResponse.ErrorMessage);
                else
                    MessageBox.Show("Teknik detay değer dili güncellendi");

                return webServisResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static WebServisResponse UpdateUrunDil()
        {
            try
            {
                UrunDilAyar urunDilAyar = new UrunDilAyar
                {
                    // hangi alanların güncelleneceğini belirtiyoruz. hiç yazmadığımız alanlar da false kabul edilir 
                    AciklamaGuncelle = true,
                    AramaAnahtarKelimeGuncelle = true,
                    OnYaziGuncelle = false,
                    SatisBirimiGuncelle = true,
                    SeoAnahtarKelimeGuncelle = false,
                    SeoNoFollowGuncelle = false,
                    SeoNoIndexGuncelle = false,
                    SeoSayfaAciklamaGuncelle = false,
                    SeoSayfaBaslikGuncelle = false,
                    UrunAdiGuncelle = true
                };

                // ürün dil listesini oluşturuyoruz.
                List<UrunDil> urunDilListe = new List<UrunDil>();

                // ürün dili oluşturuyoruz 
                UrunDil urunDil = new UrunDil
                {
                    // güncellenecek alanların güncellenecek değerlerini dolduruyoruz.
                    ID = 1,
                    Aciklama = "açıklama ingilizce",
                    AramaAnahtarKelime = "arama anahtar kelime ingilizce",
                    SatisBirimi = "satış birimi ingilizce",
                    UrunAdi = "ürün adi ingilizce",
                    //OnYazi="",
                    //SeoAnahtarKelime="",
                    //SeoNoFollow=true,
                    //SeoNoIndex=false,
                    //SeoSayfaAciklama="",
                    //SeoSayfaBaslik=""
                };

                // ürün dili  listeye ekliyoruz 
                urunDilListe.Add(urunDil);

                UpdateUrunDilRequest updateUrunDilRequest = new UpdateUrunDilRequest
                {
                    Ayar = urunDilAyar,
                    Dil = "en", // dil kodu
                    Liste = urunDilListe
                };

                UrunServis.WebServisResponse webServisResponse = StaticVariables.urunServisClient.UpdateUrunDil(StaticVariables.uyeKodu, updateUrunDilRequest);

                if (webServisResponse.IsError)
                    MessageBox.Show(webServisResponse.ErrorMessage);
                else
                    MessageBox.Show("Ürün dili güncellendi");

                return webServisResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static WebServisResponse UpdateKategoriDil()
        {
            try
            {
                //güncelleme yapılacak alanların ayarı 
                // burada girilmeyen veya false girilen alan güncellenmez 
                KategoriDilAyar kategoriDilAyar = new KategoriDilAyar
                {
                    IcerikGuncelle = true,
                    SeoAnahtarKelimeGuncelle = true,
                    SeoSayfaAciklamaGuncelle = true,
                    SeoSayfaBaslikGuncelle = true,
                    TanimGuncelle = true
                };

                List<KategoriDil> kategoriDilListe = new List<KategoriDil>();
                KategoriDil kategoriDil = new KategoriDil
                {
                    ID = 1,
                    Icerik = "icerik ingilizce",
                    SeoAnahtarKelime = "seo anahtar kelime ingilizce",
                    SeoSayfaAciklama = "seo sayfa açıklama ingilizce",
                    SeoSayfaBaslik = "seo sayfa başlık ingilizce",
                    Tanim = "tanım ingilizce"
                };

                kategoriDilListe.Add(kategoriDil);
                UpdateKategoriDilRequest updateKategoriDilRequest = new UpdateKategoriDilRequest
                {
                    Ayar = kategoriDilAyar,
                    Dil = "en", // dil kodu 
                    Liste = kategoriDilListe
                };

                UrunServis.WebServisResponse webServisResponse = StaticVariables.urunServisClient.UpdateKategoriDil(StaticVariables.uyeKodu, updateKategoriDilRequest);

                if (webServisResponse.IsError)
                    MessageBox.Show(webServisResponse.ErrorMessage);
                else
                    MessageBox.Show("Kategori dili güncellendi");

                return webServisResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<UrunOdemeSecenekBanka> GetTaksitSecenekleri()
        {
            try
            {
                List<UrunOdemeSecenekBanka> taksitSecenekListe = StaticVariables.urunServisClient.GetTaksitSecenekleri(StaticVariables.uyeKodu, 100, 4, "TRY");

                MessageBox.Show("Taksit seçenekleri listelendi.");

                StaticFunctions.CevapListele(taksitSecenekListe.Cast<object>().ToList(), "Taksit Seçenekleri");

                return taksitSecenekListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<ParaBirimi> SelectParaBirimi()
        {
            try
            {
                List<ParaBirimi> paraBirimiListe = StaticVariables.urunServisClient.SelectParaBirimi(StaticVariables.uyeKodu, 0);

                MessageBox.Show("Para birimleri listelendi. " + paraBirimiListe.Count + " adet kayıtlı para biriminiz bulunmaktadır.");

                StaticFunctions.CevapListele(paraBirimiListe.Cast<object>().ToList(), "Para Birimleri");

                return paraBirimiListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static int SaveParaBirimi()
        {
            try
            {
                ParaBirimi paraBirimi = new ParaBirimi
                {
                    ID = 0,//0 girilir ise yeni kayıt oluşturulur, 0 dan büyük girilirse girilen idli kayıt güncellenir.
                    Kur = 5.60,
                    DovizKodu = "USD",
                    Tanim = "Dolar",
                    Aktif = true, // aktiflik durumu eğer göndermezsek default olarak false değerini alır 
                    GuncellemeTarihi = DateTime.Now
                };

                int eklenenParaBirimiId = StaticVariables.urunServisClient.SaveParaBirimi(StaticVariables.uyeKodu, paraBirimi);

                if (eklenenParaBirimiId > 0)
                    MessageBox.Show("Para birimi  eklendi id : " + eklenenParaBirimiId);
                else
                    MessageBox.Show("Para birimi eklenemedi.");

                return eklenenParaBirimiId;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return 0;
            }

        }
        public static List<EkSecenekGrup> SelectEkSecenekGrup()
        {
            try
            {
                List<EkSecenekGrup> ekSecenekGrupListe = StaticVariables.urunServisClient.SelectEkSecenekGrup(StaticVariables.uyeKodu, "");

                MessageBox.Show("Ek seçenek gruplar listelendi. " + ekSecenekGrupListe.Count + " adet kayıtlı ek seçenek grup bulunmaktadır.");

                StaticFunctions.CevapListele(ekSecenekGrupListe.Cast<object>().ToList(), "Ek Seçenek Gruplar");

                return ekSecenekGrupListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<EkSecenekDeger> SelectEkSecenekDeger()
        {
            try
            {
                List<EkSecenekDeger> ekSecenekDegerListe = StaticVariables.urunServisClient.SelectEkSecenekDeger(StaticVariables.uyeKodu, 0, "");

                MessageBox.Show("Ek seçenek değerler listelendi. " + ekSecenekDegerListe.Count + " adet kayıtlı ek seçenek değer bulunmaktadır.");

                StaticFunctions.CevapListele(ekSecenekDegerListe.Cast<object>().ToList(), "Ek Seçenek Değerler");

                return ekSecenekDegerListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<AsortiMiktar> SelectAsortiMiktar()
        {
            try
            {
                List<AsortiMiktar> asortiMiktarListe = StaticVariables.urunServisClient.SelectAsortiMiktar(StaticVariables.uyeKodu, 0);

                MessageBox.Show("Asorti miktarlar listelendi. " + asortiMiktarListe.Count + " adet kayıtlı asorti miktar bulunmaktadır.");

                StaticFunctions.CevapListele(asortiMiktarListe.Cast<object>().ToList(), "Asorti Miktarlar");

                return asortiMiktarListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<AsortiGrup> SelectAsortiGrup()
        {
            try
            {
                List<AsortiGrup> asortiGrupListe = StaticVariables.urunServisClient.SelectAsortiGrup(StaticVariables.uyeKodu, 0);

                MessageBox.Show("Asorti gruplar listelendi. " + asortiGrupListe.Count + " adet kayıtlı asorti grubunuz bulunmaktadır.");

                StaticFunctions.CevapListele(asortiGrupListe.Cast<object>().ToList(), "Asorti Gruplar");

                return asortiGrupListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static SaveResponse SaveAsortiMiktar()
        {
            try
            {
                AsortiMiktar asortiMiktar = new AsortiMiktar
                {
                    ID = 0, //0 girilir ise yeni kayıt oluşturulur, 0 dan büyük girilirse girilen idli kayıt güncellenir.
                    Adet = 1,
                    EkSecenekTanim = "kırmızı", //  eksecenek  tanımı. Eksecenek tablosunda girilen tanımlı bir eksecenek yok ise asorti miktar eklenmez. 
                    GrupID = 3, // asorti grup ıd
                };
                // gelen cevapte işlemin ne şekilde sonuçlandığına dair bilgi verilmektedir. 
                SaveResponse SaveAsortiMiktarCevap = StaticVariables.urunServisClient.SaveAsortiMiktar(StaticVariables.uyeKodu, asortiMiktar);

                if (SaveAsortiMiktarCevap.IsError)
                    MessageBox.Show(SaveAsortiMiktarCevap.ErrorMessage);
                else
                    MessageBox.Show("Asorti miktar eklendi id: " + SaveAsortiMiktarCevap.ItemId);

                return SaveAsortiMiktarCevap;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static SaveResponse SaveAsortiGrup()
        {
            try
            {
                AsortiGrup asortiGrup = new AsortiGrup
                {
                    ID = 0, //0 girilir ise yeni kayıt oluşturulur, 0 dan büyük girilirse girilen idli kayıt güncellenir.
                    EkSecenekTipi = "Renk", //  eksecenek tipi tanımı. Eksecenek tipi tablosunda girilen tanımlı bir eksecenek yok ise asorti grup eklenmez. 
                    Tanim = "asorti grup adı"
                };
                // gelen cevapte işlemin ne şekilde sonuçlandığına dair bilgi verilmektedir. 
                SaveResponse saveAsortiGrupCevap = StaticVariables.urunServisClient.SaveAsortiGrup(StaticVariables.uyeKodu, asortiGrup);

                if (saveAsortiGrupCevap.IsError)
                    MessageBox.Show(saveAsortiGrupCevap.ErrorMessage);
                else
                    MessageBox.Show("Asorti grup eklendi id: " + saveAsortiGrupCevap.ItemId);

                return saveAsortiGrupCevap;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static void VaryasyonGuncelle()
        {
            try
            {
                Varyasyon varyasyon = new Varyasyon
                {
                    // burada varyasyonun id sini ve bilgilerini giriyoruz. Alttaki değerler örnek olarak girilimiştir id dışında hiçbir değer zorunlu değildir.diğer özellikler de değiştirilmek istenildiği şekilde girilebilir. 

                    ID = 1, // güncelleme yapılacak varyasyona ait id                 
                    AlisFiyati = 10,
                    Aktif = false,
                    Barkod = "4545645565486",
                    Desi = 1,
                    TedarikciKodu = "tedarikçi kodu",
                    StokAdedi = 1285,
                    EksiStokAdedi = 5,
                    IndirimliFiyati = 12.10,
                    KargoUcreti = 4,
                    KdvDahil = true,
                    SatisFiyati = 15,
                    Resimler = new List<string> { "resim url", "resim url 2" }
                };
                VaryasyonAyar varyasyonAyar = new VaryasyonAyar
                {
                    // varyasyonda hangi ayarların güncellenip hangilerinin güncellenmeyeceği bilgisi verilir. Hiç yazılmayan değer de false olarak kabul edilir ve güncellenmez.
                    AktifGuncelle = true,
                    AlisFiyatiGuncelle = false,
                    BarkodGuncelle = true,
                    StokAdediGuncelle = true,
                    KargoAgirligiGuncelle = false,
                    EksiStokAdediGuncelle = true,
                    ResimOlmayanlaraResimEkle = true
                };

                StaticVariables.urunServisClient.VaryasyonGuncelle(StaticVariables.uyeKodu, varyasyon, varyasyonAyar);

                MessageBox.Show("varyasyon güncellendi");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public static void SaveVaryasyon()
        {
            try
            {
                List<Varyasyon> varyasyonListe = new List<Varyasyon>();
                Varyasyon varyasyon = new Varyasyon
                {
                    // burada varyasyonun id sini ve bilgilerini giriyoruz. Alttaki değerler örnek olarak girilimiştir id dışında hiçbir değer zorunlu değildir.diğer özellikler de değiştirilmek istenildiği şekilde girilebilir. 

                    ID = 1, // güncelleme yapılacak varyasyona ait id                 
                    AlisFiyati = 10,
                    Aktif = false,
                    Barkod = "4545645565486",
                    Desi = 1,
                    TedarikciKodu = "tedarikçi kodu",
                    StokAdedi = 1285,
                    EksiStokAdedi = 5,
                    IndirimliFiyati = 12.10,
                    KargoUcreti = 4,
                    KdvDahil = true,
                    SatisFiyati = 15,
                    Resimler = new List<string> { "resim url", "resim url 2" }
                };
                varyasyonListe.Add(varyasyon);
                VaryasyonAyar varyasyonAyar = new VaryasyonAyar
                {
                    // varyasyonda hangi ayarların güncellenip hangilerinin güncellenmeyeceği bilgisi verilir. Hiç yazılmayan değer de false olarak kabul edilir ve güncellenmez.
                    StokAdediGuncelle = true,
                    //KonsinyeUrunStokAdediGuncelle = true,
                    //TahminiTeslimSuresiTarihGuncelle = true,
                    AktifGuncelle = false,
                    AlisFiyatiGuncelle = true,
                    EksiStokAdediGuncelle = false,
                    BarkodGuncelle = false,
                    EkSecenekGuncelle = true
                };
                //response = 1= başarılı , 0=başarısız
                int response = StaticVariables.urunServisClient.SaveVaryasyon(StaticVariables.uyeKodu, varyasyonListe, varyasyonAyar);

                MessageBox.Show("varyasyon eklendi.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public static int SelectVaryasyonCount()
        {
            try
            {
                VaryasyonFiltre varyasyonFiltre = new VaryasyonFiltre
                {
                    Aktif = -1, // -1 gönderilir ise bu alana göre filtleme yapılmaz 
                    Barkod = "", // boş gönderilebilir
                                 //StokGuncellemeTarihiBas = DateTime.Now, // filtrede kullanılmak istenmiyor ise yazılmamalı. 
                                 //StokGuncellemeTarihiSon = DateTime.Now, // filtrede kullanılmak istenmiyor ise yazılmamalı.
                    StokKodu = "",// boş gönderilebilir
                    UrunID = -1, // -1 gönderilir ise bu alana göre filtleme yapılmaz
                    UrunKartiID = -1 // -1 gönderilir ise bu alana göre filtreleme yapılmaz.
                };

                int filtrelereGoreVaryasyonSayisi = StaticVariables.urunServisClient.SelectVaryasyonCount(StaticVariables.uyeKodu, varyasyonFiltre);

                MessageBox.Show("Filtrelere göre bulunan varyasyon sayısı: " + filtrelereGoreVaryasyonSayisi);

                return filtrelereGoreVaryasyonSayisi;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return 0;
            }
        }
        public static List<Varyasyon> SelectVaryasyon()
        {
            try
            {
                VaryasyonFiltre varyasyonFiltre = new VaryasyonFiltre
                {
                    Aktif = -1,
                    Barkod = "", // boş gönderilebilir
                    //StokGuncellemeTarihiBas = new DateTime(2018,12,05), // filtrede kullanılmak istenmiyor ise yazılmamalı. 
                    //StokGuncellemeTarihiSon = DateTime.Now, // filtrede kullanılmak istenmiyor ise yazılmamalı.
                    StokKodu = "",// boş gönderilebilir
                    UrunID = -1, // -1 gönderilir ise bu alana göre filtleme yapılmaz
                    UrunKartiID = -1 // -1 gönderilir ise bu alana göre filtreleme yapılmaz.
                };

                UrunSayfalama urunSayfalama = new UrunSayfalama
                {
                    BaslangicIndex = 0, // bulunan kayıtların baslangıç index i  - zorunlu değil 
                    KayitSayisi = 100, // kaç kayıt getireleceği bilgisi, - zorunlu değil girilmez ise bulunan tüm kayıtlar gösterilir.
                    SiralamaDegeri = "id", // kayıtların hangi alana göre sıralanacağı - zorunlu değil 
                    SiralamaYonu = "Desc" // zorunlu değil 
                };
                SelectVaryasyonAyar selectVaryasyonAyar = new SelectVaryasyonAyar { KategoriGetir = true };
                List<Varyasyon> varyasyonListe = StaticVariables.urunServisClient.SelectVaryasyon(StaticVariables.uyeKodu, varyasyonFiltre, urunSayfalama, selectVaryasyonAyar);

                MessageBox.Show("Varyasyonlar listelendi.");

                StaticFunctions.CevapListele(varyasyonListe.Cast<object>().ToList(), "Varyasyonlar");

                return varyasyonListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<Etiket> SelectEtiket()
        {
            try
            {
                //List<Etiket> etiketListe = StaticVariables.urunServisClient.SelectEtiket(StaticVariables.uyeKodu, 0);

                //MessageBox.Show("Etiketler listelendi. " + etiketListe.Count + "adet kayıtlı etiketiniz bulunmaktadır.");
                MessageBox.Show("Etiketler listelendi. " + StaticVariables.etiketList.Count + " adet kayıtlı etiketiniz bulunmaktadır.");

                StaticFunctions.CevapListele(StaticVariables.etiketList.Cast<object>().ToList(), "Etiketler");

                return StaticVariables.etiketList;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static int SaveEtiket()
        {
            try
            {
                Etiket etiket = new Etiket
                {
                    ID = 0,//0 girilir ise yeni kayıt oluşturulur, 0 dan büyük girilirse girilen idli kayıt güncellenir.
                    Resim = "", // etiket resmi - boş gönderilebilir.
                    SeoAnahtarKelime = "giysi giyim", // SEO optimizasyonu için kullanılan kelimeler
                    SeoSayfaAciklama = "Açıklama", // SEO optimizasyonu için kullanılan açıklama
                    SeoSayfaBaslik = "Başlık", // SEO optimizasyonu için kullanılan sayfa başlığı
                    Tanim = "etiket adı",
                    Url = "etiket url" // boş gönderilebilir.

                };
                int eklenenEtiketId = StaticVariables.urunServisClient.SaveEtiket(StaticVariables.uyeKodu, etiket);

                if (eklenenEtiketId > 0)
                    MessageBox.Show("Etiket eklendi id: " + eklenenEtiketId);
                else
                    MessageBox.Show("Etiket eklenemedi eklenemedi.");

                return eklenenEtiketId;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return 0;
            }
        }
        public static List<TeknikDetayOzellik> SelectTeknikDetayOzellik()
        {
            try
            {
                List<TeknikDetayOzellik> teknikDetayOzellikListe = StaticVariables.urunServisClient.SelectTeknikDetayOzellik(StaticVariables.uyeKodu, 0, "");

                MessageBox.Show("Teknik detay özellikler listelendi. " + teknikDetayOzellikListe.Count + " adet kayıtlı teknik detay özelliğiniz bulunmaktadır.");

                StaticFunctions.CevapListele(teknikDetayOzellikListe.Cast<object>().ToList(), "Teknik Detay Özellikler");

                return teknikDetayOzellikListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<TeknikDetayGrup> SelectTeknikDetayGrup()
        {
            try
            {
                List<TeknikDetayGrup> teknikDetayGrupListe = StaticVariables.urunServisClient.SelectTeknikDetayGrup(StaticVariables.uyeKodu, 0, "");

                MessageBox.Show("Teknik detay gruplar listelendi. " + teknikDetayGrupListe.Count + " adet kayıtlı teknik detay grubunuz bulunmaktadır.");

                StaticFunctions.CevapListele(teknikDetayGrupListe.Cast<object>().ToList(), "Teknik Detay Gruplar");

                return teknikDetayGrupListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<TeknikDetayDeger> SelectTeknikDetayDeger()
        {
            try
            {
                List<TeknikDetayDeger> teknikDetayDegerListe = StaticVariables.urunServisClient.SelectTeknikDetayDeger(StaticVariables.uyeKodu, 0, "");

                MessageBox.Show("Teknik detay değerler listelendi. " + teknikDetayDegerListe.Count + " adet kayıtlı teknik detay değeriniz bulunmaktadır.");

                StaticFunctions.CevapListele(teknikDetayDegerListe.Cast<object>().ToList(), "Teknik Detay Değerler");

                return teknikDetayDegerListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static int SaveTeknikDetayOzellik()
        {
            try
            {
                TeknikDetayOzellik teknikDetayOzellik = new TeknikDetayOzellik
                {
                    GrupID = 1,
                    ID = 0, //0 girilir ise yeni kayıt oluşturulur, 0 dan büyük girilirse girilen idli kayıt güncellenir.
                    Sira = 5,
                    Tanim = "özellik tanım"
                };
                int eklenenTeknikDetayOzellikId = StaticVariables.urunServisClient.SaveTeknikDetayOzellik(StaticVariables.uyeKodu, teknikDetayOzellik);

                if (eklenenTeknikDetayOzellikId > 0)
                    MessageBox.Show("Teknik detay özellik eklendi id: " + eklenenTeknikDetayOzellikId);
                else
                    MessageBox.Show("Teknik detay özellik eklenemedi.");

                return eklenenTeknikDetayOzellikId;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return 0;
            }
        }
        public static int SaveTeknikDetayGrup()
        {
            try
            {
                TeknikDetayGrup teknikDetayGrup = new TeknikDetayGrup
                {
                    ID = 0, //0 girilir ise yeni kayıt oluşturulur, 0 dan büyük girilirse girilen idli kayıt güncellenir.
                    Sira = 2,
                    Tanim = "Teknik detay grup ismi"
                };

                int eklenenTeknikDetayGrupId = StaticVariables.urunServisClient.SaveTeknikDetayGrup(StaticVariables.uyeKodu, teknikDetayGrup);

                if (eklenenTeknikDetayGrupId > 0)
                    MessageBox.Show("Teknik detay grup eklendi id: " + eklenenTeknikDetayGrupId);
                else
                    MessageBox.Show("Teknik detay grup eklenemedi.");

                return eklenenTeknikDetayGrupId;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return 0;
            }
        }
        public static int SaveTeknikDetayDeger()
        {
            try
            {
                TeknikDetayDeger teknikDetayDeger = new TeknikDetayDeger
                {
                    ID = 0, //0 girilir ise yeni kayıt oluşturulur, 0 dan büyük girilirse girilen idli kayıt güncellenir. 
                    OzellikID = 1, // Ozellik id değeri. 
                    Tanim = "Teknik detay 1",
                    Sira = 1
                };

                int eklenenTeknikDetayId = StaticVariables.urunServisClient.SaveTeknikDetayDeger(StaticVariables.uyeKodu, teknikDetayDeger);

                if (eklenenTeknikDetayId > 0)
                    MessageBox.Show("Teknik detay değer eklendi id: " + eklenenTeknikDetayId);
                else
                    MessageBox.Show("Teknik detay değer eklenemedi.");

                return eklenenTeknikDetayId;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return 0;
            }
        }
        public static List<UrunKategori> SelectUrunKategori()
        {
            try
            {
                // ürün kartı Id ve ürün kategori id 0 gönderilir ise tüm ürün ve kategori eşleşmeleri getirilir.
                // Eğer ürün karti id 0 dan büyük kategori id 0 olarak gönderilir ise girilen ürün kartı id yi içeren tüm kayıtlar getirilir. 
                // Eğer kategori id 0 dan büyük ürün kartı id 0 gönderilir ise girilen kategori id yi içeren tüm kayıtlar getirilir.

                List<UrunKategori> urunKategori = StaticVariables.urunServisClient.SelectUrunKategori(StaticVariables.uyeKodu, 322, 0);

                MessageBox.Show("Ürün kategoriler listelendi. " + urunKategori.Count + " adet ürün kategori kaydınız bulunmaktadır.");

                StaticFunctions.CevapListele(urunKategori.Cast<object>().ToList(), "Ürün Kategorileri");

                return urunKategori;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<UrunYorum> SelectUrunYorum()
        {
            try
            {
                List<UrunYorum> urunyorumListe = StaticVariables.urunServisClient.SelectUrunYorum(StaticVariables.uyeKodu, -1);

                MessageBox.Show(urunyorumListe.Count + " adet yorum bulundu.");

                StaticFunctions.CevapListele(urunyorumListe.Cast<object>().ToList(), "Ürün Yorumları");

                return urunyorumListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<UrunOdemeSecenek> SelectUrunOdemeSecenek()
        {
            try
            {


                List<UrunOdemeSecenek> urunOdemeSecenekListe = StaticVariables.urunServisClient.SelectUrunOdemeSecenek(StaticVariables.uyeKodu, 0);

                MessageBox.Show(urunOdemeSecenekListe.Count + " adet ödeme seçenek bulundu.");

                StaticFunctions.CevapListele(urunOdemeSecenekListe.Cast<object>().ToList(), "Ürün Ödeme Seçenekleri");

                return urunOdemeSecenekListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static int SelectUrunCount()
        {
            try
            {
                // Ürün çekme
                // Filtre değerleri :
                // -1 : Filtre yok
                // 0 : false
                // 1 : true
                // Bu değerler 'Aktif','Firsat','indirimli' ve 'Vitrin' için geçerlidir.

                UrunFiltre urunFiltre = new UrunFiltre
                {
                    Aktif = -1,
                    Firsat = -1,
                    Indirimli = -1,
                    Vitrin = -1,
                    KategoriID = 0, // 0 gönderilirse filtre yapılmaz.
                    MarkaID = 0, // 0 gönderilirse filtre yapılmaz.
                    UrunKartiID = 0, //0 gönderilirse filtre yapılmaz.                                  
                                     //Barkod="1564654812", //barkod girilirse sadece o barkodlu ürün gelir. 
                                     //ToplamStokAdediBas = 0,
                                     //ToplamStokAdediSon = 500,
                    TedarikciID = 0, // 0 gönderilirse filtre yapılmaz
                };

                int urunSayisi = StaticVariables.urunServisClient.SelectUrunCount(StaticVariables.uyeKodu, urunFiltre);

                MessageBox.Show("Filtrelere göre bulunan ürün sayısı: " + urunSayisi);

                return urunSayisi;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return 0;
            }
        }
        public static void SaveUrun()
        {
            try
            {
                // Ürün Ekleme
                // Ürünün ait olduğu kategori idleri
                List<int> kategoriIDS = new List<int>();
                kategoriIDS.Add(StaticVariables.kategoriList[0].ID); //Kategorilerdeki ilk eleman.
                //kategoriIDS.Add(1);  // 1 id li bir kategori yoksa ürün eklerken hata alınır.         
                // Ürünün resim linkleri
                List<string> resimLinkleri = new List<string>();
                resimLinkleri.Add("http://www.siteniz.com/resim1.png");
                resimLinkleri.Add("http://www.siteniz.com/resim2.png");
                // Ürün varyasyon özelliklerini belirleme
                List<UrunServis.VaryasyonOzellik> ozellikler = new List<UrunServis.VaryasyonOzellik>();
                ozellikler.Add(new UrunServis.VaryasyonOzellik { Tanim = "Numara", Deger = "38" });
                ozellikler.Add(new UrunServis.VaryasyonOzellik { Tanim = "Renk", Deger = "Mavi" });
                // Ürün varyasyon resim linkleri
                List<string> varyasyonResimler = new List<string>();
                varyasyonResimler.Add("http://www.siteniz.com/varyasyonluResim.png");
                varyasyonResimler.Add("http://www.siteniz.com/varyasyonluResim2.png");
                varyasyonResimler.Add("http://www.siteniz.com/varyasyonluResim3.png");

                ////Urun Kartı etiket listeleri
                //List<UrunKartiEtiket> urunKartiEtiketListe = new List<UrunKartiEtiket> { new UrunKartiEtiket { EtiketID = 1 } }; // 1 id li bir etiket yoksa ürün eklerken hata alınır.  

                //// urun kartı teknik detay liste 
                //List<UrunKartiTeknikDetay> urunKartiTeknikDetayListe = new List<UrunKartiTeknikDetay>
                //{
                //    new UrunKartiTeknikDetay{ DegerID=1 , OzellikID = 1 }
                //};

                // Ürün varyasyonlarını belirleme. En az bir varyasyon zorunludur!
                // * işaretli alanlar zorunlu alanlardır. 
                UrunServis.Varyasyon varyasyon = new UrunServis.Varyasyon
                {
                    ID = 0, //* 0 ise yeni varyasyon ekler, sıfırdan büyük ise o id'ye sahip olan varyasyonu günceller
                    AlisFiyati = 10,
                    Barkod = "BARKOD",
                    Desi = 1,
                    KargoUcreti = 5.15,
                    KdvDahil = false,
                    KdvOrani = 18,
                    Ozellikler = ozellikler,
                    ParaBirimiID = 1, // * sitede yer alan para birimlerinde birini girmesi gerekir. 
                    Resimler = varyasyonResimler,
                    SatisFiyati = 100, // * 
                    StokAdedi = 15,
                    StokKodu = "KOD",
                    Aktif = true,
                    //DuzenleyenKullanici = 1, // düzenleyen kullanıcı id 
                    //EkleyenKullanici = 1,// ekleyen kullanıcı id 
                    EksiStokAdedi = 10, // ayrılacak olan stok adedi - zorunlu değil 
                    IndirimliFiyati = 12,
                    //ParaBirimi = "TL", // parabirimi id girildiyse doldurulmasına gerek yok 
                    //ParaBirimiKodu = "TRY", // parabirimi id girildiyse doldurulmasına gerek yok. 
                    TedarikciKodu = "5645616846|beden|38", // tedarikçi koduna göre güncelle true ise zorunlu
                    // uye tiplerine göre fiyatlandırmalar - zorunlu değil  
                    UyeTipiFiyat1 = 12,
                    UyeTipiFiyat2 = 45,
                    UyeTipiFiyat3 = 45,
                    UyeTipiFiyat4 = 87,
                    UyeTipiFiyat5 = 85,

                    SatisFiyati1 = 11,
                    SatisFiyati2 = 12,
                    SatisFiyati3 = 13,
                    SatisFiyati4 = 14,
                    SatisFiyati5 = 15,
                    SatisFiyati6 = 16,
                    SatisFiyati7 = 17,
                    SatisFiyati8 = 18,
                    SatisFiyati9 = 19,
                    //SatisFiyati10 = 21,
                    SatisFiyati11 = 21,
                    SatisFiyati12 = 22,
                    SatisFiyati13 = 23,
                    SatisFiyati14 = 24,
                    SatisFiyati15 = 25,
                    SatisFiyati16 = 26,
                    SatisFiyati17 = 27,
                    SatisFiyati18 = 28,
                    SatisFiyati19 = 29,
                    SatisFiyati20 = 30,
                };

                List<UrunServis.Varyasyon> varyasyonlar = new List<UrunServis.Varyasyon>();
                varyasyonlar.Add(varyasyon);
                // Ürün Kartı alanları. "*" işaretli alanlar zorunludur.
                UrunServis.UrunKarti urunKarti = new UrunServis.UrunKarti
                {
                    ID = 0, // 0 ise yeni ürünkartı ekler, sıfırdan büyük ise o id'ye sahip olan ürünkartını
                            // günceller.
                    Aktif = true, // *
                    UrunAdi = "Ürün Adı", // *
                    Aciklama = "Açıklama", // *
                    AnaKategori = "Ana Kategori adı", // * Breadcrumbs da kullanılacak
                    AnaKategoriID = 1, // * Breadcrumbs da kullanılacak - zorunlu 0 olursa ürün görünmez. 
                    Kategoriler = kategoriIDS, // *
                    MarkaID = StaticVariables.markaList[0].ID, //ilk markanın ID'si. 
                    //MarkaID = 1, // *  1 idli bir marka olmazsa hata alınır.
                    TedarikciID = StaticVariables.tedarikciList[0].ID, //ilk tedarikcinin ID'si. 
                    //TedarikciID = 1, // * 1 idli bir tedarikçi olmazsa hata alınır. 
                    Resimler = resimLinkleri, // *
                    SatisBirimi = "Adet", // *
                    UcretsizKargo = true, // *
                    OnYazi = "Önyazı",
                    SeoAnahtarKelime = "kelime kelime2",
                    SeoSayfaAciklama = "Açıklama",
                    SeoSayfaBaslik = "Başlık",
                    Varyasyonlar = varyasyonlar, // *
                    Vitrin = true,
                    YeniUrun = true,

                    AdwordsAciklama = "adwors aciklama", // xml deki aciklama - zorunlu değil 
                    AdwordsKategori = "adwors Kategori", // xml deki kategori - zorunlu değil
                    AdwordsTip = "adwors tip", // xml deki tip - zorunlu değil 
                    AramaAnahtarKelime = "Arama anahtar kelime", // sitede arama yaparken kullanılacak anahtar kelimeler
                                                                 //AsortiGrupID = 2, // urunun asorti grubu - zorunlu değil 
                                                                 //DuzenleyenKullanici = 1, // düzenleyen kullanıcı id - zorunlu değil
                                                                 //EkleyenKullanici = 1, // ekleyen kullanıcı id - zorunlu değil
                                                                 //EntegrasyonID = "4",
                    FBStoreGoster = true, // ürünün facebook store da gösterilme durumu 
                    FirsatUrunu = true, // ürünün fırsat ürünü olma durumu 
                    IndirimliFiyatOzellik = 0, // Bu alanda 3 farklı değer girebiliyoruz  0 = devamlı indirim, 1 = stok adedine göre indirim(1 olduğu zaman IndirimliFiyatOzellikStok1 ve IndirimliFiyatOzellikStok2 alanlarının doldurulması zorunludur bu iki stok adedi arasındayken indirim geçerli olur) , 2 = Tarihe Göre indirim (2 olduğu zaman       IndirimliFiyatOzellikTarih1 ve IndirimliFiyatOzellikTarih2 alanları doldurulması zorunludur. Bu iki tarih aralığında indirim geçerli olur.)    
                    IndirimliFiyatOzellikStok1 = 21,
                    IndirimliFiyatOzellikStok2 = 23,
                    IndirimliFiyatOzellikTarih1 = new DateTime(2018, 11, 05),
                    IndirimliFiyatOzellikTarih2 = new DateTime(2018, 12, 06),
                    MaksTaksitSayisi = 4,
                    OzelAlan1 = "", // eklenecek extra özellikleri temsil eder
                    OzelAlan2 = "",
                    OzelAlan3 = "",
                    OzelAlan4 = "",
                    OzelAlan5 = "",
                    SeoNoFollow = true, //
                    SeoNoIndex = false,
                    TahminiTeslimSuresi = 1, // ürünün tahmini teslim süresi 
                    TedarikciKodu = "5645616846", //* zorunlu tekil anahtar şeklinde olması gerekiyor.
                    TeknikDetayGrupID = 1, // teknik detay grup id si zorunlu değil
                    UrunSayfaAdresi = "", // ürün url i 
                    UyeAlimMax = 15, //bir üyenin en fazla kaç ürün alabileceği 
                    UyeAlimMin = 1, // bir üyenin en az kaç ürün alabileceği 
                                    //Etiketler = new List<UrunKartiEtiket>(), // zorunlu değil 
                                    //TeknikDetaylar = new List<UrunKartiTeknikDetay>() // zorunlu değil 



                };
                // Ürün Kartını listeye ekleme
                List<UrunServis.UrunKarti> urunKartlari = new List<UrunServis.UrunKarti>();
                urunKartlari.Add(urunKarti);

                // Ürün Kartı ayarları.
                UrunServis.UrunKartiAyar urunKartiAyar = new UrunServis.UrunKartiAyar
                {
                    AciklamaGuncelle = true,
                    AktifGuncelle = true,
                    FBStoreGosterGuncelle = false,
                    FirsatUrunuGuncelle = true,
                    KategoriGuncelle = false,
                    MaksTaksitSayisiGuncelle = false,
                    MarkaGuncelle = false,
                    OnYaziGuncelle = false,
                    ParaPuanGuncelle = true,
                    SatisBirimiGuncelle = false,
                    SeoAnahtarKelimeGuncelle = false,
                    SeoSayfaAciklamaGuncelle = false,
                    SeoSayfaBaslikGuncelle = false,
                    TedarikciGuncelle = false,
                    UcretsizKargoGuncelle = true,
                    UrunAdiGuncelle = true,
                    UrunResimGuncelle = false,
                    VitrinGuncelle = false,
                    YeniUrunGuncelle = true,
                    AdwordsAciklamaGuncelle = true,
                    AdwordsKategoriGuncelle = false,
                    AdwordsTipGuncelle = true,
                    UserAgent = "", // boş gönderilebilir .
                    AramaAnahtarKelimeGuncelle = true,
                    AsortiGrupGuncelle = true,
                    Base64Resim = false,
                    EtiketGuncelle = true,
                    KargoTipiGuncelle = true,
                    OncekiKategoriEslestirmeleriniTemizle = false,
                    OncekiResimleriSil = false,
                    OzelAlan1Guncelle = true,
                    OzelAlan2Guncelle = true,
                    OzelAlan3Guncelle = true,
                    OzelAlan4Guncelle = true,
                    OzelAlan5Guncelle = true,
                    ResimleriIndirme = false,
                    ResimOlmayanlaraResimEkle = true,
                    SeoNoFollowGuncelle = false,
                    SeoNoIndexGuncelle = false,
                    TahminiTeslimSuresiGuncelle = true,
                    TedarikciKodunaGoreGuncelle = false,
                    TeknikDetayGuncelle = false,
                    UrunAdresiniElleOlustur = false,
                    UyeAlimMaksGuncelle = false,
                    UyeAlimMinGuncelle = false


                };
                // Varyasyon ayarları.
                UrunServis.VaryasyonAyar urunVaryasyonAyar = new UrunServis.VaryasyonAyar
                {

                    AktifGuncelle = false,
                    AlisFiyatiGuncelle = true,
                    BarkodGuncelle = false,
                    IndirimliFiyatiGuncelle = true,
                    KargoUcretiGuncelle = false,
                    KargoAgirligiGuncelle = true,
                    ParaBirimiGuncelle = false,
                    SatisFiyatiGuncelle = false,
                    StokAdediGuncelle = true,
                    UyeTipiFiyat1Guncelle = false,
                    UyeTipiFiyat2Guncelle = true,
                    UyeTipiFiyat3Guncelle = false,
                    UyeTipiFiyat4Guncelle = true,
                    UyeTipiFiyat5Guncelle = false,
                    EksiStokAdediGuncelle = true,
                    KdvDahilGuncelle = false,
                    KdvOraniGuncelle = true,
                    OncekiResimleriSil = false,
                    ResimOlmayanlaraResimEkle = true,
                    StokKoduGuncelle = true,
                    UrunResimGuncelle = true,

                };
                // Ürünü ekliyoruz
                //  eklenen ürün id leri referans olarak gönderilen urunKartlari listesinde dolu olarak gelir. 
                StaticVariables.urunServisClient.SaveUrun(StaticVariables.uyeKodu, ref urunKartlari, urunKartiAyar, urunVaryasyonAyar);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public static List<UrunKarti> SelectUrun()
        {
            try
            {
                // Ürün çekme
                // Filtre değerleri :
                // -1 : Filtre yok
                // 0 : false
                // 1 : true
                // Bu değerler 'Aktif','Firsat','indirimli' ve 'Vitrin' için geçerlidir.

                UrunFiltre urunFiltre = new UrunFiltre
                {
                    Aktif = -1,
                    Firsat = -1,
                    Indirimli = -1,
                    Vitrin = -1,
                    KategoriID = 0, // 0 gönderilirse filtre yapılmaz.
                    MarkaID = 0, // 0 gönderilirse filtre yapılmaz.
                    UrunKartiID = 0, //0 gönderilirse filtre yapılmaz.                                   
                                     //Barkod="1564654812", //barkod girilirse sadece o barkodlu ürün gelir. 
                                     //ToplamStokAdediBas = 0,
                                     //ToplamStokAdediSon = 500,
                    TedarikciID = 0, // 0 gönderilirse filtre yapılmaz
                };
                UrunSayfalama urunSayfalama = new UrunSayfalama
                {
                    BaslangicIndex = 0, // Başlangıç değeri
                    KayitSayisi = 100, // Bir sayfada görüntülenecek ürün sayısı
                    SiralamaDegeri = "ID", // Hangi sütuna göre sıralanacağı
                    SiralamaYonu = "ASC", // Artan "ASC", azalan "DESC"                
                };

                List<UrunKarti> FiltrelenenUrunKartiListe = StaticVariables.urunServisClient.SelectUrun(StaticVariables.uyeKodu, urunFiltre, urunSayfalama);

                MessageBox.Show("Ürünler listelendi.");

                StaticFunctions.CevapListele(FiltrelenenUrunKartiListe.Cast<object>().ToList(), "Ürünler");

                return FiltrelenenUrunKartiListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<Tedarikci> SelectTedarikci()
        {
            try
            {
                //List<Tedarikci> tedarikciListe = new List<Tedarikci>();

                // TedarikciID değeri 0 gönderilirse tüm tedarikçilerin listesi gelir.
                //tedarikciListe = StaticVariables.urunServisClient.SelectTedarikci(StaticVariables.uyeKodu, 0);

                //// TedarikciID değeri 0 da büyük gönderilirse id si verilen tedarikçi gelir.
                //tedarikciListe = StaticVariables.urunServisClient.SelectTedarikci(StaticVariables.uyeKodu, 5);

                //MessageBox.Show("Tedarikçiler listelendi. " + tedarikciListe.Count + " adet kayıtlı tedarikçiniz bulunmaktadır.");
                MessageBox.Show("Tedarikçiler listelendi. " + StaticVariables.tedarikciList.Count + " adet kayıtlı tedarikçiniz bulunmaktadır.");

                StaticFunctions.CevapListele(StaticVariables.tedarikciList.Cast<object>().ToList(), "Tedarikçiler");

                return StaticVariables.tedarikciList;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static int SaveTedarikci()
        {
            try
            {
                Tedarikci tedarikci = new Tedarikci
                {
                    Aktif = true,
                    ID = 0,//id 0 gönderilir ise yeni tedarikçi ekler 0 dan büyük gönderilirse gönderilen id li tedarikçi güncellenir.
                    Mail = "Tedarikçi Mail",
                    Not = "",
                    Tanim = "Tedarikçi adi"
                };
                int eklenenTedarikciId = StaticVariables.urunServisClient.SaveTedarikci(StaticVariables.uyeKodu, tedarikci);

                if (eklenenTedarikciId > 0)
                    MessageBox.Show("Tedarikçi eklendi id: " + eklenenTedarikciId);
                else
                    MessageBox.Show("Tedarikçi eklenemedi.");

                return eklenenTedarikciId;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return 0;
            }
        }
        public static List<Marka> SelectMarka()
        {
            try
            {
                //List<Marka> markaListe = new List<Marka>();

                // eğer markaID değeri 0 gönderilir ise cevap olarak tüm markaların listesi gelir.
                //markaListe = StaticVariables.urunServisClient.SelectMarka(StaticVariables.uyeKodu, 0);

                //// eğer markaID değeri 0 dan büyük gönderilir ise id si girilen marka gelir. 
                //markaListe = StaticVariables.urunServisClient.SelectMarka(StaticVariables.uyeKodu, 3);

                //MessageBox.Show("Markalar listelendi. " + markaListe.Count + " adet kayıtlı markanız bulunmaktadır.");
                MessageBox.Show("Markalar listelendi. " + StaticVariables.markaList.Count + " adet kayıtlı markanız bulunmaktadır.");

                StaticFunctions.CevapListele(StaticVariables.markaList.Cast<object>().ToList(), "Markalar");

                return StaticVariables.markaList;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static int SaveMarka()
        {
            try
            {
                Marka marka = new Marka
                {
                    Aktif = true,
                    ID = 0, //id 0 gönderilir ise yeni marka ekler 0 dan büyük gönderilirse gönderilen id li marka güncellenir.
                    SeoAnahtarKelime = "Anahtar kelime",
                    SeoSayfaAciklama = "Sayfa Aciklama ",
                    SeoSayfaBaslik = "Sayfa baslik",
                    Tanim = "Marka Adi"
                };
                int eklenenMarkaId = StaticVariables.urunServisClient.SaveMarka(StaticVariables.uyeKodu, marka);

                if (eklenenMarkaId > 0)
                    MessageBox.Show("Marka eklendi id: " + eklenenMarkaId);

                return eklenenMarkaId;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return 0;
            }
        }
        public static UpdateUrlResponse UpdateUrl()
        {
            try
            {
                UpdateUrlRequest updateUrlRequest = new UpdateUrlRequest()
                {
                    Tip = UrlType.Kategori, // hangi tipte url i güncellenecekse onu giriyoruz.
                    ID = 1,
                    Dil = "en", // dil değeri boş gönderilir ise türkçe olarak kaydolur.
                    Url = "/Giyim" //  url değeri
                };

                UpdateUrlResponse updateUrlResponse = StaticVariables.urunServisClient.UpdateUrl(StaticVariables.uyeKodu, updateUrlRequest);

                if (updateUrlResponse.IsError)
                    MessageBox.Show(updateUrlResponse.ErrorMessage);
                else
                    MessageBox.Show("Url güncellendi");

                return updateUrlResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static void SaveResim()
        {
            try
            {
                UrunKarti urunKarti = new UrunKarti()
                {
                    TedarikciKodu = "tedarikçi kodu", // resim eklenecek ürünün tedarikçi kodu 
                    ID = 1, // resim eklenecek ürün kartının id değeri
                    TedarikciID = 1 // veritabanında kayıtlı tedarikçi id değeri. 
                };

                List<string> resimler = new List<string>(); // eklenecek olan resimlerin listesi 
                resimler.Add("resim1 url");
                resimler.Add("resim2 url");

                urunKarti.Resimler = resimler;
                List<UrunKarti> urunKartiListesi = new List<UrunKarti>();
                urunKartiListesi.Add(urunKarti);

                StaticVariables.urunServisClient.SaveResim(StaticVariables.uyeKodu, urunKartiListesi, StaticVariables.alanAdi, "");

                MessageBox.Show("Resim eklendi");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public static WebServisResponse DeleteTedarikci()
        {
            try
            {
                UrunServis.WebServisResponse webServisResponse = StaticVariables.urunServisClient.DeleteTedarikci(StaticVariables.uyeKodu, 1);
                // webServisResponse da işlemin ne şekilde sonuçlandığına dair bilgi döndürülüyor.

                if (webServisResponse.IsError)
                    MessageBox.Show(webServisResponse.ErrorMessage);
                else
                    MessageBox.Show("Tedarikçi silindi");

                return webServisResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static WebServisResponse DeleteMarka()
        {
            try
            {
                UrunServis.WebServisResponse webServisResponse = StaticVariables.urunServisClient.DeleteMarka(StaticVariables.uyeKodu, 1);
                // Serviscevap ta işlemin ne şekilde sonuçlandığına dair bilgi döndürülüyor.

                if (webServisResponse.IsError)
                    MessageBox.Show(webServisResponse.ErrorMessage);
                else
                    MessageBox.Show("Kategori silindi");

                return webServisResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static WebServisResponse DeleteKategori()
        {
            try
            {
                UrunServis.WebServisResponse webServisResponse = StaticVariables.urunServisClient.DeleteKategori(StaticVariables.uyeKodu, 1);

                if (webServisResponse.IsError)
                    MessageBox.Show(webServisResponse.ErrorMessage);
                else
                    MessageBox.Show("kategori silindi");

                return webServisResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static SaveMagazaStokResponse SaveMagazaStok()
        {
            try
            {
                List<WebMagazaStok> webMagazaStokList = new List<WebMagazaStok>();
                WebMagazaStok webMagazaStok = new WebMagazaStok
                {
                    EksiStokAdedi = 5, // mağazanın ayırmak istediği stok adedi 
                    MagazaKodu = "tici",
                    StokAdedi = 10, // mağazaya eklenecek stok adedi 
                    TedarikciKodu = "EXCEL|1", // ürüne ait tedarik
                    UrunID = 1, // kayıtlı ürün id değeri 
                    UrunKartiID = 1  // kayıtlı ürünün ürün  kartı id değeri 
                };
                webMagazaStokList.Add(webMagazaStok);
                SaveMagazaStokRequest saveMagazaStokRequest = new SaveMagazaStokRequest();
                saveMagazaStokRequest.MagazaStokList = webMagazaStokList;



                SaveMagazaStokResponse saveMagazaStokResponse = StaticVariables.urunServisClient.SaveMagazaStok(StaticVariables.uyeKodu, saveMagazaStokRequest);

                if (saveMagazaStokResponse.IsError)
                    MessageBox.Show(saveMagazaStokResponse.ErrorMessage);
                else
                    MessageBox.Show("Mağaza stok eklendi.");

                return saveMagazaStokResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<SiparisUrunDurumlari> GetProductStatus()
        {
            try
            {
                // Sipariş durumları listesini getirir. Parametre göndermeye gerek yoktur. 
                List<UrunServis.SiparisUrunDurumlari> siparisUrunDurumlariListe = StaticVariables.urunServisClient.GetProductStatus(StaticVariables.uyeKodu);

                MessageBox.Show("Sipariş ürün durumları listelendi. " + siparisUrunDurumlariListe.Count + "adet sipariş ürün durumunuz bulunmaktadır.");

                StaticFunctions.CevapListele(siparisUrunDurumlariListe.Cast<object>().ToList(), "Sipariş Ürün Durumları");

                return siparisUrunDurumlariListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<Kategori> SelectKategori()
        {
            try
            {
                // Kategori Id 0 olarak gönderilirse tüm kategorileri gönderir. 0 dan büyük gönderilirse id si girilen kategoriyi geri döndürür.
                //Dil boş gönderilir ise kategoriler türkçe olarak döner.
                // Eğer sitede dil seçeneği aktif ise dil parametresi ile kategoriyi farklı dillerde getirebilirsiniz. 
                //List<Kategori> kategoriListe;
                // tüm kategorileri getirmek için
                //kategoriListe = StaticVariables.urunServisClient.SelectKategori(StaticVariables.uyeKodu, 0, "");
                MessageBox.Show("Kategoriler listelendi. " + StaticVariables.kategoriList.Count + " adet kayıtlı kategoriniz bulunmaktadır.");
                //// 10 id li kategoriyi getirmek için
                //kategoriListe = StaticVariables.urunServisClient.SelectKategori(StaticVariables.uyeKodu, 10, "");

                //// 10 id li kategoriyi ingilizce olarak getirmek için (Bunun için sitenizin dil özelliği aktif olmalı) 
                //kategoriListe = StaticVariables.urunServisClient.SelectKategori(StaticVariables.uyeKodu, 10, "En");

                StaticFunctions.CevapListele(StaticVariables.kategoriList.Cast<object>().ToList(), "Kategoriler");

                return StaticVariables.kategoriList;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static void SaveKategoriParent()
        {
            try
            {
                StaticVariables.urunServisClient.SaveKategoriParent(StaticVariables.uyeKodu, 2, 1);
                MessageBox.Show("Kategori parent eklendi.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public static int SaveKategori()
        {
            try
            {
                Kategori kategori = new Kategori
                {
                    ID = 0, // 0 ise yeni kategori ekler, 0 dan farkli ise o id'ye sahip kategoriyi günceller.
                    PID = 0, // Üst kategori id si. Ekleyeceğiniz kategorinin üst kategorisi yoksa 0 değerini gönderiniz.
                    Aktif = true,
                    Tanim = "Giyim", //Kategori adı
                    Kod = "GYM", // Kategori kodu
                    SeoAnahtarKelime = "giysi giyim", // SEO optimizasyonu için kullanılan kelimeler
                    SeoSayfaAciklama = "Açıklama", // SEO optimizasyonu için kullanılan açıklama
                    SeoSayfaBaslik = "Başlık", // SEO optimizasyonu için kullanılan sayfa başlığı
                    Icerik = "içerik", // html içerik alanı
                    Sira = 1, // kategorinin sıralamadaki yeri
                    Url = "" // kategori link i 
                };

                // Servisten cevap olarak eklediğimiz kategorinin id si döndürülüyor. 
                int eklenenKategoriId = StaticVariables.urunServisClient.SaveKategori(StaticVariables.uyeKodu, kategori);

                if (eklenenKategoriId > 0)
                    MessageBox.Show("Kategori eklendi id: " + eklenenKategoriId);
                else
                    MessageBox.Show("Kategori eklenemedi");

                return eklenenKategoriId;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return 0;
            }
        }
        public static void SaveIlgiliUrun()
        {
            List<IlgiliUrun> ilgiliUrunListe = new List<IlgiliUrun>();

            // UrunKartiID =205 olan ürüne 206 , 206 olan ürüne de 205 i ilgili ürün olarak ekler. İstersek tek taraflı da ekleyebiliriz. 
            IlgiliUrun ilgiliUrun = new IlgiliUrun
            {
                UrunKartiID = 205,
                IlgiliUrunKartiID = 206
            };
            IlgiliUrun ilgiliUrun2 = new IlgiliUrun
            {
                UrunKartiID = 206,
                IlgiliUrunKartiID = 205
            };

            ilgiliUrunListe.Add(ilgiliUrun);
            ilgiliUrunListe.Add(ilgiliUrun2);

            StaticVariables.urunServisClient.SaveIlgiliUrun(StaticVariables.uyeKodu, ilgiliUrunListe);
        }
        public static List<IlgiliUrun> SelectIlgiliUrun()
        {
            try
            {
                // ikisi de 0 gönderilir ise tüm ilgili ürünler listelenir. Urun kartı id ve ilgili ürün kartı id lere göre de filtrelenebilir.
                List<IlgiliUrun> ilgiliUrunListe = StaticVariables.urunServisClient.SelectIlgiliUrun(StaticVariables.uyeKodu, 0, 0);

                StaticFunctions.CevapListele(ilgiliUrunListe.Cast<object>().ToList(), "İlgili Ürün Listesi");

                return ilgiliUrunListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        // buradan aşağısı dökümanda ve mevcut versiyonda yok 
        public static void SaveUrunKategori()
        {
            List<UrunKategori> urunkategoriListe = new List<UrunKategori>();
            UrunKategori urunKategori = new UrunKategori
            {
                KategoriID = 53,
                UrunKartiID = 205,
                Sira = 1
            };
            urunkategoriListe.Add(urunKategori);
            StaticVariables.urunServisClient.SaveUrunKategori(StaticVariables.uyeKodu, urunkategoriListe);
        }
        public static void DeleteUrunKategori()
        {
            List<UrunKategori> urunKategoriListe = new List<UrunKategori>();
            UrunKategori urunKategori = new UrunKategori
            {
                KategoriID = 205,
                UrunKartiID = 53,
                Sira = 1
            };
            urunKategoriListe.Add(urunKategori);
            StaticVariables.urunServisClient.DeleteUrunKategori(StaticVariables.uyeKodu, urunKategoriListe);
        }
        public static void SaveUrunEtiket()
        {
            List<UrunEtiket> liste = new List<UrunEtiket>();
            UrunEtiket etiket = new UrunEtiket
            {
                EtiketID = 2,
                UrunKartiID = 205,
                Sira = 5
            };
            liste.Add(etiket);
            StaticVariables.urunServisClient.SaveUrunEtiket(StaticVariables.uyeKodu, liste);
        }
        public static void DeleteUrunEtiket()
        {
            try
            {
                List<UrunEtiket> liste = new List<UrunEtiket>();
                UrunEtiket etiket = new UrunEtiket
                {
                    // iki alan da  zorunlu 
                    EtiketID = 1,
                    UrunKartiID = 1,
                };

                liste.Add(etiket);
                StaticVariables.urunServisClient.DeleteUrunEtiket(StaticVariables.uyeKodu, liste);
            }
            catch (Exception ex)
            {
            }

        }
        public static List<UrunEtiket> SelectUrunEtiket()
        {
            // etiket id dolu urun karti id 0 gönderilir ise gönderilen etiket id yi içeren  tüm kayıtlar gelir aynısı ürün kartı id için de geçerlidir.  
            List<UrunEtiket> urunEtiketListe = StaticVariables.urunServisClient.SelectUrunEtiket(StaticVariables.uyeKodu, 0, 206);
            return urunEtiketListe;
        }
        public static void DeleteIlgiliUrun()
        {
            // girilen idli ürün kartını içeren tüm ilgili ürünler silinir.
            StaticVariables.urunServisClient.DeleteIlgiliUrun(StaticVariables.uyeKodu, 205);
        }


    }
}
