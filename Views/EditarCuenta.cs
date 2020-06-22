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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreto.Views
{
    public partial class EditarCuenta : Form
    {
        private readonly FerretoSContext _context;
        private readonly ServicesInjector<Usuario> _usuariohelper;
        private readonly ServicesInjector<Rol> _rolhelper;
        private readonly ServicesInjector<Rolusuario> _rolusuariohelper;

        Usuario _user;
        Rolusuario _rolusuario;
        public EditarCuenta()
        {
            InitializeComponent();
            _context = Initializecontext.initcontext();
            _usuariohelper = new ServicesInjector<Usuario>(_context);
            _rolhelper = new ServicesInjector<Rol>(_context);
            _rolusuariohelper = new ServicesInjector<Rolusuario>(_context);
            Init();
        }

        #region Methods       
        private void Init()
        {//Combobox de usuarios
            this.UsuarioCB.DataSource = _usuariohelper.GetInfo().usuarios;
            UsuarioCB.ValueMember = "Idusuario";
            UsuarioCB.DisplayMember = "Login";
            //Combobox roles
            this.nuevorolCB.DataSource = _rolhelper.GetInfo().roles;
            nuevorolCB.ValueMember = "Idrol";
            nuevorolCB.DisplayMember = "Nombrerol";
        }

        private (int id_user, int id_rol) Getids()
        {
            var usuarios = _usuariohelper.GetInfo().usuarios;
            var roles = _rolhelper.GetInfo().roles;
            int idusuario = 0;
            int idrol = 0;
            foreach (var item in usuarios)
            {
                if (item.IdpersonaNavigation.Nombre.Equals(UsuarioCB.Text))
                {
                    idusuario = item.Idusuario;
                }
            }
            foreach (var item in roles)
            {
                if (item.Nombrerol.Equals(nuevorolCB.Text))
                {
                    idrol = item.Idrol;
                }
            }
            return (idusuario, idrol);
        }
        private Usuario UpdateUser()
        {
            _user = new Usuario();
            _user.IdpersonaNavigation.Nombre = nombreUsuarioTxt.Text;
            _user.Estado = false ? !statusSlide.IsOn : _user.Estado = true;
            return _user;
        }
        private Rolusuario UpdateRolusuario()
        {
            _rolusuario = new Rolusuario();
            _rolusuario.Idusuario = Getids().id_user;
            _rolusuario.Idrol = Getids().id_rol;
            return _rolusuario;
        }

        #endregion
        #region
        private void Cerrar(object sender, EventArgs e)
        {
            this.Dispose();

        }



        private void Actualizar(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
