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
    public partial class EditarCuenta : Form
    {
        public EditarCuenta()
        {
            InitializeComponent();
        }

        private void Cerrar(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #region Validaciones
        public void validar()
        {
            //Que el usuario no este vacio
            Regex regexVacios = new Regex(@"^[a-zA-Z 0-9]+$");
            if (!regexVacios.IsMatch(UsuarioCB.Text))
            {
                errorProviderVacios.
                        SetError(UsuarioCB, ">>Formato no valido!");
            }
            else
                this.errorProviderVacios.Clear();

            //Letras
            Regex regexLetras = new Regex(@"^[a-zA-Z]+$");
            if (!regexLetras.IsMatch(nombreUsuarioTxt.Text))
            {
                errorProviderLetras.
                    SetError(nombreUsuarioTxt, ">>Formato no valido!");
            }
            else
                this.errorProviderLetras.Clear();
            if (!regexLetras.IsMatch(nuevorolCB.Text))
            {
                errorProviderLetras.
                    SetError(nuevorolCB, ">>Formato no valido!");
            }
            else
                this.errorProviderLetras.Clear();

        //Contraseña falta tuve un pequeño problema
        }
        #endregion

        private void Actualizar(object sender, EventArgs e)
        {
            validar();
        }
    }
}
