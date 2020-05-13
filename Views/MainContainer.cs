using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            AbrirSub(new InicioContainer());
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

        private void InicioHija(object sender, EventArgs e)
        {
            AbrirSub(new InicioContainer());
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


        private void Cerrarpaneltop(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ocultar(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximizar(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pctMaximizar.Visible = false;
            pctminizar.Visible = true;
        }

        private void Minimizar(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pctMaximizar.Visible = true;
            pctminizar.Visible = false;
        }

        private void SalirBo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstContainer login = new FirstContainer();
            login.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Mover(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
