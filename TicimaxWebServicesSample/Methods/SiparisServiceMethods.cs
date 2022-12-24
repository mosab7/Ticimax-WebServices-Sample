using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicimaxWebServicesSample.SiparisServis;

namespace TicimaxWebServicesSample.Methods
{
    public static class SiparisServiceMethods
    {
        public static List<WebSiparis> SelectSiparis()
        {
            try
            {
                // Tüm integer alanlar için -1 gönderildiğinde o alana filtreleme yapılmaz. Hiçbir alan zorunlu değil filtrelemek istenilen bilgilere göre doldurulabilir.

                // ödeme durumu değişkenleri=  
                // 0 - onay bekliyor, 1 - onaylandı, 2 - hatalı , 3 - iade edilmiş, 4 - iptal edilmiş 

                // ödeme tipi değişkenleri =
                //KrediKarti = 0,  Havale = 1, KapidaOdemeNakit = 2, KapidaOdemeKrediKarti = 3, MobilOdeme = 4,
                //BkmEkspress = 5, PayPal = 6, Cari = 7, MailOrder = 8, iPara = 9, Nakit = 10, 
                //PayUOneClick = 11, CariKredi = 12, GarantiPay = 13, PayuBkmEkspress = 14, NestPay = 15,
                //PayCell = 16, IyziPay = 17, Hopi = 18, PayByMe = 19, HediyeCeki = 20, PayGuruMobil = 21,
                //Paynet = 22, Telr = 23, ComPay = 24, PayTR = 25, MaximumMobil = 26, MagazadaOde = 27

                //Sipariş durumu değişkenleri 
                //0 = ön sipariş,  1 = onay bekliyor, 2 = onaylandı, 3 = ödeme bekliyor, 4 = paketleniyor, 5 = tedarik ediliyor
                //6 = kargoya verildi, 7 = teslim edildi, 8 = iptal edildi, 9 = iade edildi, 10 - silinmiş, 11 - iade talebi alındı, 12 - iade ulaştı ödeme yapılacak, 13 - iade ödemesi yapıldı, 14 - teslimat öncesi iptal talebi, 15 - iptal talebi, 16 - kısmi iade talebi, 17 - kısmi iade yapıldı


                WebSiparisFiltre webSiparisFiltre = new WebSiparisFiltre
                {
                    EntegrasyonAktarildi = -1,  // sipariş aktarılma durumu 0 = aktarılmayanlar,  1 = aktarılanlar, -1 = hepsi  
                    EntegrasyonParams = new WebSiparisEntegrasyon
                    {
                        AlanDeger = "",
                        Deger = "",
                        EntegrasyonKodu = "",
                        EntegrasyonParamsAktif = true,
                        TabloAlan = "",
                        Tanim = ""
                    },
                    IptalEdilmisUrunler = true, // iptal edilmiş siparişlerin kontrolü 
                    FaturaNo = "",
                    OdemeDurumu = -1,
                    OdemeTipi = -1, // siparisin ödeme tipi durumu 
                    SiparisDurumu = -1,
                    SiparisID = -1,
                    SiparisKaynagi = "",
                    SiparisKodu = "",
                    SiparisTarihiBas = Convert.ToDateTime(DateTime.Now.AddDays(-10).ToString("yyyy-MM-dd")), //Son 10 günlük siparişler çekiliyor.
                    SiparisTarihiSon = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),
                    //SiparisTarihiBas = Convert.ToDateTime("2019-02-04"), //filtrede kullanılacak sipariş başlangıç tarihi
                    //SiparisTarihiSon = Convert.ToDateTime("2019-02-06"), // filtrede kullanılacak sipariş bitiş tarihi
                    StrSiparisDurumu = "",
                    TedarikciID = -1,
                    UyeID = -1,
                    SiparisNo = "",
                    UyeTelefon = ""

                };

                WebSiparisSayfalama webSiparisSayfalama = new WebSiparisSayfalama
                {
                    BaslangicIndex = 0, // bulunan kayıtların baslangıç index i  - zorunlu değil 
                    KayitSayisi = 100, // kaç kayıt getirileceği bilgisi, - zorunlu değil girilmez ise bulunan tüm kayıtlar gösterilir.
                    SiralamaDegeri = "id", // kayıtların hangi alana göre sıralanacağı - zorunlu değil 
                    SiralamaYonu = "Desc" // Sıralama yönü. Artan için "ASC" azalan için "DESC" - zorunlu değil 
                };
                List<WebSiparis> siparisListe = StaticVariables.siparisServisClient.SelectSiparis(StaticVariables.uyeKodu, webSiparisFiltre, webSiparisSayfalama);

                MessageBox.Show("Son 10 günün siparişleri listelendi");

                StaticFunctions.CevapListele(siparisListe.Cast<object>().ToList(), "Siparişler");

                return siparisListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static string SaveSiparisKargoPaket()
        {
            try
            {
                // siparişin içerisindeki ürünleri alıyoruz. 
                List<WebSiparisUrun> webSiparisUrunListe = StaticVariables.siparisServisClient.SelectSiparisUrun(StaticVariables.uyeKodu, 1, false);

                // webSiparisUrunListe içerisindeki ürünlerin id değerlerini integer bir listeye dolduruyoruz. 
                List<int> urunidList = webSiparisUrunListe.Select(x => x.ID).ToList();

                // son parametre olan kontrol etme siparişin kargopaket e eklenip eklenmediğini kontrol eder. Eğer kontroletme değerini true gönderirsek kontrol edilmez ve aynı sipariş bir çok kez kaydedilebilir. False gönderilir ise bir sipariş ile bir kayıt oluşturulabilir eğer o sipariş id ile oluşmuş başka bir siparisKargoPaket bulunuyorsa yeni kayıt oluşturmaz.

                string SaveSiparisKargoPaketCevap = StaticVariables.siparisServisClient.SaveSiparisKargoPaket(StaticVariables.uyeKodu, 1, 1, 2, urunidList, "156457846", true, true, true, "", 0);

                MessageBox.Show(SaveSiparisKargoPaketCevap);

                return SaveSiparisKargoPaketCevap;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static WebSiparisSaveResponse SaveSiparis()
        {
            try
            {
                // siparişin ödeme bilgisi
                WebSiparisSaveOdeme odeme = new WebSiparisSaveOdeme
                {
                    BankaKomisyonu = 4.1,
                    //HavaleHesapID = 2, // eğer ödeme tipi havale(1) ise veritabanında kayıtlı bankahesaplarından birinin id değeri girilmesi gerekir. 
                    KapidaOdemeTutari = 5.15,
                    OdemeDurumu = 1,
                    OdemeIndirimi = 15, // indirim yüzdesi 
                    OdemeNotu = "ödeme notu",
                    OdemeSecenekID = 2, // tanımlı olan ödeme seçenek id si 
                    OdemeTipi = 2,
                    //TaksitSayisi = 5,
                    Tarih = DateTime.Now,
                    Tutar = 50
                };
                //Siparişin içerisindeki urunlerin bilgisi
                List<WebSiparisSaveUrun> urunListe = new List<WebSiparisSaveUrun>
                        {
                            new WebSiparisSaveUrun
                            {
                                Adet=1,
                                KdvOrani=8,
                                KdvTutari=5.12,
                                Maliyet=30,
                                Tutar=50,
                                UrunID=1
                            }
                        };

                WebSiparisSaveRequest siparis = new WebSiparisSaveRequest
                {
                    FaturaAdresId = 1,  // SaveUyeAdres metodu ile üyenin adresi kayıt edilip dönen id numarası bu kısma yazılabilir .               
                    IndirimTutari = 10, // indirim yüzdesi 
                    KargoAdresId = 1, // SaveUyeAdres metodu ile üyenin adresi kayıt edilip dönen id numarası bu kısma yazılabilir.
                                      // Fatura ve teslimat adresi aynı ise kargo adres id ve fatura adres id aynı olabilir.
                    KargoFirmaId = 2, // Ticimax site yönetim panelindenki kargo yönetiminden kargo id’sini öğrenebilirsiniz.
                    KargoTutari = 0,
                    Odeme = odeme,
                    ParaBirimi = "TL",
                    SiparisKaynagi = "Web",
                    SiparisNotu = "not",
                    Urunler = urunListe,
                    UrunTutari = 50,
                    UrunTutariKdv = 5.12,
                    UyeId = 1,  // Sipariş veren kullanıcının üye id’si. Üyenin maili ile SelectUyeler metodundan uye id si bulunabilir.

                    TeslimatSaati = "12.15",
                    TeslimatTarihi = new DateTime(2018, 11, 13)
                };
                WebSiparisSaveResponse siparisEklemeCevap = StaticVariables.siparisServisClient.SaveSiparis(StaticVariables.uyeKodu, siparis);

                if (siparisEklemeCevap.IsError)
                    MessageBox.Show(siparisEklemeCevap.ErrorMessage);
                else
                    MessageBox.Show("Siparis Eklendi.");

                return siparisEklemeCevap;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }

        }
        public static SaveSiparisKargoPaketKargoTakipNoResponse SaveSiparisKargoPaketKargoTakipNo()
        {
            try
            {
                // kargoPaketCevap ta işlemin ne şekilde sonuçlandığına dair bilgi döndürülüyor.
                SaveSiparisKargoPaketKargoTakipNoResponse SaveSiparisKargoPaketKargoTakipNoResponse = StaticVariables.siparisServisClient.SaveSiparisKargoPaketKargoTakipNo(StaticVariables.uyeKodu, 1, 1, "45641564");

                if (SaveSiparisKargoPaketKargoTakipNoResponse.IsError)
                    MessageBox.Show(SaveSiparisKargoPaketKargoTakipNoResponse.ErrorMessage);
                else
                    MessageBox.Show("Kargo pakete takip numarası eklendi.");

                return SaveSiparisKargoPaketKargoTakipNoResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }

        }
        public static List<WebKargoPaket> SelectSiparisKargoPaket()
        {
            try
            {
                // hiç bir alanın girilmesi zorunlu değildir.
                // integer alanlar -1 olarak gönderilirse filtreleme yapılmaz 
                WebSiparisKargoPaketFiltre webSiparisKargoPaketFiltre = new WebSiparisKargoPaketFiltre
                {
                    KargoEntegrasyonID = -1, // kayıtlı kargo entegrasyon id değeri 
                    KargoTakipNoDurum = 1, // kargo takip numarası olanları getirmek için bu alana 1 değeri verilmeli. 0 verilirse kargo takip numarası olmayanları filtreler -1 verilirse filtre yapılmaz 
                    //PaketlenmeTarihBas = new DateTime(2016, 10, 10),
                    //PaketlenmeTarihBit = new DateTime(2018, 12, 10),
                    SiparisID = -1,
                    SiparisKargoPaketID = -1
                };

                List<WebKargoPaket> kargoPaketListe = StaticVariables.siparisServisClient.SelectSiparisKargoPaket(StaticVariables.uyeKodu, webSiparisKargoPaketFiltre);

                MessageBox.Show("Filtrelere göre bulunan kargo paket sayısı: " + kargoPaketListe.Count);

                StaticFunctions.CevapListele(kargoPaketListe.Cast<object>().ToList(), "Kargo Paketler");

                return kargoPaketListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<WebSiparisOdeme> SelectSiparisOdeme()
        {
            try
            {
                // Ödeme id 0 gönderilerek siparişin odeme bilgisi alınabilir. 
                // İkisi de 0 gönderilerek tüm sipariş ödemeler listelenebilir. 
                List<WebSiparisOdeme> odemeListe = StaticVariables.siparisServisClient.SelectSiparisOdeme(StaticVariables.uyeKodu, 1, 0);

                MessageBox.Show("Ödemeler listelendi.");

                StaticFunctions.CevapListele(odemeListe.Cast<object>().ToList(), "Ödemeler");

                return odemeListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<WebSiparisUrun> SelectSiparisUrun()
        {
            try
            {
                // İptalEdilmisUrunler değeri false gönderilirse iptal edilen ürünler getirilmez. 
                List<WebSiparisUrun> urunListe = StaticVariables.siparisServisClient.SelectSiparisUrun(StaticVariables.uyeKodu, 1, false);

                MessageBox.Show("Siparişteki ürünler listelendi. Bulunan ürün sayısı: " + urunListe.Count);

                StaticFunctions.CevapListele(urunListe.Cast<object>().ToList(), "Ürünler");

                return urunListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<SiparisServis.SiparisUrunDurumlari> SelectSiparisUrunDurumlari()
        {
            try
            {
                // gönderilecek parametrelerde integer olanlar -1 gönderilir ise o alanlara filtreleme yapılmaz. Yani tüm integer alanlar -1 gönderilir ise tüm kayıtlar döner.

                List<SiparisServis.SiparisUrunDurumlari> siparisUrunDurumlariListe = StaticVariables.siparisServisClient.SelectSiparisUrunDurumlari(StaticVariables.uyeKodu, -1, -1, -1);

                MessageBox.Show("Sipariş ürün durumları listelendi. " + siparisUrunDurumlariListe.Count + " adet sipariş ürün durumunuz bulunmaktadır.");

                StaticFunctions.CevapListele(siparisUrunDurumlariListe.Cast<object>().ToList(), "Sipariş Ürün Durumları");

                return siparisUrunDurumlariListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static void SetSiparisAktarildi()
        {
            try
            {
                StaticVariables.siparisServisClient.SetSiparisAktarildi(StaticVariables.uyeKodu, 1);
                MessageBox.Show("Sipariş aktarıldı yapıldı.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public static void SetSiparisAktarildiIptal()
        {
            try
            {
                StaticVariables.siparisServisClient.SetSiparisAktarildiIptal(StaticVariables.uyeKodu, 588);
                MessageBox.Show("Sipariş aktarıldı iptal edildi.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public static SetSiparisDurumResponse SetSiparisDurum()
        {
            try
            {
                SetSiparisDurumRequest setSiparisDurumRequest = new SetSiparisDurumRequest
                {
                    Durum = WebSiparisDurumlari.Onaylandi, // zorunlu. eğer gönderilmez ise 0 kabul edilir.
                    KargoTakipNo = "",
                    MailBilgilendir = false,
                    SiparisID = 1 // * zorunlu 
                };
                SetSiparisDurumResponse setSiparisDurumResponse = StaticVariables.siparisServisClient.SetSiparisDurum(StaticVariables.uyeKodu, setSiparisDurumRequest);

                if (setSiparisDurumResponse.IsError)
                    MessageBox.Show(setSiparisDurumResponse.ErrorMessage);
                else
                    MessageBox.Show("Sipariş durumu eklendi.");

                return setSiparisDurumResponse;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static void SetSiparisKargoyaVerildi()
        {
            try
            {
                StaticVariables.siparisServisClient.SetSiparisKargoyaVerildi(StaticVariables.uyeKodu, 1);
                MessageBox.Show("Sipariş kargoye verildi.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public static void SetSiparisTeslimEdildi()
        {
            try
            {
                StaticVariables.siparisServisClient.SetSiparisTeslimEdildi(StaticVariables.uyeKodu, 1);
                MessageBox.Show("Sipariş teslim edildi");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public static List<WebKargoFirma> GetKargoSecenek()
        {
            try
            {
                GetKargoSecenekRequest getKargoSecenekRequest = new GetKargoSecenekRequest
                {
                    ParaBirimi = "TL",
                    SehirId = 34,
                    Sepet = new ServisSepet // bu şekilde gönderilebilir 
                    {
                        Urunler = new List<ServisSepetUrun>()
                    }
                };
                List<WebKargoFirma> webKargoFirmaListe = StaticVariables.siparisServisClient.GetKargoSecenek(StaticVariables.uyeKodu, getKargoSecenekRequest);


                MessageBox.Show("Filtrelere göre bulunan kargo firma sayısı: " + webKargoFirmaListe.Count);

                StaticFunctions.CevapListele(webKargoFirmaListe.Cast<object>().ToList(), "Kargo Firma");

                return webKargoFirmaListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static string SaveKargoTakipNo()
        {
            try
            {
                string saveKargoTakipNoSonuc = StaticVariables.siparisServisClient.SaveKargoTakipNo(StaticVariables.uyeKodu, 1, "", "4561562545");

                if (saveKargoTakipNoSonuc == "OK")
                    MessageBox.Show("Siparişe kargo takip numarası eklendi.");

                return saveKargoTakipNoSonuc;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<SiparisOdemeTipleri> GetOdemeTipleri()
        {
            try
            {
                List<SiparisOdemeTipleri> OdemeTipleriListe = StaticVariables.siparisServisClient.GetOdemeTipleri(StaticVariables.uyeKodu);

                MessageBox.Show("Ödeme tipleri listelendi. " + OdemeTipleriListe.Count + " adet kayıtlı ödeme tipiniz bulunmaktadır.");

                StaticFunctions.CevapListele(OdemeTipleriListe.Cast<object>().ToList(), "Ödeme Tipleri");

                return OdemeTipleriListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }

        }
        public static ServisSepet GetSepet()
        {
            try
            {
                GetSepetRequest getSepetRequest = new GetSepetRequest
                {
                    KampanyaID = 3,
                    SepetID = 1,
                    UyeID = 1
                };
                ServisSepet servisSepet = StaticVariables.siparisServisClient.GetSepet(StaticVariables.uyeKodu, getSepetRequest);

                if (servisSepet != null)
                    MessageBox.Show("Sepet bulundu.");
                else
                    MessageBox.Show("Sepet bulunamadı.");

                return servisSepet;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<WebSiparisOdeme> SelectCariOdeme()
        {
            try
            {
                // integer alanlarda -1 gönderilir ise o alanda filtreleme yapılmaz. 
                WebSiparisOdemeFiltre webSiparisOdemeFiltre = new WebSiparisOdemeFiltre
                {
                    OdemeDurumu = -1,
                    OdemeID = -1,
                    //OdemeTarihiBas = new DateTime(2005, 10, 10),
                    //OdemeTarihiSon = new DateTime(2018, 10, 10),
                    OdemeTipi = -1,
                    SiparisID = -1,
                    UyeID = -1
                };
                List<WebSiparisOdeme> siparisOdemeListe = StaticVariables.siparisServisClient.SelectCariOdeme(StaticVariables.uyeKodu, webSiparisOdemeFiltre);

                MessageBox.Show("Sipariş ödemeler listelendi. " + siparisOdemeListe.Count + " adet kayıtlı sipariş ödeme bulunmaktadır.");

                StaticFunctions.CevapListele(siparisOdemeListe.Cast<object>().ToList(), "Ödemeler");

                return siparisOdemeListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static ServisSepet CreateSepet()
        {
            try
            {
                CreateSepetRequest createSepetRequest = new CreateSepetRequest
                {
                    UyeID = 148963
                };
                ServisSepet servisSepet = StaticVariables.siparisServisClient.CreateSepet(StaticVariables.uyeKodu, createSepetRequest);
                return servisSepet;
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }

        }
        public static List<WebSepet> SelectSepet()
        {
            try
            {
                List<WebSepet> webSepetListe = StaticVariables.siparisServisClient.SelectSepet(StaticVariables.uyeKodu, -1, -1, new DateTime(2014, 10, 10), new DateTime(2018, 10, 10));

                MessageBox.Show("Filtrelere göre bulunan sepet sayısı: " + webSepetListe.Count);

                StaticFunctions.CevapListele(webSepetListe.Cast<object>().ToList(), "Sepetler");

                return webSepetListe;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static List<WebSepet> SelectWebSepet()
        {
            SelectWebSepetRequest selectWebSepetRequest = new SelectWebSepetRequest
            {
                Dil = "",
                ParaBirimi = "",
                SepetId = 0,
                UyeId = 1
            };
            List<WebSepet> webSepetListesi = StaticVariables.siparisServisClient.SelectWebSepet(StaticVariables.uyeKodu, selectWebSepetRequest);





            MessageBox.Show("Filtrelere göre bulunan sepet sayısı: " + webSepetListesi.Count);

            StaticFunctions.CevapListele(webSepetListesi.Cast<object>().ToList(), "Sepetler");

            return webSepetListesi;
        }
        public static void SetFaturaNo()
        {
            try
            {
                StaticVariables.siparisServisClient.SetFaturaNo(StaticVariables.uyeKodu, 1, "1561465165", DateTime.Now);
                MessageBox.Show("Siparişe fatura numarası eklendi.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public static SetSiparisUrunDurumResponse SetSiparisUrunDurum()
        {
            try
            {
                SetSiparisUrunDurumRequest setSiparisUrunDurumRequest = new SetSiparisUrunDurumRequest
                {
                    SiparisID = 5,
                    SiparisUrunID = 5,
                    DurumID = 1, // kayıtlı durum id    
                    Islem = 1, // kayıtlı durumun işlem  değeri

                };

                SetSiparisUrunDurumResponse setSiparisUrunDurumResponse = StaticVariables.siparisServisClient.SetSiparisUrunDurum(StaticVariables.uyeKodu, setSiparisUrunDurumRequest);
                return setSiparisUrunDurumResponse;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
    }
}
