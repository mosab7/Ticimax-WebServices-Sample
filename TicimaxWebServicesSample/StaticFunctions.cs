using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicimaxWebServicesSample.Views;

namespace TicimaxWebServicesSample
{
   public static  class StaticFunctions
    {
        public static Uri ToServisUri(this string Alan_Adi, string Path)
        {
            string adres_format = "https://{0}/Servis/{1}.svc";
            return new Uri(string.Format(adres_format, Alan_Adi, Path));
        }
        public static void CevapListele(List<object> objectList,string title)
        {
            frmListe frmListe = new frmListe(objectList,title);
            frmListe.Show();
        }
    }
}
