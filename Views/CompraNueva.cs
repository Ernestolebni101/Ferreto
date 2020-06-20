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
        private Producto _producto;
        private Compra _compra;
        public CompraNueva()
        {
            InitializeComponent();
            _context = Initializecontext.initcontext();
            _productohelper = new Helper<Producto>(_context);
            _comprahelper = new Helper<Compra>(_context);
            _categoriahelper = new Helper<Categoria>(_context);
            _marcahelper = new Helper<Marca>(_context);
            _presentacionhelper = new Helper<Presentacion>(_context);
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
        }
        private Producto NewProduct()
        {
            var ids = Getids();
            _producto = new Producto();
            _producto.Nombre = ProductoTxt.Text;
            _producto.Idmarca = ids._idmarc;
            _producto.Ubicacion = "Zona A";
            _producto.Idcategoria = ids._idcate;
            _producto.Idpresentacion = ids.idpresent;
            return _producto;
        }

        private (int _idcate, int idpresent, int _idmarc) Getids()
        {
            var ids = _categoriahelper.Get();
            var idss = _marcahelper.Get();
            var idsss = _presentacionhelper.Get();
            int idcategoria = 0;
            int idmarca = 0;
            int idpresentacion = 0;
            foreach (var i in ids)
            {
                if (i.Nombre.Equals(CategoriaCB.Text))
                {
                    idcategoria = i.Idcategoria;
                    break;
                }
            }
            foreach (var i in idss)
            {
                if (i.Nombre.Equals(MarcaCB.Text))
                {
                    idmarca = i.Idmarca;
                    break;
                }
            }

            foreach (var o in idsss )
            {
                if (o.Medida.Equals(MedidaCB.Text))
                {
                    idpresentacion = o.Idpresentacion;
                    break;
                }
            }
            return (idcategoria, idpresentacion, idmarca);
        }
        private void Cerrar(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Añadir(object sender, EventArgs e)
        {
            NewProduct();
        }
    }
}
