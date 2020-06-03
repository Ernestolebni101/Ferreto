using System;
using System.Collections.Generic;

namespace Ferreto.Models
{
    public partial class Detallefactura
    {
        public Detallefactura()
        {
            Factura = new HashSet<Factura>();
        }

        public int Idventa { get; set; }
        public double Precioventa { get; set; }
        public int Idproducto { get; set; }
        public double Cantidad { get; set; }

        public virtual Producto IdproductoNavigation { get; set; }
        public virtual ICollection<Factura> Factura { get; set; }
    }
}
