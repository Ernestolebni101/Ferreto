using Ferreto.Common;
using Ferreto.Models;
using Ferreto.Models.Common;
using Ferreto.Services;
using Microsoft.EntityFrameworkCore;
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
    public partial class Facturacion : Form
    {
        private readonly Helper<Producto> _productohelper;
        private readonly Helper<Precioproducto> _precioproductohelper;
        private readonly Helper<Inventario> _inventariohelper;
        private readonly Helper<Detallefactura> _detallefacturahelper;
        private readonly Helper<Factura> _facturahelper;
        private readonly FerretoSContext _context;
        public Facturacion()
        {
            InitializeComponent();
            ProductosLV.View = System.Windows.Forms.View.Details;
            _context = Initializecontext.initcontext();
            _productohelper = new Helper<Producto>(_context);
            _precioproductohelper = new Helper<Precioproducto>(_context);
            _detallefacturahelper = new Helper<Detallefactura>(_context);
            _facturahelper = new Helper<Factura>(_context);
            _inventariohelper = new Helper<Inventario>(_context);           
            SearchProducto();
        }

        #region Methods

     
        private bool Existence()
        {
            var Collections = _inventariohelper.Inventory();
            bool exception = false;
          
           foreach (var item in Collections)
           {
              if (item.IdproductoNavigation.Nombre.Equals(ProductosTxt.Text))
              {
                  try
                  {
                      if (int.Parse(CantidadTxt.Text) <= item.Existencia)
                      { 

                          errorProviderCantidad.Clear();
                             exception = false;
                      }
                      else
                      {
                          errorProviderCantidad.SetError(CantidadTxt, "No existe esta cantidad en inventario");
                            exception = true;
                      }
                  }
                  catch (Exception e) when (e.GetType() != typeof(OverflowException))
                  {
                     errorProviderCantidad.SetError(CantidadTxt, "Ha ocurrido un error del tipo" + e.ToString());
                         exception = true;
                  }
                  catch (OverflowException e)
                  {
                        errorProviderCantidad.SetError(CantidadTxt, "Deje de poner tanta mierda");
                         exception = true;
                  }
              
              }
           }
            if (exception)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Controla el detalle de la factura
        /// </summary>
        private void AddToListView()
        {
            ListViewItem item = null;
            var CollectioPrice = _precioproductohelper.Get();
            var CollectionProducts = _productohelper.ConcatenarProductos();
            var Inventory = _inventariohelper.Inventory();
            foreach (var C in CollectionProducts)
            {
                string search = C.Nombre + " - " + C.IdmarcaNavigation.Nombre;
                if (search.Equals(ProductosTxt.Text))
                {
                    item = ProductosLV.Items.Add(C.Idproducto.ToString());
                    item.SubItems.Add(C.Nombre);
                    item.SubItems.Add(C.IdmarcaNavigation.Nombre);
                    foreach (var I in CollectioPrice)
                    {
                        if (I.IdproductoNavigation.Nombre.Equals(C.Nombre))
                        {
                            item.SubItems.Add(I.Precio.ToString());
                            item.SubItems.Add(CantidadTxt.Text);
                            item.SubItems.Add(I.IdproductoNavigation.IdcategoriaNavigation.Nombre);
                            item.SubItems.Add(subtotal(I.Precio, CantidadTxt.Text).ToString());
                            break;
                        }
                    }
                    break;
                }
            }           
        }
        /// <summary>
        /// Remueve un elemento seleccionado en  la listview 
        /// </summary>
        private void RemoveDetails()
        {
            foreach (ListViewItem item in  ProductosLV.SelectedItems)
            {
                item.Remove();
            }
        }
        /// <summary>
        /// Este metodo inicializa el combobox mediante un servicio que implementa interfaces
        /// </summary>
        private   void SearchProducto()
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            var CollectionProducts = _productohelper.ConcatenarProductos();
            foreach (var iter in CollectionProducts)
            {
                autoComplete.Add($"{iter.Nombre} - {iter.IdmarcaNavigation.Nombre}");
               
            }
            ProductosTxt.AutoCompleteCustomSource = autoComplete;
            ProductosTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ProductosTxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
      
        }

        private void Restrict()
        {
            if (!Existence())
            {
                AddToListView();
            }
        }

        #region Calculos
        private double subtotal(double precio, string Q)
        {
            var sub =   precio * int.Parse(Q);
            return sub;
        }
        #endregion 
       
        #endregion

        #region Events
        private void AgregarBo_Click(object sender, EventArgs e)
        {
            Restrict();

        }
        private void BorrarBo_Click(object sender, EventArgs e)
        {
            RemoveDetails();
        }
        #endregion
    }
}
