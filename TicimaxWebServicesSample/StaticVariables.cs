using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicimaxWebServicesSample.UrunServis;
using TicimaxWebServicesSample.Views;

namespace TicimaxWebServicesSample
{
    public static class StaticVariables
    {
        public static UyeServis.UyeServisClient uyeServisClient;
        public static UrunServis.UrunServisClient urunServisClient;
        public static SiparisServis.SiparisServisClient siparisServisClient;
        public static CustomServis.CustomServisClient customServisClient;
        public static string uyeKodu = "";
        public static string alanAdi = "";
        public static List<Kategori> kategoriList = new List<Kategori>();
        public static List<Marka> markaList= new List<Marka>();
        public static List<Tedarikci> tedarikciList= new List<Tedarikci>();
        public static List<Etiket> etiketList = new List<Etiket>();
        public enum Tip { Kategori, Marka, Tedarikci, Etiket }

    }
}
