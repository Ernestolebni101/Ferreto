using System;
using System.Collections.Generic;

namespace Ferreto.Models
{
    public partial class Detallecompra
    {
        public int Iddetalle { get; set; }
        public int Idcompra { get; set; }
        public int Cantidad { get; set; }
        public double Preciocompra { get; set; }
        public int Idproducto { get; set; }

        public virtual Compra IdcompraNavigation { get; set; }
        public virtual Producto IdproductoNavigation { get; set; }
    }
}
