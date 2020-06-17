using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreto.Views
{
    public partial class FPrintFactura : Form
    {
        ListView producList;
        double total = 0;
        double iva = 0;
        double neto = 0;

        public FPrintFactura(ListView listView, double _total, double _Iva, double _neto)
        {
            InitializeComponent();
            producList = listView;
            this.total = _total;
            this.iva = _Iva;
            this.neto = _neto;
            AddDetailsF();
        }

        private void AddDetailsF()
        {
            foreach (ListViewItem item in producList.Items)
            {
                ListViewItem listView = new ListViewItem(item.SubItems[1].Text);
                listView.SubItems.Add(item.SubItems[3].Text);
                listView.SubItems.Add(item.SubItems[4].Text);

                listViewdetalle.Items.Add(listView);
            }
            BaseLab.Text= this.total.ToString();
            IvaLab.Text = this.iva.ToString();
            NetoLab.Text = this.neto.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
