using System;
using System.Collections.Generic;

namespace Ferreto.Models
{
    public partial class Proveedores
    {
        public Proveedores()
        {
            Compra = new HashSet<Compra>();
        }

        public int Idproveedor { get; set; }
        public string Empresa { get; set; }
        public int Idpersona { get; set; }
        public bool Estado { get; set; }

        public virtual Persona IdpersonaNavigation { get; set; }
        public virtual ICollection<Compra> Compra { get; set; }
    }
}
