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
    public partial class Administrar : Form
    {
        public Administrar()
        {
            InitializeComponent();
        }

        private void EditarItemBo_Click(object sender, EventArgs e)
        {
            EditarItem obj = new EditarItem();
            obj.ShowDialog();
        }

        private void EditarCuentaBo_Click(object sender, EventArgs e)
        {
            EditarCuenta obj = new EditarCuenta();
            obj.ShowDialog();
        }
    }
}
