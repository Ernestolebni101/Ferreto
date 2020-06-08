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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void Buscar(object sender, EventArgs e)
        {
            Validar();
        }
        #region Validaciones
        public void Validar()
        {
            Regex regexLetras = new Regex(@"^[a-zA-Z]+$");
            if (!regexLetras.IsMatch(BuscarProductoTxt.Text))
            {
                errorProviderletras.
                    SetError(BuscarProductoTxt, ">>Formato no valido!");
            }
            else
                this.errorProviderletras.Clear();
        }
        #endregion
    }
}
