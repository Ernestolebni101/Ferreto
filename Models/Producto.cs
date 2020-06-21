using Ferreto.Common;
using System;
using System.Collections.Generic;

namespace Ferreto.Models
{
    public partial class Producto
    {
        public Producto()
        {
            Detallecompra = new HashSet<Detallecompra>();
            Detallefactura = new HashSet<Detallefactura>();
            Inventario = new HashSet<Inventario>();
            Movinventario = new HashSet<Movinventario>();
            Precioproducto = new HashSet<Precioproducto>(); 
        }
        public int Idproducto { get; set; }
        public string Codproducto { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public string Descripcion { get; set; }
        public int Idcategoria { get; set; }
        public int Idpresentacion { get; set; }
        public DateTime Fecharegistro { get; set; }
        public DateTime Fvencimiento { get; set; }
        public string Ubicacion { get; set; }
        public int Idmarca { get; set; }

        public virtual Categoria IdcategoriaNavigation { get; set; }
        public virtual Marca IdmarcaNavigation { get; set; }
        public virtual Presentacion IdpresentacionNavigation { get; set; }
        public virtual ICollection<Detallecompra> Detallecompra { get; set; }
        public virtual ICollection<Detallefactura> Detallefactura { get; set; }
        public virtual ICollection<Inventario> Inventario { get; set; }
        public virtual ICollection<Movinventario> Movinventario { get; set; }
        public virtual ICollection<Precioproducto> Precioproducto { get; set; }

        public List<Compra> Compras { get; set; }
    }
}
