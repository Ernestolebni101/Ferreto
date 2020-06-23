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
            timerselect.Start();
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

        private (int id_user, int id_rol, bool estado) Getids()
        {
            var usuarios = _usuariohelper.GetInfo().usuarios;
            var roles = _rolhelper.GetInfo().roles;
            int idusuario = 0;
            int idrol = 0;
            bool estado = false;
            foreach (var item in usuarios)
            {

                if (item.Login.Equals(UsuarioCB.Text))
                {
                    idusuario = item.Idusuario;
                    estado = item.Estado;
                }
            }
            foreach (var item in roles)
            {
                if (item.Nombrerol.Equals(nuevorolCB.Text))
                {
                    idrol = item.Idrol;
                }
            }
            return (idusuario, idrol, estado);
        }
        private Usuario UpdateUser()
        {
            _user = new Usuario();
            _user.Login = nombreUsuarioTxt.Text;
            _user.Password = this.contraselaNuevatxt.Text;
            _user.Idusuario = Getids().id_user;
            _user.Estado = true ? statusSlide.IsOn : _user.Estado = false;
            return _user;
        }
        private Rolusuario UpdateRolusuario()
        {
            _rolusuario = new Rolusuario();
            _rolusuario.Idusuario = Getids().id_user;
            _rolusuario.Idrol = Getids().id_rol;
            _rolusuario.Estado = true;
            return _rolusuario;
        }

        private void UpdateTables()
        {
            if (EstadoCheck.Checked == true)
                _usuariohelper.ChangesProperty(1, UpdateUser());
          
            else if (Nombrecheck.Checked==true)
                _usuariohelper.ChangesProperty(2, UpdateUser());

            else if(ContraseñaCheck.Checked==true)
                _usuariohelper.ChangesProperty(3, UpdateUser());
         
            else if(Rolcheck.Checked==true)
                _rolusuariohelper.ChangesProperty(4,null,UpdateRolusuario());
        }

        #endregion

        #region Events
        private void Cerrar(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void Actualizar(object sender, EventArgs e)
        {
            UpdateTables();
        }
        private void Contraseña()
        {
            if (ContraseñaCheck.Checked == true)
            {
                contraselaNuevatxt.Enabled = true;
                ActualizarBo.Enabled = true;

                statusSlide.Enabled = false;
                nombreUsuarioTxt.Enabled = false;
                nuevorolCB.Enabled = false;

                EstadoCheck.Checked = false;
                Nombrecheck.Checked = false;
                Rolcheck.Checked = false;
            }
            else
                ActualizarBo.Enabled = false;
        }
        private void NombreUser()
        {
            if (Nombrecheck.Checked)
            {
                nombreUsuarioTxt.Enabled = true;
                ActualizarBo.Enabled = true;

                statusSlide.Enabled = false;
                contraselaNuevatxt.Enabled = false;
                nuevorolCB.Enabled = false;

                EstadoCheck.Checked = false;
                ContraseñaCheck.Checked = false;
                Rolcheck.Checked = false;
            }
            else
                ActualizarBo.Enabled = false;
        }


        private void Estado()
        {
            if (EstadoCheck.Checked)
            {
                statusSlide.Enabled = true;
                ActualizarBo.Enabled = true;

                nombreUsuarioTxt.Enabled = false;
                contraselaNuevatxt.Enabled = false;
                nuevorolCB.Enabled = false;

                Nombrecheck.Checked = false;
                ContraseñaCheck.Checked = false;
                Rolcheck.Checked = false;
            }
            else
                ActualizarBo.Enabled = false;
        }

        private void Rol()
        {
            if (Rolcheck.Checked)
            {
                nuevorolCB.Enabled = true;
                ActualizarBo.Enabled = true;

                nombreUsuarioTxt.Enabled = false;
                contraselaNuevatxt.Enabled = false;
                statusSlide.Enabled = false;

                Nombrecheck.Checked = false;
                Nombrecheck.Checked = false;
                EstadoCheck.Checked = false;
            }
            else
                ActualizarBo.Enabled = false;
            
        }

        private void statusSlide_Click(object sender, EventArgs e)
        {
            Estado();
        }

        private void timerselect_Tick(object sender, EventArgs e)
        {

        }

        private void UsuarioCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Estadolabel.Text = (Getids().estado) ? "Activo" : "Inactivo";
        }

        private void Nombrecheck_Click(object sender, EventArgs e)
        {
            NombreUser();
        }

        private void ContraseñaCheck_Click(object sender, EventArgs e)
        {
            Contraseña();
        }

        private void Rolcheck_Click(object sender, EventArgs e)
        {
            Rol();
        }
        #endregion
    }
}
