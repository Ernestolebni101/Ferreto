using System;
using System.Collections.Generic;

namespace Ferreto.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Compra = new HashSet<Compra>();
            Factura = new HashSet<Factura>();
            Rolusuario = new HashSet<Rolusuario>();
        }

        public int Idusuario { get; set; }
        public string Login { get; set; }
        public int Idpersona { get; set; }
        public bool Estado { get; set; }

        public string Password { get; set; }
        public virtual Persona IdpersonaNavigation { get; set; }
        public virtual ICollection<Compra> Compra { get; set; }
        public virtual ICollection<Factura> Factura { get; set; }
        public virtual ICollection<Rolusuario> Rolusuario { get; set; }
    }
}
