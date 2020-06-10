using Ferreto.Models;
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

        IEnumerable<Producto> ConcatenarProductos();
        IEnumerable<Precioproducto> PrecioProducto();
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

        bool validatecredentials(Usuario U);

        IEnumerable<Inventario> Inventory();

        IEnumerable<Rolusuario> RolAcc();

        bool Existbymarc(T t);
        IEnumerable<T> Get();
    }
    
}
