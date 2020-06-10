using System;
using System.Collections.Generic;

namespace Ferreto.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Proveedores = new HashSet<Proveedores>();
            Usuario = new HashSet<Usuario>();
        }

        public int Idpersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }

        
        public virtual ICollection<Proveedores> Proveedores { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
