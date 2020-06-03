using System;
using System.Collections.Generic;

namespace Ferreto.Models
{
    public partial class Precioproducto
    {
        public int Idprecio { get; set; }
        public int Idproducto { get; set; }
        public double Precio { get; set; }
        public DateTime? Fechacreacion { get; set; }
        public bool Estado { get; set; }

        public virtual Producto IdproductoNavigation { get; set; }
    }
}
