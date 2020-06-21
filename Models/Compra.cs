using System;
using System.Collections.Generic;

namespace Ferreto.Models
{
    public partial class Compra
    {
        public Compra()
        {
            Detallecompra = new HashSet<Detallecompra>();
        }

        public int Idcompra { get; set; }
        public DateTime Fechacompra { get; set; }
        public int Codproveedor { get; set; }
        public decimal Totalcompra { get; set; }
        public int Idusuario { get; set; }
        public int Idproducto { get; set; }
        public string Nombreusuario { get; set; }
        public string Nombreproveedor { get; set; }
        public int Cantidad { get; set; }
        public double Costounitario { get; set; }
        public virtual Proveedores CodproveedorNavigation { get; set; }
        public virtual Usuario IdusuarioNavigation { get; set; }
        public virtual Producto IdproductoNavigation { get; set; }
        public virtual ICollection<Detallecompra> Detallecompra { get; set; }
    }
}
