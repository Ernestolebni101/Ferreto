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

        public virtual Proveedores CodproveedorNavigation { get; set; }
        public virtual Usuario IdusuarioNavigation { get; set; }
        public virtual ICollection<Detallecompra> Detallecompra { get; set; }
    }
}
