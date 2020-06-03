using Ferreto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreto.Services
{

    public class ProductoService
    {
        private readonly FerretoSContext _context;

        public ProductoService(FerretoSContext context)
        {
            _context = context;
        }

        public IEnumerable<Producto> GetAll()
        {
            return _context.Producto.OrderBy(x=>x.Idproducto).ToList();
        }
    }
}
