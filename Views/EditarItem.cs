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
    public partial class EditarItem : Form
    {
        public EditarItem()
        {
            InitializeComponent();
        }

        private void Cerrar(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #region validaciones
        public void validar()
        {
            Regex regexLetras = new Regex(@"[a-zA-Z]+$");
            if (!regexLetras.IsMatch(MarcaCB.Text))
            {
                errorProviderLeytras.
                    SetError(MarcaCB, ">>Formato no valido!");
            }
            else
                this.errorProviderLeytras.Clear();
            if (!regexLetras.IsMatch(MarcaTxt.Text))
            {
                errorProviderLeytras.
                    SetError(MarcaTxt, ">>Formato no valido!");
            }
            else
                this.errorProviderLeytras.Clear();
            if (!regexLetras.IsMatch(CategoriaCB.Text))
            {
                errorProviderLeytras.
                    SetError(CategoriaCB, ">>Formato no valido!");
            }
            else
                this.errorProviderLeytras.Clear();
            if (!regexLetras.IsMatch(CategoriaTxt.Text))
            {
                errorProviderLeytras.
                    SetError(CategoriaTxt, ">>Formato no valido!");
            }
            else
                this.errorProviderLeytras.Clear();
            if (!regexLetras.IsMatch(RolCB.Text))
            {
                errorProviderLeytras.
                    SetError(RolCB, ">>Formato no valido!");
            }
            else
                this.errorProviderLeytras.Clear();
            if (!regexLetras.IsMatch(RolTxt.Text))
            {
                errorProviderLeytras.
                    SetError(RolTxt, ">>Formato no valido!");
            }
            else
                this.errorProviderLeytras.Clear();

            //Numeros
            Regex regexNumeros = new Regex(@"^[+]?[0-9]{1,9}(?:.[0-9]{1,2})?$");
            if (!regexNumeros.IsMatch(MedidaCB.Text))
            {
                errorProviderNumero.
                    SetError(MedidaCB, ">>Formate no valido!");
            }
            else
                this.errorProviderNumero.Clear();
            if (!regexNumeros.IsMatch(MedidaTxt.Text))
            {
                errorProviderNumero.
                    SetError(MedidaTxt, ">>Formate no valido!");
            }
            else
                this.errorProviderNumero.Clear();

        }
        #endregion

        private void Actualizar(object sender, EventArgs e)
        {
            validar();
        }
    }
}
