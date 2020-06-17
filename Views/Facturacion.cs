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
        int _cantidad;
        private readonly Helper<Producto> _productohelper;
        private readonly Helper<Precioproducto> _precioproductohelper;
        private readonly Helper<Catalogo> _inventariohelper;
        private readonly Helper<Detallefactura> _detallefacturahelper;
        private readonly Helper<Factura> _facturahelper;
        private readonly Helper<Usuario> _usuariohelper;
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
            _inventariohelper = new Helper<Catalogo>(_context);
            _usuariohelper = new Helper<Usuario>(_context);
            SearchProducto();
        }
        private Detallefactura _detallefactura;
        private List<Detallefactura> SortedList = new List<Detallefactura>();
        private Factura _factura;
        private List<Detallefactura> UpdateList(int accion = 0, int Q = 0)
        {
            _detallefactura.Idfactura = ReturnIdF();
            switch (accion)
            {
                case 0:
                    SortedList.Add(_detallefactura);
                    break;
                case 1:
                    SortedList.RemoveAll(x => x.Cantidad == Q);
                    break;
            }
            return SortedList;
        }
        private List<Detallefactura> UpdateList()
        {
            return SortedList;
        }
        #region Methods
        private int GetId()
        {
            int id = 0;
            string login = this.UserLab.Text;
            var usuarios = _usuariohelper.Get();
            foreach (var U in usuarios)
            {
                if (login.Equals(U.Login))
                {
                    id = U.Idusuario;
                    break;
                }
            }
            return id;
        }
        private bool Existence()
        {
            var Collections = _inventariohelper.Inventory();
            bool exception = false;

            foreach (var item in Collections)
            {
                string search = item.IdproductoNavigation.Nombre + " - " + item.IdproductoNavigation.IdmarcaNavigation.Nombre;
                if (search.Equals(ProductosTxt.Text))
                {
                    try
                    {
                        _cantidad = int.Parse(CantidadTxt.Text);
                        if (_cantidad <= item.Existencia)
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
        private void ValidateSubitem()
        {
            bool retorno = false;
            var confirm = ProductosTxt.Text;

            if (conteoclicks > 1)
            {
                foreach (ListViewItem item in ProductosLV.Items)
                {
                    int index = ProductosLV.SelectedIndices.Count;
                    if (confirm.Contains(item.SubItems[1].Text))
                    {
                        retorno = true;
                        break;
                    }

                    else
                    {
                        retorno = false;
                        break;
                    }

                }
            }

            if (retorno)
            {
                MessageBox.Show("Me valida productos repetidos");
            }
            else
            {
                MessageBox.Show("producto no repetido");
            }
        }
        /// <summary>
        /// Controla el detalle de la factura
        /// </summary>
        public double _total = 0;
        public double _Iva = 0;
        public double _neto = 0;
        private void AddToListView()
        {
            ListViewItem item = null;
            var CollectioPrice = _precioproductohelper.Get();
            var CollectionProducts = _productohelper.ConcatenarProductos();
            var Inventory = _inventariohelper.Inventory();
            _cantidad = int.Parse(CantidadTxt.Text);
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
                            item.SubItems.Add(_cantidad.ToString());
                            item.SubItems.Add(I.IdproductoNavigation.IdcategoriaNavigation.Nombre);
                            item.SubItems.Add(subtotal(I.Precio, _cantidad).ToString());
                            _total += subtotal(I.Precio, _cantidad);
                            UpdateQuantity(C.Nombre, 0);
                            _detallefactura = new Detallefactura();
                            _detallefactura.Cantidad = _cantidad;
                            _detallefactura.Idproducto = C.Idproducto;
                            _detallefactura.Precioventa = I.Precio;
                            UpdateList(0, _cantidad);
                            break;
                        }
                    }
                    break;
                }

            }
            BaseLab.Text = _total.ToString();
            IvaLab.Text = (_total * 0.15).ToString();
            NetoLab.Text = (_total + (_total * 0.15)).ToString();
            _Iva = _total * 0.15;
            _neto = _total + (_total * 0.15);
        }

        private int ReturnIdF()
        {
            int id = 0;
            var Generic = _facturahelper.Get();
            
            foreach (var iter in Generic.OrderByDescending(x=> x.Idfactura).Take(1))
            {
                id = iter.Idfactura;
            }
            return id;
        }
        private Factura FacturaInsert()
        {
            _factura = new Factura();
            _factura.Idusuario = GetId();
            _factura.Totalsiniva = decimal.Parse(this.BaseLab.Text);
            _factura.Iva = double.Parse(this.IvaLab.Text);
            _factura.Totalmasiva = decimal.Parse(this.NetoLab.Text);
            _factura.Nserie = _factura.Idfactura.ToString().PadLeft(1, '0') + ReturnIdF().ToString();
            _factura.Fechafacturacion = DateTime.Now;
            _factura.Nombreusuario = this.UserLab.Text;
            _facturahelper.add(_factura);
            return _factura;
        }
        /// <summary>
        /// Este metodo me actualiza la cantidad de cada producto en el inventario
        /// </summary>
        private void UpdateQuantity(string articulo, int accion)
        {
            var Inventario = _inventariohelper.Inventory();

            switch (accion)
            {
                case 0:
                    foreach (var item in Inventario)
                    {
                        if (item.IdproductoNavigation.Nombre.Equals(articulo))
                        {
                            item.Existencia -= _cantidad;
                            break;
                        }
                    }
                    break;
                case 1:
                    foreach (var item in Inventario)
                    {
                        if (item.IdproductoNavigation.Nombre.Equals(articulo))
                        {
                            item.Existencia += _cantidad;
                            break;
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// Remueve un elemento seleccionado en  la listview 
        /// </summary>
        private void RemoveDetails()
        {
            if (ProductosLV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para eliminarla", "Fila no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (ListViewItem item in ProductosLV.SelectedItems)
                {
                    _total -= double.Parse(item.SubItems[6].Text);
                    item.Remove();
                    UpdateQuantity(item.SubItems[1].Text, 1);
                    UpdateList(1, int.Parse(item.SubItems[4].Text));
                }
                BaseLab.Text = _total.ToString();
                IvaLab.Text = (_total * 0.15).ToString();
                NetoLab.Text = (_total + (_total * 0.15)).ToString();
            }

        }
        /// <summary>
        /// Este metodo inicializa el Textbox mediante un servicio que implementa interfaces
        /// </summary>
        private void SearchProducto()
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
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
            if (string.IsNullOrWhiteSpace(ProductosTxt.Text) && string.IsNullOrWhiteSpace(CantidadTxt.Text))
            {
                MessageBox.Show("Busque un producto e ingrese su cantidad para añadirlo a su compra", "No se agregó ningún elemento", MessageBoxButtons.OK);
            }
            if (!Existence())
            {
                AddToListView();
            }

        }

        #endregion

        #region Calculos
        private double subtotal(double precio, int Q)
        {
            var sub = precio * Q;
            return sub;
        }
        #endregion

        #region Events
        int conteoclicks = 1;
        private void AgregarBo_Click(object sender, EventArgs e)
        {
            Restrict();
            //ValidateSubitem();
            conteoclicks++;
        }
        private void BorrarBo_Click(object sender, EventArgs e)
        {
            RemoveDetails();
            conteoclicks--;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.FechaLab.Text = DateTime.Now.ToString();
        }
        private void Facturacion_Load_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        #endregion

        private void ImprimirBo_Click(object sender, EventArgs e)
        {
            if (ProductosLV.Items.Count != 0)
            {
                FacturaInsert();
                _detallefacturahelper.AddDetails(UpdateList());
                FPrintFactura obj = new FPrintFactura(ProductosLV, _total, _Iva, _neto);
                obj.ShowDialog();
            }
            else
                MessageBox.Show("Debe añadir uno o varios productos \n antes de generar factura", "No se añadió ningun producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
