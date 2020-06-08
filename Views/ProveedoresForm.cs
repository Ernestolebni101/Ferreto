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
    public partial class ProveedoresForm : Form
    {
        public ProveedoresForm()
        {
            InitializeComponent();
        }

        private void AñadirBo_Click(object sender, EventArgs e)
        {
            AñadirProveedor obj = new AñadirProveedor();
            obj.ShowDialog();
        }

        private void Buscarpro(object sender, EventArgs e)
        {
            validar();
        }
        #region Validaciones
        public void validar()
        {
            Regex regexLetras = new Regex(@"^[a-zA-Z]+$");
            if (!regexLetras.IsMatch(BuscarProveedorTxt.Text))
            {
                errorProviderletras.
                    SetError(BuscarProveedorTxt, ">>Formato no valido!");
            }
            else
                this.errorProviderletras.Clear();
        }
        #endregion
        //public string Empresa { get;  set; }
        //public int Idpersona { get;  set; }
        //public bool Estado { get;  set; }
    }
}
