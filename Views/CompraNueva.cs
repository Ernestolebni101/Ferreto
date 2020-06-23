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
using Ferreto.Common;
using Ferreto.Models;
using Ferreto.Models.Common;
using Ferreto.Services;
using Microsoft.EntityFrameworkCore;

namespace Ferreto.Views
{
    public partial class CompraNueva : Form
    {
        private readonly FerretoSContext _context;
        private readonly Helper<Producto> _productohelper;
        private readonly Helper<Compra> _comprahelper;
        private readonly Helper<Categoria> _categoriahelper;
        private readonly Helper<Marca> _marcahelper;
        private readonly Helper<Presentacion> _presentacionhelper;
        private readonly Helper<Precioproducto> _preciohelper;
        private readonly ServicesInjector<Proveedores> _proveedorhelper;
        private readonly Helper<Usuario> _usuariohelper;
        private readonly Helper<Inventario> _inventariohelper;
        private Producto _producto;
        private Compra _compra;
        private Precioproducto _precio;
        private Inventario _inventario;
        public CompraNueva()
        {
            InitializeComponent();
            _context = Initializecontext.initcontext();
            _productohelper = new Helper<Producto>(_context);
            _comprahelper = new Helper<Compra>(_context);
            _categoriahelper = new Helper<Categoria>(_context);
            _marcahelper = new Helper<Marca>(_context);
            _presentacionhelper = new Helper<Presentacion>(_context);
            _proveedorhelper = new ServicesInjector<Proveedores>(_context);
            _usuariohelper = new Helper<Usuario>(_context);
            _preciohelper = new Helper<Precioproducto>(_context);
            _inventariohelper = new Helper<Inventario>(_context);
            Initialize();
        }

        private void Initialize()
        {
            this.MarcaCB.DataSource = _marcahelper.Get();
            this.MarcaCB.ValueMember = "Idmarca";
            MarcaCB.DisplayMember = "Nombre";
            this.CategoriaCB.DataSource = _categoriahelper.Get();
            CategoriaCB.ValueMember = "Idcategoria";
            CategoriaCB.DisplayMember = "Nombre";
            this.MedidaCB.DataSource = _presentacionhelper.Get();
            this.MedidaCB.ValueMember = "Idpresentacion";
            this.MedidaCB.DisplayMember = "Medida";
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            var Collection = _proveedorhelper.GetProveedores();
            foreach (var iter in Collection)
            {
                autoComplete.Add($"{iter.IdpersonaNavigation.Nombre} - {iter.Empresa}");
            }
            this.ProveedorCb.DataSource = autoComplete;
            ProveedorCb.DisplayMember = "autoComplete";
        }
        private Producto InserNewProduct()
        {
            var ids = Getids();
            _producto = new Producto();
            _producto.Nombre = ProductoTxt.Text;
            _producto.Idmarca = ids.idmarca;
            _producto.Ubicacion = "Sede Central";
            _producto.Idcategoria = ids.idcategoria;
            _producto.Idpresentacion = ids.idpresentacion;
            _producto.Fecharegistro = DateTime.Today;
            _producto.Fvencimiento = VencimientoTP.Value;
            _producto.Estado = true;
            _producto.Codproducto = Utils.codigo;
            return _producto;
        }

        private Precioproducto InsertToTablePrecioProducto(int idproducto)
        {
            _precio = new Precioproducto();
            _precio.Estado = true;
            _precio.Precio = double.Parse(PrecioTxt.Text);
            _precio.Fechacreacion = DateTime.Now;
            _precio.Idproducto = idproducto;
            return _precio;
        }
        private Compra InsertToTableCompras(int idproducto)
        {
            _compra = new Compra();
            _compra.Cantidad = int.Parse(this.CantidadTxt.Text);
            _compra.Costounitario = double.Parse(this.CostoUnitarioTxt.Text);
            _compra.Idusuario = Getids().idusuario;
            _compra.Codproveedor = idprovider();
            _compra.Fechacompra = DateTime.Now;
            _compra.Totalcompra = _compra.Cantidad * Decimal.Parse(_compra.Costounitario.ToString());
            _compra.Idproducto = idproducto;
            return _compra;
        }

        private Inventario InsertToInventario(int cantidad, double costounitario,int idproducto)
        {
            _inventario = new Inventario();
            _inventario.Existencia = cantidad;
            _inventario.Precio = costounitario;
            _inventario.Idproducto = idproducto;
            _inventario.Unidademonetarias = cantidad * decimal.Parse(costounitario.ToString());
            _inventario.Nombreproducto = InserNewProduct().Nombre;
           return _inventario;
        }

        private void Transaction()
        {
            var insertoproduct = _productohelper.add(InserNewProduct());
            var inserttotableprice = _preciohelper.add(InsertToTablePrecioProducto(insertoproduct.Idproducto));
            var insertotablecompra = _comprahelper.add(InsertToTableCompras(insertoproduct.Idproducto));
            var inventario = InsertToInventario(insertotablecompra.Cantidad, insertotablecompra.Costounitario, insertoproduct.Idproducto);
            _inventariohelper.add(inventario);
         }
        private (int idcategoria, int idpresentacion, int idmarca, int idusuario) Getids()
        {
            var Categoricollection = _categoriahelper.Get();
            var MarcaCollection = _marcahelper.Get();
            var PresentacionCollection = _presentacionhelper.Get();
            var ProveedoresCollection = _proveedorhelper.GetProveedores();
            var UsuariosCollection = _usuariohelper.Get();
            int idcategoria = 0;
            int idmarca = 0;
            int idpresentacion = 0;
            int idprovider = 0;
            int idusuario = 0;


            foreach (var i in Categoricollection)
            {
                if (i.Nombre.Equals(CategoriaCB.Text))
                {
                    idcategoria = i.Idcategoria;
                    break;
                }
            }
            foreach (var i in MarcaCollection)
            {
                if (i.Nombre.Equals(MarcaCB.Text))
                {
                    idmarca = i.Idmarca;
                    break;
                }
            }

            foreach (var o in PresentacionCollection)
            {
                if (o.Medida.Equals(MedidaCB.Text))
                {
                    idpresentacion = o.Idpresentacion;
                    break;
                }
            }
            foreach (var item in ProveedoresCollection)
            {
                if (item.IdpersonaNavigation.Nombre.Contains(ProveedorCb.Text))
                {
                    idprovider = item.Idproveedor;
                }
            }
            foreach (var item in UsuariosCollection)
            {
                if (item.Login.Equals(UserLabel.Text))
                {
                    idusuario = item.Idusuario;
                    break;
                }
            }
            return (idcategoria, idpresentacion, idmarca, idusuario);
        }

        private int idprovider()
        {
            var ProveedoresCollection = _proveedorhelper.GetProveedores();
            int idprovider = 0;
            string str = string.Empty;

            for (int i = 0; i < ProveedorCb.Text.Length; i++)
            {
                if (ProveedorCb.Text[i] == ' ')
                {
                    for (int j = 0; j < i; j++)
                    {
                        str = str + ProveedorCb.Text[j];
                    }
                    break;
                }
            }
            string prueba = str;
            foreach (var item in ProveedoresCollection)
            {
                if (item.IdpersonaNavigation.Nombre.Contains(str))
                {
                    idprovider = item.Idproveedor;
                    break;
                }
            }
            return idprovider;
        }
        private void Cerrar(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Añadir(object sender, EventArgs e)
        {
            Transaction();
        }
    }
}
