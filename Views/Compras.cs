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
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ferreto.Views
{
    public partial class Compras : Form
    {
        private readonly FerretoSContext _context;
        private readonly  ServicesInjector<Compra> _compraservice;
        public Compras()
        {
            InitializeComponent();
            _context = Initializecontext.initcontext();
            _compraservice = new ServicesInjector<Compra>(_context);
            timer1.Start();
            Init();
        }


        private void ActualizarBo_Click(object sender, EventArgs e)
        {
            CompraExistente obj = new CompraExistente();
            obj.UserLabel.Text = UserLabel.Text;
            obj.ShowDialog();
        }
        private void Init()
        {
            ListViewItem item = null;
            var Collection = _compraservice.GetInfo();
            foreach (var iterator in Collection.compras)
            {
                item = this.ComprasLV.Items.Add(iterator.Idcompra.ToString());
                item.SubItems.Add(iterator.IdproductoNavigation.Nombre);
                item.SubItems.Add(iterator.Cantidad.ToString());
                item.SubItems.Add(iterator.Costounitario.ToString());
                item.SubItems.Add(iterator.Totalcompra.ToString());
                if (iterator.IdproductoNavigation.Precioproducto.Any(x=>x.Idproducto.Equals(iterator.Idproducto)))
                {
                    foreach (var i in iterator.IdproductoNavigation.Precioproducto)
                    {
                        item.SubItems.Add(i.Precio.ToString());
                    }
                }
                item.SubItems.Add(iterator.CodproveedorNavigation.IdpersonaNavigation.Nombre);
                item.SubItems.Add(iterator.Fechacompra.ToString());
            }
        }
        private void AñadirBo_Click(object sender, EventArgs e)
        {
            CompraNueva obj = new CompraNueva();
            obj.UserLabel.Text = UserLabel.Text;
            obj.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.FechaLab.Text = DateTime.Now.ToString();
        }
    }
}
