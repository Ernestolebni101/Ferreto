﻿using System;
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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void ActualizarBo_Click(object sender, EventArgs e)
        {
            CompraExistente obj = new CompraExistente();
            obj.ShowDialog();
        }

        private void AñadirBo_Click(object sender, EventArgs e)
        {
            CompraNueva obj = new CompraNueva();
            obj.ShowDialog();
        }
    }
}