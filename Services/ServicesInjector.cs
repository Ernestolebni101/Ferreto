using Ferreto.Models;
using Ferreto.Views;
using Microsoft.EntityFrameworkCore;
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

        public void ChangeStatus(int id, byte accion)
        {
            var producto = _context.Producto.Single(x => x.Idproducto == id);
            switch (accion)
            {
                case 0:
                    producto.Estado = false;
                    break;
                case 1:
                    producto.Estado = true;
                    break;
            }
            _context.SaveChanges();
        }

        public void ChangeStatusProvider(int id, byte accion)
        {
            var proveedor = _context.Proveedores.Single(x => x.Idproveedor == id);
            switch (accion)
            {
                case 0:
                    proveedor.Estado = false;
                    break;
                case 1:
                    proveedor.Estado = true;
                    break;
            }
            _context.SaveChanges();
        }

        public IEnumerable<Inventario> ConsultInventory()
        {
            var warehouse = _context.Inventario.Include(o => o.IdproductoNavigation)
                                       .ThenInclude(x => x.IdcategoriaNavigation)
                                       .Include(x => x.IdproductoNavigation)
                                       .ThenInclude(x => x.IdmarcaNavigation)
                                       .Include(d => d.IdproductoNavigation)
                                       .ThenInclude(c => c.IdpresentacionNavigation).ToList();
            return warehouse;
        }

        public IEnumerable<Precioproducto> ConsultPrice()
        {
            return _context.Precioproducto.Include(x => x.IdproductoNavigation).ToList();
        }

        public IEnumerable<Detallefactura> GetDetails()
        {
            var detail = _context.Detallefactura
                .Include(x => x.IdproductoNavigation)
                .ThenInclude(z => z.IdmarcaNavigation)
                .Include(x => x.IdproductoNavigation)
                .ThenInclude(k=>k.IdcategoriaNavigation)
                .Include(f => f.IdfacturaNavigation)
                .ToList();
            return detail;
        }

        public IEnumerable<Proveedores> GetProveedores()
        {
            var proveedoreslist = _context.Proveedores
                .Include(p => p.IdpersonaNavigation)
                .ToList();
            return proveedoreslist;
        }
    }
}
