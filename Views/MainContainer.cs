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
    public partial class MainContainer : Form
    {
        public MainContainer()
        {
            InitializeComponent();
            AbrirSub(new Venta());
        }

        public void AbrirSub(object Submenu)
        {
            if (this.panelCont.Controls.Count > 0)
                this.panelCont.Controls.RemoveAt(0);
            Form fh = Submenu as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelCont.Controls.Add(fh);
            this.panelCont.Tag = fh;
            fh.Show();
        }

        private void VentaBo_Click(object sender, EventArgs e)
        {
            AbrirSub(new Venta());
        }

        private void InventarioBo_Click(object sender, EventArgs e)
        {
            AbrirSub(new Inventario());
        }

        private void FacturaBo_Click(object sender, EventArgs e)
        {
            AbrirSub(new Facturas());
        }

        private void SalirBo_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
