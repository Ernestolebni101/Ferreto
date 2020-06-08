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
    public partial class CompraExistente : Form
    {
        public CompraExistente()
        {
            InitializeComponent();
        }
        private void Cerrar(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #region Validacion
        public void Validar()
        {
            bool Letras = false;
            bool Numeros = false;
            //Letras
            Regex RegexProductos = new Regex(@"^[a-z A-Z]+$");
            if (!RegexProductos.IsMatch(ProductoCB.Text))
            {
                errorProviderLetras.
                    SetError(ProductoCB, ">>Formato no valido!");
            }
            else
            {
                Letras = true;
                this.errorProviderLetras.Clear();
            }
            if (!RegexProductos.IsMatch(ProveedorCB.Text))
            {
                errorProviderLetras.
                 SetError(ProveedorCB, ">>Formato no valido!");
            }
            else
            {
                Letras = true;
                this.errorProviderLetras.Clear();
            }
            

            //Numeros
            Regex regexNumeros = new Regex(@"^[0-9]+$");
            if (!regexNumeros.IsMatch(CantidadTxt.Text))
            {
                errorProviderNumero.
                       SetError(CantidadTxt, ">>Formato no valido!");
            }
            else
            {
                Numeros = true;
                this.errorProviderNumero.Clear();
            }
            Regex regexDecimal = new Regex(@"^[+]?[0-9]{1,9}(?:.[0-9]{1,2})?$");
            if (!regexDecimal.IsMatch(CostoUnitarioTxt.Text))
            {
                errorProviderdecimal.
                    SetError(CostoUnitarioTxt, ">>Formato no valido!");
            }
            else
            {
                Numeros = true;
                this.errorProviderdecimal.Clear();
            }
            if (!regexDecimal.IsMatch(NuevoPrecioTxt.Text))
            {
                errorProviderdecimal.
                        SetError(NuevoPrecioTxt, ">>Formato no valido!");
            }
            else
            {
                Numeros = true;
                this.errorProviderdecimal.Clear();
            }
        }
        #endregion

        private void Actualizar(object sender, EventArgs e)
        {
            Validar();
        }
    }
}
