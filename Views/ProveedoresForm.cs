using Ferreto.Common;
using Ferreto.Models;
using Ferreto.Services;
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
        private readonly FerretoSContext _context;
        private readonly ServicesInjector<Persona> _proveedoreshelper;
        public ProveedoresForm()
        {
            InitializeComponent();
            _context = Initializecontext.initcontext();
            _proveedoreshelper = new ServicesInjector<Persona>(_context);
            InitLv();
        }

        private void AñadirBo_Click(object sender, EventArgs e)
        {
            AñadirProveedor obj = new AñadirProveedor();
            obj.ShowDialog();
        }
        private void InitLv()
        {
            ListViewItem item = null;
            var t_proveedores = _proveedoreshelper.GetProveedores();
            foreach (var P in t_proveedores)
            {
                item = this.ProveedoresLV.Items.Add(P.Idproveedor.ToString());
                item.SubItems.Add(P.Empresa.ToString());
                item.SubItems.Add(P.IdpersonaNavigation.Nombre);
                item.SubItems.Add(P.IdpersonaNavigation.Apellido);
                item.SubItems.Add(P.IdpersonaNavigation.Cedula);
                item.SubItems.Add(P.IdpersonaNavigation.Telefono);
                item.SubItems.Add(P.IdpersonaNavigation.Email);
                item.SubItems.Add(P.IdpersonaNavigation.Direccion);
                if (P.Estado)
                {
                    item.SubItems.Add("Activo");
                }
                else
                {
                    item.SubItems.Add("Inactivo");
                }
            }
        }
        private void StateChanged(int id, byte accion)
        {
            switch (accion)
            {
                case 0:
                    _proveedoreshelper.ChangeStatusProvider(id, accion);
                    break;
                case 1:
                    _proveedoreshelper.ChangeStatusProvider(id, accion);
                    break;
            }
        }

        private void ChangeProvider()
        {
            if (ProveedoresLV.SelectedItems.Count > 0 && ProveedoresLV.SelectedItems.Count < 2)
            {
                byte accion;
                foreach (ListViewItem item in ProveedoresLV.SelectedItems)
                {
                    if (!CambiarEstadoSlide.IsOn)
                        accion = 0;
                    else
                        accion = 1;

                    StateChanged(int.Parse(item.SubItems[0].Text), accion);
                }
            }
            else
                MessageBox.Show("Debe elegir un solo proveedor", "Fallo al actualizar estado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CambiarEstadoBo_Click(object sender, EventArgs e)
        {
            ChangeProvider();
        }
    }
}