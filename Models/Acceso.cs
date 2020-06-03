using System;
using System.Collections.Generic;


namespace Ferreto.Models
{
    public partial class Acceso
    {
        public Acceso()
        {
            Rolacceso = new HashSet<Rolacceso>();
        }

        public int Idacceso { get; set; }
        public string Formulario { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<Rolacceso> Rolacceso { get; set; }
    }
}
