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
using Ferreto.Models;
using Ferreto.Models.Common;
using Ferreto.Services;
using Microsoft.EntityFrameworkCore;

namespace Ferreto.Views
{
    public partial class CompraNueva : Form
    {
        public CompraNueva()
        {
            InitializeComponent();
           
        }

        private void Cerrar(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //private void initcb()
        //{
        //    var optionsbuilder = new DbContextOptionsBuilder<FerretoSContext>();
        //    optionsbuilder.UseSqlServer(Parameter.Connectionstring);

        //    var context = new FerretoSContext(optionsbuilder.Options);

        //    var proveedorservice = new ProveedorService(context);
        //    using (context)
        //    {
        //        ProveedorCB.DataSource = proveedorservice.GetAll();
        //        ProveedorCB.ValueMember = "Idproveedor";
        //        ProveedorCB.DisplayMember = "IdpersonaNavigation";
        //    }       

        #region Validacion
        public void Validar()
        {
            //letras
            Regex regexLetras = new Regex(@"^[a-zA-Z]+$");
            if (!regexLetras.IsMatch(ProductoTxt.Text))
            {
                errorProviderLetras.
                    SetError(ProductoTxt, ">>Formato no valido!");
            }
            else
                this.errorProviderLetras.Clear();
            if (!regexLetras.IsMatch(MarcaCB.Text))
            {
                errorProviderLetras.
                    SetError(MarcaCB, ">>Formato no valido!");
            }
            else
                this.errorProviderLetras.Clear();
            if (!regexLetras.IsMatch(CategoriaCB.Text))
            {
                errorProviderLetras.
                    SetError(CategoriaCB, ">>Formato no valido!");
            }
            else
                this.errorProviderLetras.Clear();
            if (!regexLetras.IsMatch(ProveedorCB.Text))
            {
                errorProviderLetras.
                    SetError(ProveedorCB, ">>Formato no valido!");
            }
            else
                this.errorProviderLetras.Clear();

            //Numeros
            Regex regexNumero1 = new Regex(@"^[0-9.]+$");
            if (!regexNumero1.IsMatch(MedidaCB.Text))
            {
                errorProviderNumero1.
                    SetError(MedidaCB, ">>Formato no valido");
            }
            else
                this.errorProviderNumero1.Clear();
            if (!regexNumero1.IsMatch(CantidadTxt.Text))
            {
                errorProviderNumero1.
                    SetError(CantidadTxt, ">>Formato no valido");
            }
            else
                this.errorProviderNumero1.Clear();
            //decimal

            Regex regexDecimal = new Regex(@"^[+]?[0-9]{1,9}(?:.[0-9]{1,2})?$");
            if (!regexDecimal.IsMatch(CostoUnitarioTxt.Text))
            {
                errorProviderdecimal.
                    SetError(CostoUnitarioTxt, ">>Formato no valido");
            }
            else
                this.errorProviderdecimal.Clear();
            if (!regexDecimal.IsMatch(PrecioTxt.Text))
            {
                errorProviderdecimal.
                    SetError(PrecioTxt, ">>Formato no valido");
            }
            else
                this.errorProviderdecimal.Clear();
            if (!regexDecimal.IsMatch(MedidaCB.Text))
            {
                errorProviderdecimal.
                    SetError(MedidaCB, ">>Formato no valido");
            }
            else
                this.errorProviderdecimal.Clear();
        }
        #endregion

        private void Añadir(object sender, EventArgs e)
        {
            Validar();
        }
    }
}
