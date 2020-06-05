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
    public partial class ProveedoresForm : Form
    {
        public ProveedoresForm()
        {
            InitializeComponent();
        }

        private void AñadirBo_Click(object sender, EventArgs e)
        {
            AñadirProveedor obj = new AñadirProveedor();
            obj.ShowDialog();
        }

        //public string Empresa { get;  set; }
        //public int Idpersona { get;  set; }
        //public bool Estado { get;  set; }
    }
}
