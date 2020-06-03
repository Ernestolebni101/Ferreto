using System;
using System.Collections.Generic;

namespace Ferreto.Models
{
    public partial class Rol
    {
        public Rol()
        {
            Rolacceso = new HashSet<Rolacceso>();
            Rolusuario = new HashSet<Rolusuario>();
        }

        public int Idrol { get; set; }
        public string Nombrerol { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<Rolacceso> Rolacceso { get; set; }
        public virtual ICollection<Rolusuario> Rolusuario { get; set; }
    }
}
