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
    public partial class AñadirProveedor : Form
    {
        public AñadirProveedor()
        {
            InitializeComponent();
        }
        private void Cerrar(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private List<Persona> Per;
        private Proveedores Pro;
        private void create(string nombre, string apellido, string correo, string direccion, string telefono)
        {
            var optionsbuilder = new DbContextOptionsBuilder<FerretoSContext>();
            optionsbuilder.UseSqlServer(Parameter.Connectionstring);
            var context = new FerretoSContext(optionsbuilder.Options);
            var personaservice = new PersonaSevice(context);
            var proveedorservice = new ProveedorService(context);

            Per = new List<Persona>()
            {
                new Persona(){Nombre= this.nombretxt.Text
                ,Apellido= this.apellidotxt.Text,Telefono=this.telefonotxt.Text,
                Email= this.correotxt.Text,Direccion= direcciontxt.Text}
            };
            using (context)
            {
                var exist = personaservice.Existbyname(nombre, apellido, correo, direccion, telefono);

                while (exist == true)
                {
                    if (exist)
                    {
                        MessageBox.Show("Este proveedor  ya existe en la base de datos");
                    }
                    break;
                }
                personaservice.newpersona(Per);
                consultid(Per);
            }
        }

        private void consultid(List<Persona> per)
        {
            var optionsbuilder = new DbContextOptionsBuilder<FerretoSContext>();
            optionsbuilder.UseSqlServer(Parameter.Connectionstring);
            var context = new FerretoSContext(optionsbuilder.Options);
            var queryperson = per;
            var proveedorservice = new ProveedorService(context);
            var idrecuperado = 0;
            using (context)
            {
                foreach (var iterator in queryperson)
                {
                    idrecuperado=iterator.Idpersona;
                    break;
                }
                proveedorservice.createprovider(Empresatxt.Text,idrecuperado,true);                
            }
        }
        private void cleantext()
        {
            this.nombretxt.Text = string.Empty;
            this.apellidotxt.Text = string.Empty;
            this.correotxt.Text = string.Empty;
            this.Empresatxt.Text = string.Empty;
            this.direcciontxt.Text = string.Empty;
            this.telefonotxt.Text = string.Empty;

        }
        private void AñadirBo_Click(object sender, EventArgs e)
        {
            create(this.nombretxt.Text, this.apellidotxt.Text, correotxt.Text, direcciontxt.Text, telefonotxt.Text);
            cleantext();
        }
    }
}
