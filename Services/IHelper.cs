using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreto.Services
{
    public interface IHelper<T> where T : class 
    {
        IQueryable<T> Getall();

    }
    
}
