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
        private  Helper<Persona> _personaHelper;
        private  Helper<Proveedores> _proveedorhelper;
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

        }
        private void AñadirBo_Click(object sender, EventArgs e)
        {
            Validar();
            //create();
            //cleantext();
        }
        #endregion
        #region Validar
        public void Validar()
        {
            bool bandera = false;
            //Letras
            Regex regexLetras = new Regex(@"^[a-z A-Z]+$");

            if (!regexLetras.IsMatch(nombretxt.Text))
            {
                ErrorProviderLetras.
                        SetError(nombretxt, ">>Ingrese al menos un nombre");
            }
            else if (!regexLetras.IsMatch(apellidotxt.Text))
            {
                ErrorProviderLetras.
                     SetError(apellidotxt, ">>Ingrese al menos un apellido!");
            }
            else
            {
                bandera = true;
                this.ErrorProviderLetras.Clear();
            }
            //Telefono
            Regex regexTelefono = new Regex(@"^[0-9]{4}(-)[0-9]{4}$");

            if (!regexTelefono.IsMatch(telefonotxt.Text))
            {
                errorProviderTelefono.
                    SetError(telefonotxt, ">>Ingrese correctamente el formato [0000-0000]");
            }
            else
                this.errorProviderTelefono.Clear();

            //Correo
            Regex regexCorreo = new Regex(@"^[^@]+@[^@]+\.[a-zA-Z]{3,}$");

            if (!regexCorreo.IsMatch(correotxt.Text))
            {
                errorProviderCorreo.
                        SetError(correotxt, ">>> Formato de correo incorrecto [algo/alguien@example.com]");
            }
            else
                this.errorProviderCorreo.Clear();
            
            //Cedula
            Regex regexCedula = new Regex(@"^[0-9]{3}(-)[0-9]{6}(-)[0-9A-Z]{5}");
            if (!regexCedula.IsMatch(CedulaTxt.Text))
            {
                errorProviderCedula.
                    SetError(CedulaTxt, ">>> Formato de cedula incorrecto [000-000000-0000Letra]");
            }
            else
                this.errorProviderCedula.Clear();

            //Nombre empresa
            Regex regexEmpresa = new Regex(@"^[a-zA-Z0-9.]+$");
            if (!regexEmpresa.IsMatch(Empresatxt.Text))
            {
                errorProviderEmpresa.
                    SetError(Empresatxt, ">>> Formato incorrecto");
            }
            else
                this.errorProviderEmpresa.Clear();

            //Direccion
            Regex regexDireccione = new Regex(@"^[a-zA-Z0-9/]");
            if (!regexDireccione.IsMatch(direcciontxt.Text))
            {
                errorProviderDireccion.
                    SetError(direcciontxt, ">>> Formato incorrecto");
            }
            else
                this.errorProviderDireccion.Clear();
        }
        #endregion
    }
}
