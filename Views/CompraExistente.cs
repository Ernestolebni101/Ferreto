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
using ValidatorAligator;

namespace Ferreto.Views
{
    public partial class CompraExistente : Form
    {
        private readonly FerretoSContext _context;
        private readonly Helper<Compra> _comprahelper;
        private readonly ServicesInjector<Producto> _productoservices;
        private readonly ServicesInjector<Proveedores> _proveedorservices;
        private readonly ServicesInjector<Inventario> _inventarioservices;
        private readonly ServicesInjector<Compra> _compraservices;
        private readonly ServicesInjector<Precioproducto> _precioservices;
        Compra _compra;
        Inventario _inventario;
        Precioproducto _precio;
        public CompraExistente()
        {
            InitializeComponent();
            _context = Initializecontext.initcontext();
            _productoservices = new ServicesInjector<Producto>(_context);
            _proveedorservices = new ServicesInjector<Proveedores>(_context);
            _inventarioservices = new ServicesInjector<Inventario>(_context);
            _compraservices = new ServicesInjector<Compra>(_context);
            _precioservices = new ServicesInjector<Precioproducto>(_context);
            _comprahelper = new Helper<Compra>(_context);
            Init();
        }
        #region Methods

        private (int idproducto,int idprovider,int idusuario, string nombreproveedor,string nombreusuario)GetId()
        {
            var Collection = _productoservices.ConsultProduct();
            var Icollection = _proveedorservices.GetInfo();
            int idproducto = 0;
            int idproveedor = 0;
            int iduser = 0;
            string nombrep = string.Empty;
            string nombreu = string.Empty;
            foreach (var item in Collection)
            {
                string c = $"{item.Nombre} - {item.IdmarcaNavigation.Nombre}";
                if (c.Equals(ProductoCB.Text))
                {
                    idproducto = item.Idproducto;
                    break;
                }
            }
            foreach (var item in Icollection.proveedores)
            {
                string N = $"{item.IdpersonaNavigation.Nombre} - {item.Empresa}";
                if (N.Equals(ProveedorCB.Text))
                {
                    idproveedor = item.Idproveedor;
                    nombrep = item.IdpersonaNavigation.Nombre;
                    break;
                }
            }
            foreach (var item in Icollection.usuarios)
            {
                if (item.Login.Equals(UserLabel.Text))
                {
                    iduser = item.Idusuario;
                    nombreu = item.IdpersonaNavigation.Nombre;
                    break;
                }
            }
            return (idproducto,idproveedor,iduser,nombrep,nombreu);
        }

        private Compra InsertToCompras()
        {
            _compra = new Compra();
            _compra.Cantidad = int.Parse(CantidadTxt.Text);
            _compra.Idproducto = GetId().idproducto;
            _compra.Fechacompra = DateTime.Now;
            _compra.Idusuario = GetId().idusuario;
            _compra.Nombreusuario = GetId().nombreusuario;
            _compra.Codproveedor = GetId().idprovider;
            _compra.Nombreproveedor = GetId().nombreproveedor;
            _compra.Costounitario = double.Parse(CostoUnitarioTxt.Text);
            _compra.Totalcompra = _compra.Cantidad * Decimal.Parse(_compra.Costounitario.ToString());
            return _compra;
        }

        private Precioproducto AlterPrice()
        {
            _precio = new Precioproducto();
            _precio.Idproducto = GetId().idproducto;
            _precio.Precio = double.Parse(this.NuevoPrecioTxt.Text);
            return _precio;
        }

        private Inventario AlterInventario(int existencia)
        {
            var variable = _inventarioservices.ConsultInventory().Single(x => x.Idproducto.Equals(GetId().idproducto));
            double costoantiguo = variable.Precio;
            _inventario = new Inventario();
            _inventario.Existencia = existencia;
            _inventario.Idproducto = GetId().idproducto;
          double  promedio = (costoantiguo + double.Parse(CostoUnitarioTxt.Text)) / 2;
            _inventario.Precio = promedio;     
            return _inventario;
        }
        private void UpdateChanges()
        {
            var compra = _comprahelper.add(InsertToCompras());
             _inventarioservices.AlterInventario(AlterInventario(compra.Cantidad));
            _precioservices.AlterPrice(AlterPrice());
        }
        private void Init()
        {
            //combobox productos
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            var collectionproducts = _productoservices.ConsultProduct();
            foreach (var iter in collectionproducts)
            {
                autoComplete.Add($"{iter.Nombre} - {iter.IdmarcaNavigation.Nombre}");
            }
            this.ProductoCB.DataSource = autoComplete;
            ProductoCB.DisplayMember = "autoComplete";
            // combobox proveedores
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            var Collection = _proveedorservices.GetProveedores();
            foreach (var iter in Collection)
            {
                auto.Add($"{iter.IdpersonaNavigation.Nombre} - {iter.Empresa}");
            }
            this.ProveedorCB.DataSource = auto;
            ProveedorCB.DisplayMember = "auto";
        }
        #endregion

        #region Events
        private void Cerrar(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Clean()
        {
            CantidadTxt.Text = string.Empty;
            NuevoPrecioTxt.Text = string.Empty;
            CostoUnitarioTxt.Text = string.Empty;
        }
        private void Actualizar(object sender, EventArgs e)
        {
            if (Validation())
            {
                UpdateChanges();
                Clean();
            }
        }
        #endregion
        #region Validacion
        private bool Validation()
        {
            ValidatorAligator.ReValidate.ValidarNumeros(CantidadTxt,errorProviderCantidadActual);
            ValidatorAligator.ReValidate.ValidarDecimal(CostoUnitarioTxt,errorProviderCostoU);
            ValidatorAligator.ReValidate.ValidarDecimal(NuevoPrecioTxt,errorProviderNuevopre);

            if (ValidatorAligator.ReValidate.ValidarNumeros(CantidadTxt, errorProviderCantidadActual) == true &&
                ValidatorAligator.ReValidate.ValidarDecimal(CostoUnitarioTxt, errorProviderCostoU) == true &&
                ValidatorAligator.ReValidate.ValidarDecimal(NuevoPrecioTxt, errorProviderNuevopre) == true)
                return true;
            else
                return false;
        }
        #endregion
    }
}
