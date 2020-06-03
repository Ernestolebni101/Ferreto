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
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
            initcb();
        }


        private void initcb()
        {
         

            var optionsbuilder = new DbContextOptionsBuilder<FerretoSContext>();
            optionsbuilder.UseSqlServer(Parameter.Connectionstring);

            var context = new FerretoSContext(optionsbuilder.Options);

            var productoService = new ProductoService(context);

            using (context)
            {
                ProductosCB.DataSource = productoService.GetAll();
                ProductosCB.ValueMember= "Idproducto";
                ProductosCB.DisplayMember ="Nombre";
            }
        }
    }
}
