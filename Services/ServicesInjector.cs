using Ferreto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreto.Services
{
    /// <summary>
    /// Con esta clase implementaremos los servicios de la  interface IService Injector
    /// </summary>
    /// <typeparam name="T"> Son todos los modelos que hacen referencia 
    /// a las tablas de la base de a datos</typeparam>
    public class ServicesInjector<T> : IServiceinjector<T> where T : class
    {
        private readonly FerretoSContext _context;
        public ServicesInjector(FerretoSContext context)
        {
            _context = context;
        }

    }
}
