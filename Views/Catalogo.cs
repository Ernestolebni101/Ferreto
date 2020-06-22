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
using Ferreto.Common;
using System.Windows.Forms;

namespace Ferreto.Views
{
    public partial class Catalogo : Form
    {
        private readonly FerretoSContext _context;
        private readonly ServicesInjector<Inventario> _inventariohelper;
        private readonly ServicesInjector<Precioproducto> _precioproductohelper;
        private readonly ServicesInjector<Producto> _productohelper;
        public Catalogo()
        {
            InitializeComponent();
            timer1.Start();
            _context = Initializecontext.initcontext();
            _inventariohelper = new ServicesInjector<Inventario>(_context);
            _precioproductohelper = new ServicesInjector<Precioproducto>(_context);
            _productohelper = new ServicesInjector<Producto>(_context);
            InitList();
        }


    
        private void InitList()
        {
            ListViewItem item = null;
            var t_Inventario = _inventariohelper.ConsultInventory();
            var t_precioproducto = _precioproductohelper.ConsultPrice();
            foreach (var P in t_precioproducto)
            {
                item = this.Inventariolv.Items.Add(P.IdproductoNavigation.Idproducto.ToString());
                item.SubItems.Add(P.Precio.ToString());
                foreach (var I in t_Inventario)
                {
                    if (P.IdproductoNavigation.Idproducto.Equals(I.IdproductoNavigation.Idproducto))
                    {
                        item.SubItems.Add(I.Precio.ToString());
                        item.SubItems.Add(I.IdproductoNavigation.IdcategoriaNavigation.Nombre);
                        item.SubItems.Add(I.IdproductoNavigation.Nombre);
                        item.SubItems.Add(I.IdproductoNavigation.IdmarcaNavigation.Nombre);
                        item.SubItems.Add(I.Existencia.ToString());
                        item.SubItems.Add(I.IdproductoNavigation.IdpresentacionNavigation.Peso);
                        item.SubItems.Add(I.IdproductoNavigation.IdpresentacionNavigation.Tamaño);
                        item.SubItems.Add(I.IdproductoNavigation.Fecharegistro.ToString());
                        item.SubItems.Add(I.IdproductoNavigation.Fvencimiento.ToString());
                        if (I.IdproductoNavigation.Estado)
                        {
                            item.SubItems.Add("Activo");
                            item.BackColor = System.Drawing.Color.LightGreen;
                        }
                        else
                        {
                            item.SubItems.Add("Inactivo");
                            item.BackColor = System.Drawing.Color.IndianRed;
                        }
                    }
                }
            }
        }

        private void StateChanged(int id, byte accion)
        {
            switch (accion)
            {
                case 0:
                    _productohelper.ChangeStatus(id, accion);
                    break;
                case 1:
                    _productohelper.ChangeStatus(id, accion);
                    break;
            }
        }

        private void ChangedProduct()
        {
            if (Inventariolv.SelectedItems.Count > 0 && Inventariolv.SelectedItems.Count < 2)
            {
                byte accion;
                foreach (ListViewItem item in Inventariolv.SelectedItems)
                {
                    if (!CambiarEstadoSlide.IsOn)
                        accion = 0;
                    else
                        accion = 1;

                    StateChanged(int.Parse(item.SubItems[0].Text), accion);
                }
            }
            else
                MessageBox.Show("Debe elegir un solo producto", "Fallo al actualizar el producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CambiarEstadoBo_Click(object sender, EventArgs e)
        {
            ChangedProduct();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.FechaLab.Text = DateTime.Now.ToString();
        }
    }
}
