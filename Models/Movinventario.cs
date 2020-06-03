using System;
using System.Collections.Generic;

namespace Ferreto.Models
{
    public partial class Movinventario
    {
        public int Idmovinventario { get; set; }
        public int Idproducto { get; set; }
        public int? Tipomovimiento { get; set; }
        public int Idinventario { get; set; }
        public int Movimientonumero { get; set; }

        public virtual Inventario IdinventarioNavigation { get; set; }
        public virtual Producto IdproductoNavigation { get; set; }
    }
}
