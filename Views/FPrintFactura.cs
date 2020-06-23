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

        decimal _total = 0;
        double _iva = 0;
        decimal _neto = 0;
        static string c = string.Empty;
        static string o = string.Empty;
        string signo = c.PadLeft(1, 'C')+o.PadRight(1, '$');
        public FPrintFactura(ListView listView, double _total, double _Iva, double _neto,string nombre)
        {
            InitializeComponent();
            producList = listView;
            this.total = _total;
            this.iva = _Iva;
            this.neto = _neto;
            this.nombrelabel.Text = nombre;
            AddDetailsF(1);
        }
        public FPrintFactura(ListView listView, decimal _total, double _Iva, decimal _neto,string nombre)
        {
            InitializeComponent();
            producList = listView;
            this._total = _total;
            this._iva = _Iva;
            this._neto = _neto;
            this.nombrelabel.Text = nombre;
            AddDetailsF(0);
        }

        private void AddDetailsF(int accion)
        {
            foreach (ListViewItem item in producList.Items)
            {
                ListViewItem listView = new ListViewItem(item.SubItems[1].Text);
                listView.SubItems.Add(signo + " " + item.SubItems[3].Text);
                listView.SubItems.Add(item.SubItems[4].Text);
                listView.SubItems.Add(signo + " " + item.SubItems[6].Text);
                listViewdetalle.Items.Add(listView);
            }
            switch (accion)
            {
                case 0:
                    BaseLab.Text = signo + " " + this._total.ToString();
                    IvaLab.Text = signo + " " + this._iva.ToString();
                    NetoLab.Text = signo + " " + this._neto.ToString();
                    break;
                case 1:
                    BaseLab.Text = signo + " " + this.total.ToString();
                    IvaLab.Text = signo + " " + this.iva.ToString();
                    NetoLab.Text = signo + " " + this.neto.ToString();
                    break;
            }
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
