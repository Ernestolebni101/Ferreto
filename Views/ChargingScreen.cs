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
        }
       
        private void ChargingScreen_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            LoginPB.Value = 0;
            LoginPB.MinValue = 0;
            LoginPB.MaxValue = 100;
            timer1.Start();
        }

        private void Open(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.05;
            LoginPB.Value += 1;
            if (LoginPB.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void Close(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }
    }
}
