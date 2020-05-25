using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreto.Views;

namespace Ferreto.Views
{
    public partial class ChargingScreen : Form
    {
        public ChargingScreen()
        {
            InitializeComponent();
            Thread.Sleep(1000);
            Cargar();   
            
        }

        public void Cargar()
        {
            MainContainer obj = new MainContainer();
            //ChargingScreen.ActiveForm.Hide();
            obj.Show();
            
        }

        

       
    }
}
