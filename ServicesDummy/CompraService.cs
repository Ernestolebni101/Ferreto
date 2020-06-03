using Ferreto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreto.Services
{
   public class CompraService
    {
        private readonly FerretoSContext _context;

        public CompraService(FerretoSContext context)
        {
            _context = context;
        }
    }
}
