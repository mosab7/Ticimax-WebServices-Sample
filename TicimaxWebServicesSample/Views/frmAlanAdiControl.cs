using System;
using System.Windows.Forms;

namespace TicimaxWebServicesSample
{
    public partial class frmAlanAdiControl : Form
    {
        bool isSettings;
        public frmAlanAdiControl(bool IsSettings = false)
        {
            InitializeComponent();
            isSettings = IsSettings;
            tbAlanAdi.Text = Properties.Settings.Default.AlanAdi;
            tbUyeKodu.Text = Properties.Settings.Default.YetkiKodu;
        }
        private void btnAlanAdiYetkiKoduGuncelle_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            if (!string.IsNullOrEmpty(tbAlanAdi.Text) && !string.IsNullOrEmpty(tbUyeKodu.Text))
            {
                Properties.Settings.Default.AlanAdi = tbAlanAdi.Text;
                Properties.Settings.Default.YetkiKodu = tbUyeKodu.Text;
                Properties.Settings.Default.Save();

                StaticVariables.alanAdi = tbAlanAdi.Text;
                StaticVariables.uyeKodu = tbUyeKodu.Text;

                StaticVariables.urunServisClient = new UrunServis.UrunServisClient();
                StaticVariables.siparisServisClient = new SiparisServis.SiparisServisClient();
                StaticVariables.uyeServisClient = new UyeServis.UyeServisClient();
                StaticVariables.customServisClient = new CustomServis.CustomServisClient();

                StaticVariables.uyeServisClient.Endpoint.Address = new System.ServiceModel.EndpointAddress(tbAlanAdi.Text.Trim().ToServisUri("UyeServis"));

                StaticVariables.urunServisClient.Endpoint.Address = new System.ServiceModel.EndpointAddress(tbAlanAdi.Text.Trim().ToServisUri("UrunServis"));

                StaticVariables.siparisServisClient.Endpoint.Address = new System.ServiceModel.EndpointAddress(tbAlanAdi.Text.Trim().ToServisUri("SiparisServis"));

                StaticVariables.customServisClient.Endpoint.Address = new System.ServiceModel.EndpointAddress(tbAlanAdi.Text.Trim().ToServisUri("CustomServis"));

                if (!isSettings)
                {
                    this.Hide();
                    frmMain frmMain = new frmMain();
                    frmMain.Show();
                }
                else
                    this.Close();
            }
            else
                MessageBox.Show("Alan adı veya yetki kodu boş bırakılamaz.", "Uyarı");
        }
        private void tbAlanAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                Login();
        }
        private void tbUyeKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                Login();
        }
    }
}
