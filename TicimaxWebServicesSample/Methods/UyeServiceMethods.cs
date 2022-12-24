using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TicimaxWebServicesSample.UyeServis;

namespace TicimaxWebServicesSample.Methods
{
    public static class UyeServiceMethods
    {
        public static List<Uye> SelectUyeler()
        {
            try
            {
                // Aktif, AlisverisYapti, Cinsiyet, MailIzin, SmsIzin alanlarında -1 gönderilir ise filtre yapılmaz.
                UyeFiltre uyeFiltre = new UyeFiltre
                {
                    Aktif = -1,
                    AlisverisYapti = -1,
                    Cinsiyet = -1,
                    DogumTarihi1 = new DateTime(1992, 10, 5),
                    //DogumTarihi2 = new DateTime(2000, 1, 2),
                    //DuzenlemeTarihi1 = new DateTime(2014, 1, 20),
                    //DuzenlemeTarihi2 = new DateTime(2018, 11, 16),
                    //IlceID = 845,
                    //IlID = 34,
                    //Mail = "mail adresi",
                    MailIzin = -1,
                    //MusteriKodu = "",
                    SmsIzin = -1,
                    //SonGirisTarihi1 = new DateTime(2015, 1, 1),
                    //SonGirisTarihi2 = new DateTime(2018, 11, 16),
                    //Telefon = "",
                    UyeID = -1,
                    //UyelikTarihi1 = new DateTime(2015, 1, 1),
                    //UyelikTarihi2 = new DateTime(2018, 11, 16)
                };
                UyeSayfalama uyeSayfalama = new UyeSayfalama
                {
                    //KayitSayisi = 100, // kaç kayıt getireleceği bilgisi, - zorunlu değil girilmez ise bulunan tüm kayıtlar gösterilir.
                    SiralamaDegeri = "id", // kayıtların hangi alana göre sıralanacağı - zorunlu değil 
                    SiralamaYonu = "Desc", // zorunlu değil 
                    SayfaNo = 1
                };

                List<Uye> uyeListe = StaticVariables.uyeServisClient.SelectUyeler(StaticVariables.uyeKodu, uyeFiltre, uyeSayfalama);

                MessageBox.Show("Filtrelere göre bulunan üye sayısı: "+uyeListe.Count);

                StaticFunctions.CevapListele(uyeListe.Cast<object>().ToList(),"Üyeler");

                return uyeListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<UyeTuru> SelectUyeTuru()
        {
            try
            {
                // uyeTuruId 0 gönderilir ise tüm üye türleri getirilir.
                List<UyeTuru> uyeTuruListe = StaticVariables.uyeServisClient.SelectUyeTuru(StaticVariables.uyeKodu, 0);

                MessageBox.Show("Üye türleri listelendi. " + uyeTuruListe.Count + " adet kayıtlı üye türünüz bulunmaktadır.");

                StaticFunctions.CevapListele(uyeTuruListe.Cast<object>().ToList(),"Üye Türleri");

                return uyeTuruListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<UyeAdres> SelectUyeAdres()
        {
            try
            {
                // AdresId 0 uyeId 0+ gönderilir ise gönderilen id li üyenin tüm adresleri getirilir.
                //uyeId 0 AdresId 0+ gönderilir ise gönderilen id li üye adres getirilir
                List<UyeAdres> uyeAdresListe = StaticVariables.uyeServisClient.SelectUyeAdres(StaticVariables.uyeKodu, 0, 2);

                MessageBox.Show("Filtrelere göre bulunan üye adres sayısı:  " + uyeAdresListe.Count);

                StaticFunctions.CevapListele(uyeAdresListe.Cast<object>().ToList(),"Üye Adresleri");

                return uyeAdresListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static int SaveUyeTuru()
        {
            try
            {
                UyeTuru uyeTuru = new UyeTuru
                {
                    FiyatTuru = FiyatTuru.SatisFiyati,
                    ID = 0, // 0 olursa yeni üye türü ekler 0 dan büyük olursa girilen id li üye türünü günceller 
                    Tanim = "üye türü adı" // üye türü tanımı 
                };

                int eklenenUyeTuruId = StaticVariables.uyeServisClient.SaveUyeTuru(StaticVariables.uyeKodu, uyeTuru);

                if (eklenenUyeTuruId > 0)
                    MessageBox.Show("Üye türü eklendi id: " + eklenenUyeTuruId);
                else
                    MessageBox.Show("Üye türü eklenemedi.");

                return eklenenUyeTuruId;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return 0;
            }
        }
        public static int SaveUyeAdres()
        {
            try
            {
                UyeAdres uyeAdres = new UyeAdres
                {
                    Adres = "Rumi sokak",
                    AdresTarifi = "Adres tarifi",
                    Aktif = true,
                    AliciAdi = "Ticimax",
                    AliciTelefon = "0214656456",
                    FirmaAdi = "",
                    ID = 0,
                    Ilce = "Ataşehir",
                    IsKurumsal = false,
                    PostaKodu = "34000",
                    Sehir = "İstanbul",
                    Tanim = "ticimax",
                    Ulke = "türkiye",
                    UyeId = 1,
                    VergiDairesi = "",
                    VergiNo = ""
                };

                int eklenenAdresId = StaticVariables.uyeServisClient.SaveUyeAdres(StaticVariables.uyeKodu, uyeAdres);

                if (eklenenAdresId > 0)
                    MessageBox.Show("Üye adres eklendi id: " + eklenenAdresId);
                else
                    MessageBox.Show("Üye adres eklenemedi.");

                return eklenenAdresId;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return 0;
            }
        }
        public static int SaveUye()
        {
            try
            {
                Uye uye = new Uye
                {
                    CepTelefonu = "cep tel",
                    CinsiyetID = 1, // 0=bayan 1= erkek 
                    DogumTarihi = new DateTime(1994, 12, 10),
                    //DuzenlemeTarihi = DateTime.Now.Date,
                    ID = 0,// 0 girilirse yeni kayıt oluşturulur.
                           //Il = "İstanbul",
                           //Ilce = "Ataşehir",
                           //IlceID = 1,
                           //IlID = 1,
                    Isim = "Uye adi",
                    Mail = "üye mail",
                    MailIzin = false,
                    Meslek = "meslek bilgisi",
                    MusteriKodu = "",
                    OgrenimDurumu = "öğrenim durumu",
                    Sifre = "sifreniz",
                    SmsIzin = false,
                    Soyisim = "soyisim",
                    Telefon = "tel",
                    UyeTuruID = 1
                };
                UyeAyar uyeAyar = new UyeAyar
                {
                    CepTelefonuGuncelle = true,
                    CinsiyetGuncelle = false,
                    DogumTarihiGuncelle = false,
                    IlceGuncelle = true,
                    IlGuncelle = true,
                    IsimGuncelle = true,
                    MailGuncelle = true,
                    MailIzinGuncelle = true,
                    MeslekGuncelle = true,
                    MusteriKoduGuncelle = true,
                    SifreGuncelle = true,
                    SmsIzinGuncelle = true,
                    TelefonGuncelle = true
                };

                
                
                int eklenenUyeId = StaticVariables.uyeServisClient.SaveUye(StaticVariables.uyeKodu, uye, uyeAyar);               
                if (eklenenUyeId > 0)
                    MessageBox.Show("Üye eklendi id: " + eklenenUyeId);
                else
                    MessageBox.Show("Üye eklenemedi.");

                return eklenenUyeId;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return 0;
            }
        }
        public static UyeGirisiSonuc GirisYap()
        {
            try
            {
                UyeGirisi uyeGirisi = new UyeGirisi
                {
                    Admin = false, // adminlik durumu 
                    Mail = "mailadresiniz",
                    Otp = "676856", // kullanıcının otp ayarları yapılmış ve aktif ise girilmesi gerkeiyor 
                    Sifre = "sifreniz"
                };

                UyeGirisiSonuc uyeGirisiSonuc = StaticVariables.uyeServisClient.GirisYap(uyeGirisi);

                if (!uyeGirisiSonuc.Basarili)
                    MessageBox.Show(uyeGirisiSonuc.Mesaj);
                else
                    MessageBox.Show("Giriş yapıldı.");

                return uyeGirisiSonuc;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
           
        }
    }
}
