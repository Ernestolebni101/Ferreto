using System;
using System.Collections.Generic;

namespace Ferreto.Models
{
    public partial class Detallefactura
    {
      
        public int Iddetalle { get; set; }
        public double Precioventa { get; set; }
        public int Idfactura { get; set; }
        public int Idproducto { get; set; }
        public double Cantidad { get; set; }

        public virtual Producto IdproductoNavigation { get; set; }
        public  Factura IdfacturaNavigation { get; set; }
    }
}
