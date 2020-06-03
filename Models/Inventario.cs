using System;
using System.Collections.Generic;

namespace Ferreto.Models
{
    public partial class Inventario
    {
        public Inventario()
        {
            Movinventario = new HashSet<Movinventario>();
        }

        public int Idproducto { get; set; }
        public int Idinventario { get; set; }
        public string Nombreproducto { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public decimal Unidademonetarias { get; set; }

        public virtual Producto IdproductoNavigation { get; set; }
        public virtual ICollection<Movinventario> Movinventario { get; set; }
    }
}
