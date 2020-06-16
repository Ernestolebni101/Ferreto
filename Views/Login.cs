using Ferreto.Common;
using Ferreto.Models;
using Ferreto.Services;
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

namespace Ferreto.Views
{
    public partial class Login : Form
    {
        private readonly Helper<Usuario> _usuariohelper;
        private readonly FerretoSContext _context;
        private readonly Helper<Rolusuario> _rolusuariohelper;
        private Usuario _usuario;

        public Login()
        {
            InitializeComponent();
            _context = Initializecontext.initcontext();
            _usuariohelper = new Helper<Usuario>(_context);
            _rolusuariohelper = new Helper<Rolusuario>(_context);
        }
        private string RolUserInfo(string cadena)
        {
            string rolactual = string.Empty;
            var local = _rolusuariohelper.RolAcc();
            foreach (var iter in local)
            {
                var nombrerol = iter.IdrolNavigation.Nombrerol;
                var usuario = iter.IdusuarioNavigation.Login;
                var Estado = iter.Estado;
                if (cadena.Equals(usuario))
                {
                    rolactual = nombrerol;
                    break;
                }

            }
            return rolactual;
        }
        private Usuario ReturnUser()
        {
            _usuario = new Usuario();
            _usuario.Login = this.UserTxt.Text;
            _usuario.Password = this.PassTxt.Text;
            return _usuario;
        }
        private void InicioBo_Click(object sender, EventArgs e)
        {
            Access();
        }
        public void Access()
        {
            if (_usuariohelper.validatecredentials(ReturnUser()))
            {
                MainContainer obj = new MainContainer();

                //ChargingScreen obj2 = new ChargingScreen();
                FirstContainer.ActiveForm.Hide();
                if (RolUserInfo(UserTxt.Text).Equals("Admin"))
                {
                    obj.VentaBo.Visible = false;
                    obj.ComprasBo.Visible = false;

                }

                else if (RolUserInfo(UserTxt.Text).Equals("Comprador"))
                {
                    obj.VentaBo.Visible = false;
                    obj.FacturaBo.Visible = false;
                    obj.AdministrarBo.Visible = false;

                }

                else if (RolUserInfo(UserTxt.Text).Equals("Vendedor"))
                {
                    obj.ProveedoresBo.Visible = false;
                    obj.FacturaBo.Visible = false;
                    obj.ComprasBo.Visible = false;
                    obj.AdministrarBo.Visible = false;
                }

                else if (RolUserInfo(UserTxt.Text).Equals("bodegaResp"))
                {
                    obj.VentaBo.Visible = false;
                    obj.FacturaBo.Visible = false;
                    obj.AdministrarBo.Visible = false;
                    obj.ComprasBo.Visible = false;
                }
                //this.Hide();
                obj.UserLab.Text = ReturnUser().Login;
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
