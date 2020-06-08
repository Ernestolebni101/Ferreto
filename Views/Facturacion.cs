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
   
  /// <summary>
  /// 
  /// </summary>
  ///

    
    public partial class Facturacion : Form
    {
        //private readonly IHelper<Producto> _productohelper;

        //private readonly FerretoSContext _Fcontext;
        public Facturacion()
        {
            InitializeComponent();
            ProductosLV.View = System.Windows.Forms.View.Details;
        }

        private void AgregarBo_Click(object sender, EventArgs e)
        {
            validar();
        }

        /// <summary>
        /// Este metodo inicializa el combobox mediante un servicio que implementa interfaces
        /// </summary>
        //private void initcb()
        //{

        //    ProductosCB.DataSource = _productohelper.Getall();
        //    ProductosCB.ValueMember = "IdProducto";
        //    ProductosCB.DisplayMember = "Nombre";

        //}
        #region Valaciones
        public void validar()
        {
            //Letras
            Regex regexLetras = new Regex(@"^[a-zA-Z]+$");
            if (!regexLetras.IsMatch(ProductosTxt.Text))
            {
                errorProviderLetras.
                    SetError(ProductosTxt, ">>Formato no valido!");
            }
            else
                this.errorProviderLetras.Clear();
            //Numeros
            Regex regexNumero = new Regex(@"^[0-9]+$");
            if (!regexNumero.IsMatch(CantidadTxt.Text))
            {
                errorProviderCantidad.
                    SetError(CantidadTxt, ">>Formato no valido!");
            }
            else
                this.errorProviderCantidad.Clear();
        }
        #endregion
    }
}
