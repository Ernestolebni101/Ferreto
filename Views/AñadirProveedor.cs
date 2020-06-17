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
using ValidatorAligator;

namespace Ferreto.Views
{
    public partial class AñadirProveedor : Form
    {
        #region metods
        private Helper<Persona> _personaHelper;
        private Helper<Proveedores> _proveedorhelper;
        private readonly FerretoSContext _contex;
        public AñadirProveedor()
        {
            InitializeComponent();
            _contex = Initializecontext.initcontext();
            _personaHelper = new Helper<Persona>(_contex);
            _proveedorhelper = new Helper<Proveedores>(_contex);
        }

        private Persona Per;
        private Proveedores Pro;

        private void create()
        {
            Per = new Persona();
            Per.Nombre = nombretxt.Text;
            Per.Apellido = apellidotxt.Text;
            Per.Direccion = direcciontxt.Text;
            Per.Telefono = telefonotxt.Text;
            Per.Email = this.correotxt.Text;
            Per.Cedula = CedulaTxt.Text;
            _personaHelper.add(Per);
            /// <Suma>
            /// Proceso de creacion de un proveedor a travez del Idpersona
            /// </Suma>
            Pro = new Proveedores();
            Pro.Idpersona = Per.Idpersona;
            Pro.Empresa = Empresatxt.Text;
            Pro.Estado = true;
            DataforProvider(Pro);
        }

        private void DataforProvider(Proveedores pro)
        {
            _proveedorhelper.add(pro);
        }
        #endregion
        #region Events
        private void Cerrar(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cleantext()
        {
            this.nombretxt.Text = string.Empty;
            this.apellidotxt.Text = string.Empty;
            this.correotxt.Text = string.Empty;
            this.Empresatxt.Text = string.Empty;
            this.direcciontxt.Text = string.Empty;
            this.telefonotxt.Text = string.Empty;
            this.CedulaTxt.Text = string.Empty;
        }
        private void AñadirBo_Click(object sender, EventArgs e)
        {
            create();
            cleantext();
        }
        #endregion
        #region Validar
        //public bool Validar()
        //{

        //}
        #endregion
    }
}
