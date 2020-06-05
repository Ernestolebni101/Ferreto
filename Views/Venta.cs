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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreto.Views
{
   
  /// <summary>
  /// 
  /// </summary>
  ///
    public partial class Venta : Form
    {
        private readonly IHelper<Producto> _productohelper;

        private readonly FerretoSContext _Fcontext;
        //public Venta(IHelper<Producto> productohelper,FerretoSContext Fcontext)
        //{
        //    _Fcontext = Fcontext;
        //    _productohelper = productohelper; 
        //    InitializeComponent();   
        //    initcb();
        //}

        /// <summary>
        /// Este metodo inicializa el combobox mediante un servicio que implementa interfaces
        /// </summary>
        //private void initcb()
        //{

        //    ProductosCB.DataSource = _productohelper.Getall();
        //    ProductosCB.ValueMember = "IdProducto";
        //    ProductosCB.DisplayMember = "Nombre";

        //}
    }
}
