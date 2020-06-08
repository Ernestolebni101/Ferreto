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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        #region Validaciones
        public void validar()
        {
            //Datos personales
            bool bandera = false;
            //Letras
            Regex regexLetras = new Regex(@"^[a-z A-Z]+$");

            if (!regexLetras.IsMatch(NombreTxt.Text))
            {
                 bandera = false;
                ErrorProviderLetras.
                        SetError(NombreTxt, ">>Ingrese al menos un nombre");
            }
            else
            {
                bandera = true;
                this.ErrorProviderLetras.Clear();
            }
            if (!regexLetras.IsMatch(ApellidoTxt.Text))
            {
                bandera = false;
                ErrorProviderLetras.
                     SetError(ApellidoTxt, ">>Ingrese al menos un apellido!");
            }
            else
            {
                bandera = true;
                this.ErrorProviderLetras.Clear();
            }
            if (!regexLetras.IsMatch(RolCB.Text))
            {
                bandera = false;
                ErrorProviderLetras.
                        SetError(RolCB, ">>Ingrese al menos un nombre");
            }
            else
            {
                bandera = true;
                this.ErrorProviderLetras.Clear();
            }
            //Telefono
            Regex regexTelefono = new Regex(@"^[0-9]{4}(-)[0-9]{4}$");

            if (!regexTelefono.IsMatch(TelefonoTxt.Text))
            {
                errorProviderTelefono.
                    SetError(TelefonoTxt, ">>Ingrese correctamente el formato [0000-0000]");
            }
            else
                this.errorProviderTelefono.Clear();

            //Correo
            Regex regexCorreo = new Regex(@"^[^@]+@[^@]+\.[a-zA-Z]{3,}$");

            if (!regexCorreo.IsMatch(CorreoTxt.Text))
            {
                errorProviderCorreo.
                        SetError(CorreoTxt, ">>> Formato de correo incorrecto [algo/alguien@example.com]");
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
            //Direccion
            Regex regexDireccione = new Regex(@"^[a-zA-Z0-9/]");
            if (!regexDireccione.IsMatch(direcciontxt.Text))
            {
                errorProviderDireccion.
                    SetError(direcciontxt, ">>> Formato incorrecto");
            }
            else
                this.errorProviderDireccion.Clear();

            //Code
            Regex regexCode = new Regex(@"^[a-zA-Z0-9]+$");
            if (!regexCode.IsMatch(FerretoCodeTxt.Text))
            {
                errorProvidercode.
                    SetError(FerretoCodeTxt, ">> Formato no valido!");
            }
            else
                this.errorProvidercode.Clear();
            if (!regexCode.IsMatch(UsuarioTxt.Text))
            {
                errorProvidercode.
                    SetError(UsuarioTxt, ">> Formato no valido!");
            }
            else
                this.errorProvidercode.Clear();

        }
        #endregion

        private void Registrar(object sender, EventArgs e)
        {
            validar();
        }
    }
}
