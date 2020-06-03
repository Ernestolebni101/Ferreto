using System;
using System.Collections.Generic;

namespace Ferreto.Models
{
    public partial class Rolacceso
    {
        public int Idrol { get; set; }
        public int Idacceso { get; set; }
        public int Idrolacceso { get; set; }

        public virtual Acceso IdaccesoNavigation { get; set; }
        public virtual Rol IdrolNavigation { get; set; }
    }
}
