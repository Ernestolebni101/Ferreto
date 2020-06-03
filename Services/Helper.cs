using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferreto.Models;
namespace Ferreto.Services
{
    public class Helper<T> : IHelper<T> where T : class
    {
        public readonly FerretoSContext _context;
        public Helper(FerretoSContext context)
        {
            _context = context;
        }
        IQueryable<T> IHelper<T>.Getall()
        {
            return _context.Set<T>();
        }
    }
}
