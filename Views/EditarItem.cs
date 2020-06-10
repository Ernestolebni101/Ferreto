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
        public EditarItem()
        {
            InitializeComponent();
            _context = Initializecontext.initcontext();
            _marcahelper = new Helper<Marca>(_context);
            _presentaciohelper = new Helper<Presentacion>(_context);
            _categoriahelper = new Helper<Categoria>(_context);
        }

        private Marca _objmarca;
        private Presentacion _objpresentacion;
        private Categoria _objcategoria;

        #region Methods
         private Marca objmarca()
        {
            _objmarca = new Marca();
            //_objmarca.Nombre = 
            return _objmarca;
        }

        #endregion

        #region Events
        private void Actualizar(object sender, EventArgs e)
        {

        }
        private void Cerrar(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion
    }
}
