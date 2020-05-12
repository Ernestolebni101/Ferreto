using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        

    }
}
