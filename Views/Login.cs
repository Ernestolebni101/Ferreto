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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void InicioBo_Click(object sender, EventArgs e)
        {
            Sesion();
        }

        private bool ValidoCredenciales()
        {
            try
            {
                if (UserTxt.Text.Equals("admin") && PassTxt.Text.Equals("12345"))
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        } 

        public void Sesion()
        {
            if (ValidoCredenciales())
            {
                MainContainer obj = new MainContainer();
                FirstContainer.ActiveForm.Hide();
                //this.Hide();
                obj.Show();

            }
            else
            {
                MessageBox.Show("Usuario ó Contraseña Incorrectos");
                UserTxt.Text = string.Empty;
                PassTxt.Text = string.Empty;
            }
        }
    }
}
