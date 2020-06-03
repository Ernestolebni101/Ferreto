using System;
using System.Collections.Generic;

namespace Ferreto.Models
{
    public partial class Marca
    {
        public Marca()
        {
            Producto = new HashSet<Producto>();
        }

        public int Idmarca { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
