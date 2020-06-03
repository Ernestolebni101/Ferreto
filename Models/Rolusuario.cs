using System;
using System.Collections.Generic;

namespace Ferreto.Models
{
    public partial class Rolusuario
    {
        public int Idrolusuario { get; set; }
        public int Idrol { get; set; }
        public int Idusuario { get; set; }
        public bool Estado { get; set; }

        public virtual Rol IdrolNavigation { get; set; }
        public virtual Usuario IdusuarioNavigation { get; set; }
    }
}
