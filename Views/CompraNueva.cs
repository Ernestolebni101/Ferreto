using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            initcb();
        }

        private void Cerrar(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void initcb()
        {
            var optionsbuilder = new DbContextOptionsBuilder<FerretoSContext>();
            optionsbuilder.UseSqlServer(Parameter.Connectionstring);

            var context = new FerretoSContext(optionsbuilder.Options);

            var proveedorservice = new ProveedorService(context);
            using (context)
            {
                ProveedorCB.DataSource = proveedorservice.GetAll();
                ProveedorCB.ValueMember = "Idproveedor";
                ProveedorCB.DisplayMember = "IdpersonaNavigation";
            }       
        }
    }
}
