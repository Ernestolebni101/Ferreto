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
    public partial class EditarItem : Form
    {
        public EditarItem()
        {
            InitializeComponent();
        }

        private void Cerrar(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
