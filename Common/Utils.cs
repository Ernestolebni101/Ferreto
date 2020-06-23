using Ferreto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreto.Common
{
    public static class Utils
    {
        private static readonly FerretoSContext _context;
        private static readonly Services.ServicesInjector<Usuario> _usuarioservice;
        static Utils()
        {
            _context = Initializecontext.initcontext();
            _usuarioservice = new Services.ServicesInjector<Usuario>(_context);
        }
        public static string codigo { get; set; } = Guid.NewGuid().ToString();

        public static string ReturName(int id)
        {
            var collection = _usuarioservice.GetInfo().usuarios;
          var obj=  collection.Single(x => x.Idusuario.Equals(id));
            return obj.IdpersonaNavigation.Nombre;
        }
    }
}
