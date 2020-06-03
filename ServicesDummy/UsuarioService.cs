using Ferreto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreto.Services
{
   
    public class UsuarioService
    {
        private readonly FerretoSContext _context;
        public UsuarioService(FerretoSContext context)
        {
            _context = context;
        }
        public void Create()
        {

        }

    }
}
