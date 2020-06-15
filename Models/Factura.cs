using System;
using System.Collections.Generic;

namespace Ferreto.Models
{
    public partial class Factura
    {
        public int Idfactura { get; set; }
        public int Idusuario { get; set; }
        public int Idventa { get; set; }
        public double Iva { get; set; }
        public decimal Totalsiniva { get; set; }
        public decimal Totalmasiva { get; set; }
        public string Nserie { get; set; }
        public DateTime Fechafacturacion { get; set; }

        public virtual Usuario IdusuarioNavigation { get; set; }
        public virtual Detallefactura IdventaNavigation {get; set;}
    }
}
