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
    public partial class EditarItem : Form
    {
        private readonly FerretoSContext _context;
        private readonly Helper<Marca> _marcahelper;
        private readonly Helper<Presentacion> _presentaciohelper;
        private readonly Helper<Categoria> _categoriahelper;
        private readonly Helper<Rol> _rolhelper;
        public EditarItem()
        {
            InitializeComponent();
            _context = Initializecontext.initcontext();
            _marcahelper = new Helper<Marca>(_context);
            _presentaciohelper = new Helper<Presentacion>(_context);
            _categoriahelper = new Helper<Categoria>(_context);
            _rolhelper = new Helper<Rol>(_context);
            initCb();

        }

        private Marca _objmarca;
        private Presentacion _objpresentacion;
        private Categoria _objcategoria;
        private Rol _rol;
        #region Methods
        private void Añadirmarca()
        {
            _objmarca = new Marca();
            _objmarca.Nombre = MarcaTxt.Text;
            _objmarca.Estado = true;
            _marcahelper.add(_objmarca);
        }

        private void Añadircategoria()
        {
            _objcategoria = new Categoria();
            _objcategoria.Nombre = this.CategoriaTxt.Text;
            _categoriahelper.add(_objcategoria);
        }
        private void AñadirMedida()
        {
            _objpresentacion = new Presentacion();
            _objpresentacion.Medida = this.MedidaTxt.Text;
            _presentaciohelper.add(_objpresentacion);
        }

        private void AñadirRol()
        {
            _rol = new Rol();
            _rol.Nombrerol = this.RolTxt.Text;
            _rol.Estado = true;
            _rolhelper.add(_rol);
        }
        private void initCb()
        {
            /// inicializar marcas
            MarcaCB.DataSource = _marcahelper.Get();
            MarcaCB.ValueMember = "Idmarca";
            MarcaCB.DisplayMember = "Nombre";
            // inicializar roles
            RolCB.DataSource = _rolhelper.Get();
            RolCB.ValueMember = "Idrol";
            RolCB.DisplayMember = "Nombrerol";
        }

        private (int idmarca, int idrol) Getids()
        {
            int id = int.Parse(MarcaCB.SelectedValue.ToString());
            int idrl = int.Parse(RolCB.SelectedValue.ToString());
            return (id, idrl);
        }

        private void Actions(int accion)
        {
            var ids = Getids();
            switch (accion)
            {
                case 0:
                    _marcahelper.Editaritem(1, ids.idmarca);
                    break;
                case 1:
                    _marcahelper.Editaritem(2, ids.idmarca);
                    break;
                case 2:
                    _rolhelper.Editaritem(3, 0, ids.idrol);
                    break;
                case 3:
                    _rolhelper.Editaritem(4, 0, ids.idrol);
                    break;
            }
        }

        private void Verifybool()
        {
            if (estadomarcasl.IsOn)
                this.Actions(0);
            else if (!estadomarcasl.IsOn)
                this.Actions(1);
            if (estadorolsl.IsOn)
                this.Actions(2);
            else if (!estadorolsl.IsOn)
                this.Actions(3);
            if (nuevamedida.IsOn)
                this.AñadirMedida();
            if (marcanueva.IsOn)
                Añadirmarca();
            if (categorianueva.IsOn)
                Añadircategoria();
            if (nuevorol.IsOn)
                AñadirRol();
        }

        #endregion

        #region Events
        private void Actualizar(object sender, EventArgs e)
        {
            Verifybool();
        }
        private void Cerrar(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        private void Marca()
        {
            if (Slidermarca.IsOn)
            {
                MarcaCB.Enabled = true;
                estadomarcasl.Enabled = true;
                ActualizarBo.Enabled = true;
                //Block
                RolCB.Enabled = false;
                estadorolsl.Enabled = false;
                MarcaTxt.Enabled = false;
                RolTxt.Enabled = false;
                CategoriaTxt.Enabled = false;
                MedidaTxt.Enabled = false;
                //Block sli
                Sliderol.IsOn = false;
                marcanueva.IsOn = false;
                nuevorol.IsOn = false;
                categorianueva.IsOn = false;
                nuevamedida.IsOn = false;
            }
            else
                ActualizarBo.Enabled = false;

        }

        private void NewMarca()
        {
            if (marcanueva.IsOn)
            {
                MarcaTxt.Enabled = true;
                ActualizarBo.Enabled = true;
                //Block
                RolCB.Enabled = false;
                estadorolsl.Enabled = false;
                MarcaCB.Enabled = false;
                RolTxt.Enabled = false;
                CategoriaTxt.Enabled = false;
                MedidaTxt.Enabled = false;
                //Block sli
                Sliderol.IsOn = false;
                Slidermarca.IsOn = false;
                nuevorol.IsOn = false;
                categorianueva.IsOn = false;
                nuevamedida.IsOn = false;
            }
            else
                ActualizarBo.Enabled = false;
        }

        private void Rol()
        {
            if (Sliderol.IsOn)
            {
                RolCB.Enabled = true;
                estadorolsl.Enabled = true;
                ActualizarBo.Enabled = true;
                //Block
                MarcaCB.Enabled = false;
                estadomarcasl.Enabled = false;
                MarcaTxt.Enabled = false;
                CategoriaTxt.Enabled = false;
                RolTxt.Enabled = false;
                MedidaTxt.Enabled = false;
                //Block Sli
                Slidermarca.IsOn = false;
                marcanueva.IsOn = false;
                categorianueva.IsOn = false;
                nuevorol.IsOn = false;
                nuevamedida.IsOn = false;
            }
            else
                ActualizarBo.Enabled = false;
        }

        private void NewRol()
        {
            if (nuevorol.IsOn)
            {
                RolTxt.Enabled = true;
                ActualizarBo.Enabled = true;
                //Block
                MarcaCB.Enabled = false;
                estadomarcasl.Enabled = false;
                RolCB.Enabled = false;
                estadorolsl.Enabled = false;
                MarcaTxt.Enabled = false;
                CategoriaTxt.Enabled = false;
                MedidaTxt.Enabled = false;
                //Block Sli
                Slidermarca.IsOn = false;
                Sliderol.IsOn = false;
                marcanueva.IsOn = false;
                categorianueva.IsOn = false;
                nuevamedida.IsOn = false;
            }
            else
                ActualizarBo.Enabled = false;
        }

        private void NewCat()
        {
            if (categorianueva.IsOn)
            {
                CategoriaTxt.Enabled = true;
                ActualizarBo.Enabled = true;
                //Block
                MarcaCB.Enabled = false;
                MarcaTxt.Enabled = false;
                RolCB.Enabled = false;
                RolTxt.Enabled = false;
                MedidaTxt.Enabled = false;
                //block sli
                Slidermarca.IsOn = false;
                marcanueva.IsOn = false;
                Sliderol.IsOn = false;
                nuevorol.IsOn = false;
                nuevamedida.IsOn = false;
            }
            else
                ActualizarBo.Enabled = false;
        }

        private void NewMedida()
        {
            if (nuevamedida.IsOn)
            {
                MedidaTxt.Enabled = true;
                ActualizarBo.Enabled = true;
                //Block
                MarcaCB.Enabled = false;
                estadomarcasl.Enabled = false;
                RolCB.Enabled = false;
                estadorolsl.Enabled = false;
                MarcaTxt.Enabled = false;
                RolTxt.Enabled = false;
                CategoriaTxt.Enabled = false;
                //Block Sli
                Slidermarca.IsOn = false;
                Sliderol.IsOn = false;
                marcanueva.IsOn = false;
                nuevorol.IsOn = false;
                categorianueva.IsOn = false;
            }
            else
                ActualizarBo.Enabled = false;
        }

        private void MarcoCheck(object sender, EventArgs e)
        {
            Marca();
        }

        private void NewMarca(object sender, EventArgs e)
        {
            NewMarca();
        }

        private void Rol(object sender, EventArgs e)
        {
            Rol();
        }

        private void NewRol(object sender, EventArgs e)
        {
            NewRol();
        }

        private void NewCat(object sender, EventArgs e)
        {
            NewCat();
        }

        private void NewMedida(object sender, EventArgs e)
        {
            NewMedida();
        }
    }
}
