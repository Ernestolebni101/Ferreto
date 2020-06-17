using System;
using System.Collections.Generic;

namespace Ferreto.Models
{
    public partial class Factura
    {
        
        public int Idfactura { get; set; }
        public int Idusuario { get; set; }
        public string Nombreusuario { get; set; }
        public double Iva { get; set; }
        public decimal Totalsiniva { get; set; }
        public decimal Totalmasiva { get; set; }
        public string Nserie { get; set; }
        public DateTime Fechafacturacion { get; set; }
       public  List<Detallefactura> Detallefacturas { get; set; }
        public virtual Usuario IdusuarioNavigation { get; set; }
    }
}
