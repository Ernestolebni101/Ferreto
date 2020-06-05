using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreto.Services
{
    public interface IHelper<T> where T : class 
    {
        T add(T t);
        T Update(T t);
        T Remove(T t);
        void Dispose();
        //Task<T> Find(int Id);
        IQueryable<T> GetAll();
        Task<T> GetAsync(int id);
        Task<T> GetAsync(Int16 id);
        bool Save();
        Task<bool> SaveAsync();
        List<T> AddDetails(List<T> t);
        List<T> Update(List<T> t);

    }
    
}
