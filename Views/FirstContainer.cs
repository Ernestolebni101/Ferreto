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
using Ferreto.Views;

namespace Ferreto.Views
{
    public partial class FirstContainer : Form
    {
        public FirstContainer()
        {
            InitializeComponent();
            AbrirSub(new Login());
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

        private void InicioBo_Click(object sender, EventArgs e)
        {
            AbrirSub(new Login());
        }

        private void RegistroBo_Click(object sender, EventArgs e)
        {
            AbrirSub(new Register());
        }

        private void Cerrar(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
