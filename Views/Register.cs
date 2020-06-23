using Ferreto.Common;
using Ferreto.Models;
using Ferreto.Models.Common;
using Ferreto.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidatorAligator;

namespace Ferreto.Views
{
    public partial class Register : Form
    {

        private readonly Helper<Rol> _rolhelper;
        private Helper<Persona> _personahelper;
        private Helper<Rolusuario> _rolusuariohelper;
        private Helper<Usuario> _usuariohelper;
        private readonly FerretoSContext _context;
        public Register()
        {
            InitializeComponent();
            _context = Initializecontext.initcontext();
            _rolhelper = new Helper<Rol>(_context);
            _personahelper = new Helper<Persona>(_context);
            _usuariohelper = new Helper<Usuario>(_context);
            _rolusuariohelper = new Helper<Rolusuario>(_context);
            Init();
        }
        #region Methods
        private Usuario _objusuario;
        private Persona _objpersona;
        private Rolusuario _rolusuario;

        /// <summary>
        /// Este metodo carga las propiedades de un nuevo objeto del tipo Persona
        /// </summary>
        /// <returns> me retorna una nueva persona</returns>
        private Persona PersonalInfor()
        {
            _objpersona = new Persona();
            _objpersona.Nombre = this.NombreTxt.Text;
            _objpersona.Apellido = ApellidoTxt.Text;
            _objpersona.Email = CorreoTxt.Text;
            _objpersona.Cedula = CedulaTxt.Text;
            _objpersona.Telefono = TelefonoTxt.Text;
            _objpersona.Direccion = direcciontxt.Text;
            return _objpersona;
        }

        /// <summary>
        /// Metodo principal para crear un usuario
        /// </summary>
        private void CreateUser()
        {
            var dataperson = PersonalInfor();
            _personahelper.add(dataperson);
            var datauser = Userinfo(dataperson.Idpersona);
            _usuariohelper.add(datauser);
            var dataroluser = Roluser(datauser.Idusuario);
            _rolusuariohelper.add(dataroluser);
            errorProvidercode.SetError(FerretoCodeTxt, "Verifique su contraseña");
        }
        private Usuario Userinfo(int idpersona)
        {
            _objusuario = new Usuario();
            _objusuario.Login = UsuarioTxt.Text;
            _objusuario.Password = ContraseñaTxt.Text;
            _objusuario.Idpersona = idpersona;
            _objusuario.Estado = true;
            return _objusuario;
        }

        private void Init()
        {
            RolCB.DataSource = _rolhelper.Get();
            RolCB.ValueMember = "Idrol";
            RolCB.DisplayMember = "Nombrerol";
        }
        private Rolusuario Roluser(int idusuario)
        {
            _rolusuario = new Rolusuario();
            _rolusuario.Idusuario = idusuario;
            _rolusuario.Idrol = Getidrol(RolCB.Text);
            _rolusuario.Estado = true;
            return _rolusuario;
        }

        private void cleancontrols()
        {
            NombreTxt.Text = string.Empty;
            ApellidoTxt.Text = string.Empty;
            direcciontxt.Text = String.Empty;
            CorreoTxt.Text = string.Empty;
            UsuarioTxt.Text = string.Empty;
            TelefonoTxt.Text = string.Empty;
            ContraseñaTxt.Text = string.Empty;
            CedulaTxt.Text = string.Empty;
        }
        private int Getidrol(string cadena)
        {
            var colection = _rolhelper.Get();
            int idrol = 0;
            foreach (var iter in colection)
            {
                if (cadena.Equals(iter.Nombrerol))
                {
                    idrol = iter.Idrol;
                    break;
                }
            }
            return idrol;
        }
        #endregion

        #region Events
        private void Registrar(object sender, EventArgs e)
        {
            if (Valida())
            {
                CreateUser();
                cleancontrols();
            }
        }


        #endregion

        #region VALIDACION
        private bool Valida()
        {
            ValidatorAligator.ReValidate.ValidarVacios(UsuarioTxt,errorProviderUser);
            ValidatorAligator.ReValidate.ValidarContraseña(ContraseñaTxt,errorProviderContra);
            ValidatorAligator.ReValidate.ValidarVacios(FerretoCodeTxt,errorProvidercode);
            ValidatorAligator.ReValidate.ValidarNombre(NombreTxt,ErrorProviderNombre);
            ValidatorAligator.ReValidate.ValidarApellido(ApellidoTxt,errorProviderApellido);
            ValidatorAligator.ReValidate.ValidarCedula(CedulaTxt,errorProviderCedula);
            ValidatorAligator.ReValidate.ValidarTelefono(TelefonoTxt,errorProviderTelefono);
            ValidatorAligator.ReValidate.ValidarCorreo(CorreoTxt,errorProviderCorreo);
            ValidatorAligator.ReValidate.ValidarDireccion(direcciontxt,errorProviderDireccion);

            if (ValidatorAligator.ReValidate.ValidarVacios(UsuarioTxt, errorProviderUser) == true &&
            ValidatorAligator.ReValidate.ValidarContraseña(ContraseñaTxt, errorProviderContra) == true &&
            ValidatorAligator.ReValidate.ValidarVacios(FerretoCodeTxt, errorProvidercode) == true &&
            ValidatorAligator.ReValidate.ValidarNombre(NombreTxt, ErrorProviderNombre) == true &&
            ValidatorAligator.ReValidate.ValidarApellido(ApellidoTxt, errorProviderApellido) == true &&
            ValidatorAligator.ReValidate.ValidarCedula(CedulaTxt, errorProviderCedula) == true &&
            ValidatorAligator.ReValidate.ValidarTelefono(TelefonoTxt, errorProviderTelefono) == true &&
            ValidatorAligator.ReValidate.ValidarCorreo(CorreoTxt, errorProviderCorreo) == true &&
            ValidatorAligator.ReValidate.ValidarDireccion(direcciontxt, errorProviderDireccion) == true)
                return true;
            else
                return false;
        }
        #endregion
    }
}
