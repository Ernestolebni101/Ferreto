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
            if (Validar())
            {
                create();
                cleantext();
            }
        }
        #endregion
        #region Validar
        public bool Validar()
        {
            ValidatorAligator.ReValidate.ValidarNombre(nombretxt,ErrorProviderNombre);
            ValidatorAligator.ReValidate.ValidarApellido(apellidotxt,errorProviderApellidos);
            ValidatorAligator.ReValidate.ValidarTelefono(telefonotxt,errorProviderTelefono);
            ValidatorAligator.ReValidate.ValidarCorreo(correotxt,errorProviderCorreo);
            ValidatorAligator.ReValidate.ValidarCedula(CedulaTxt,errorProviderCedula);
            ValidatorAligator.ReValidate.ValidarVacios(Empresatxt,errorProviderEmpresa);
            ValidatorAligator.ReValidate.ValidarDireccion(direcciontxt,errorProviderDireccion);
            if (ValidatorAligator.ReValidate.ValidarNombre(nombretxt, ErrorProviderNombre) == true && ValidatorAligator.ReValidate.ValidarApellido(apellidotxt, errorProviderApellidos) == true &&
                ValidatorAligator.ReValidate.ValidarTelefono(telefonotxt, errorProviderTelefono) == true && ValidatorAligator.ReValidate.ValidarCorreo(correotxt, errorProviderCorreo) == true &&
                ValidatorAligator.ReValidate.ValidarCedula(CedulaTxt, errorProviderCedula) == true && ValidatorAligator.ReValidate.ValidarVacios(Empresatxt, errorProviderEmpresa) == true &&
                ValidatorAligator.ReValidate.ValidarDireccion(direcciontxt, errorProviderDireccion) == true)
                return true;
            else
                return false;
        }
        #endregion
    }
}
