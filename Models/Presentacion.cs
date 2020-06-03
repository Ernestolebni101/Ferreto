using System;
using System.Collections.Generic;

namespace Ferreto.Models
{
    public partial class Presentacion
    {
        public Presentacion()
        {
            Producto = new HashSet<Producto>();
        }

        public int Idpresentacion { get; set; }
        public string Tamaño { get; set; }
        public string Peso { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
