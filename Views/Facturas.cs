using Ferreto.Common;
using Ferreto.Models;
using Ferreto.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreto.Views
{
    public partial class ReimprimirBo : Form
    {
        private readonly FerretoSContext _context;
        private readonly ServicesInjector<Detallefactura> _detallehelper;
      
        public ReimprimirBo()
        {
            InitializeComponent();
            timer1.Start();
            _context = Initializecontext.initcontext();
            _detallehelper = new ServicesInjector<Detallefactura>(_context);
        }

        private void SendToList()
        {
            try
            {
                int id = int.Parse(this.idtxt.Text);
                ListViewItem P = null;
                var D = _detallehelper.GetDetails();
                double subtotal;
                foreach (var d in D.Where(x => x.Idfactura == id))
                {
                    P = DetallesLv.Items.Add(d.Iddetalle.ToString());
                    P.SubItems.Add(d.IdproductoNavigation.Nombre);
                    P.SubItems.Add(d.IdproductoNavigation.IdmarcaNavigation.Nombre);
                    P.SubItems.Add(d.Precioventa.ToString());
                    P.SubItems.Add(d.Cantidad.ToString());
                    P.SubItems.Add(d.IdproductoNavigation.IdcategoriaNavigation.Nombre);
                    subtotal = d.Cantidad * d.Precioventa;
                    P.SubItems.Add(subtotal.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(" Algo malo sucedió! ", "Problema desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Verifiy()
        {
            if (DetallesLv.Items.Count > 0)
            {
                MessageBox.Show("El detalle de facturas ya se está mostrando! ", "Detalles de factura encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.BuscarBo.Visible = false;
                SendToList();
                this.Limpiarbttn.Visible = true;
            }

        }
        private void Buscar(object sender, EventArgs e)
        {
            Verifiy();
        }

        private void ReImprimir()
        {
            var factura = _detallehelper.GetDetails();
            decimal total = 0m;
            double iva = 0;
            decimal neto = 0m;
            string nombre = string.Empty;
            foreach (var item in factura)
            {
                if (item.Idfactura.Equals(int.Parse(idtxt.Text)))
                {
                    total = item.IdfacturaNavigation.Totalsiniva;
                    iva = item.IdfacturaNavigation.Iva;
                    neto = item.IdfacturaNavigation.Totalmasiva;
                    nombre = item.IdfacturaNavigation.Nombreusuario;
                    break;
                }    
            }
            FPrintFactura obj = new FPrintFactura(DetallesLv, total, iva, neto, nombre);
           obj.ShowDialog();
        }
        private void ReimprimirBo_Load(object sender, EventArgs e)
        {

        }

        private void limpiar(object sender, EventArgs e)
        {
            DetallesLv.Items.Clear();
            this.Limpiarbttn.Visible = false;
            this.BuscarBo.Visible = true;
        }

        private void ReBo_Click(object sender, EventArgs e)
        {
            ReImprimir();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.FechaLab.Text = DateTime.Now.ToString();
        }
    }
}
