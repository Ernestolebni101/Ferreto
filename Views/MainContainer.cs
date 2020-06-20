using Ferreto.Models;
using Ferreto.Services;
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
//using System.Windows.Media;

namespace Ferreto.Views
{
    public partial class MainContainer : Form
    {
        public MainContainer()
        {
            InitializeComponent();
            AbrirSub(new Inicio());
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
            AbrirSub(new Inicio());
        }
        private void VentaBo_Click(object sender, EventArgs e)
        {
            Facturacion obj = new Facturacion();
            obj.UserLab.Text = UserLab.Text;
            VentaBo.BackColor = System.Drawing.Color.FromArgb(253, 201, 84);
            InventarioBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            ComprasBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            ProveedoresBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            FacturaBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            AdministrarBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            AbrirSub(obj);

        }

        private void InventarioBo_Click(object sender, EventArgs e)
        {
            Catalogo obj = new Catalogo();
            if (CargoLab.Text == "Gerente" || CargoLab.Text == "bodegaResp")
                obj.ProductoVeijoCont.Visible = true;
            else
                obj.ProductoVeijoCont.Visible = false;

            VentaBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            InventarioBo.BackColor = System.Drawing.Color.FromArgb(253, 201, 84);
            ComprasBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            ProveedoresBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            FacturaBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            AdministrarBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);

            AbrirSub(obj);
        }

        private void FacturaBo_Click(object sender, EventArgs e)
        {
            VentaBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            InventarioBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            ComprasBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            ProveedoresBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            FacturaBo.BackColor = System.Drawing.Color.FromArgb(253, 201, 84);
            AdministrarBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);

            AbrirSub(new ReimprimirBo());
        }

        private void ComprasBo_Click(object sender, EventArgs e)
        {
            VentaBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            InventarioBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            ComprasBo.BackColor = System.Drawing.Color.FromArgb(253, 201, 84);
            ProveedoresBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            FacturaBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            AdministrarBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);

            AbrirSub(new Compras());
        }

        private void ProveedoresBo_Click(object sender, EventArgs e)
        {
            VentaBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            InventarioBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            ComprasBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            ProveedoresBo.BackColor = System.Drawing.Color.FromArgb(253, 201, 84);
            FacturaBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            AdministrarBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);

            AbrirSub(new ProveedoresForm());
        }

        private void AdministrarBo_Click(object sender, EventArgs e)
        {
            VentaBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            InventarioBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            ComprasBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            ProveedoresBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            FacturaBo.BackColor = System.Drawing.Color.FromArgb(63, 63, 68);
            AdministrarBo.BackColor = System.Drawing.Color.FromArgb(253, 201, 84);

            AbrirSub(new Administrar());
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

        private async void SalirBo_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FirstContainer login = new FirstContainer();
            //login.Show();
           await Task.Run(() =>
            {
                Application.Restart();
            });
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
