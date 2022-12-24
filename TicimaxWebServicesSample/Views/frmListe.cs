using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicimaxWebServicesSample.UrunServis;

namespace TicimaxWebServicesSample.Views
{
    public partial class frmListe : Form
    {
        public frmListe(List<object> objectList,string title)
        {
            InitializeComponent();
            this.Text = title;
            Listele(objectList);
        }
        private void dtgResultList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Listele(List<object> objList)
        {
            try
            {
                var bindingList = new BindingList<object>(objList);
                var source = new BindingSource(bindingList, null);
                dtgResultList.DataSource = source;
            }
            catch (Exception ex)
            {
            }
        }
    }
}
