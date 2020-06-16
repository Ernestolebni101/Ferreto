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
    public partial class FPrintFactura : Form
    {
        public FPrintFactura()
        {
            InitializeComponent();
            listViewdetalle.View = System.Windows.Forms.View.Details;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
