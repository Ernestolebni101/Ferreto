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
    public partial class ReimprimirBo : Form
    {
        public ReimprimirBo()
        {
            InitializeComponent();
        }
        #region Valaciones
        public void validar()
        {
            //Letras
            Regex regexLetras = new Regex(@"^[a-zA-Z]+$");
            if (!regexLetras.IsMatch(CajeroCB.Text))
            {
                errorProviderLetras.
                    SetError(CajeroCB, ">> Formato no valido!");
            }
            else
                this.errorProviderLetras.Clear();
            //Numeros
            Regex regexNumero = new Regex(@"^[0-9]+$");
            if (!regexNumero.IsMatch(SerieCB.Text))
            {
                errorProviderSerie.
                    SetError(SerieCB, ">> Formato no valido!");
            }
            else
                this.errorProviderSerie.Clear();
        }
        #endregion

        private void Buscar(object sender, EventArgs e)
        {
            validar();
        }
    }
}
