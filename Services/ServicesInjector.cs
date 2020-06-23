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

        public void AlterInventario(Inventario I)
        {
            var originalEntry = _context.Inventario.Single(y => y.Idproducto == I.Idproducto);
            originalEntry.Existencia += I.Existencia;
            originalEntry.Precio = I.Precio;
            originalEntry.Unidademonetarias = originalEntry.Existencia * Decimal.Parse(originalEntry.Precio.ToString());
            _context.Update(originalEntry);
        }

        public void AlterPrice(Precioproducto p)
        {
            var obj = _context.Precioproducto.Single(z => z.Idproducto == p.Idproducto);
            obj.Precio = p.Precio;
            var noduplicate =
            _context.SaveChanges();
        }
        public void ChangesProperty(byte accion, Usuario U = null, Rolusuario Rlu = null)
        {
            Usuario Originaluser;
            //var Entry = _context.Rolusuario.Where(x => x.Idrol.Equals(Rlu.Idrol) || Rlu.Idusuario.Equals(Rlu.Idusuario)).ToList();

            if (U != null)
            {
                Originaluser = this.GetInfo().usuarios.Single(x => x.Idusuario.Equals(U.Idusuario));
                switch (accion)
                {
                    case 1:

                        Originaluser.Estado = U.Estado;
                        break;
                    case 2:

                        Originaluser.Login = U.Login;
                        break;
                    case 3:
                        Originaluser.Password = U.Password;
                        break;
                }
            }
            else if (Rlu != null)
            {
                bool exist = _context.Rolusuario.Where(x => x.Idusuario.Equals(Rlu.Idusuario)).Any(r => r.Idrol.Equals(Rlu.Idrol));
                if (!exist)
                {
                    switch (accion)
                    {
                        case 4:
                            _context.Rolusuario.Add(Rlu);
                            break;
                    }
                }
            }
            _context.SaveChanges();
        }
        public IEnumerable<Producto> ConsultProduct()
        {
            var Listproducts = _context.Producto.Include(z => z.IdcategoriaNavigation)
                .Include(x => x.IdmarcaNavigation)
                .Include(x => x.IdpresentacionNavigation);
            return Listproducts;
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
                .ThenInclude(k => k.IdcategoriaNavigation)
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



        public (IEnumerable<Usuario> usuarios, IEnumerable<Rol> roles,
            IEnumerable<Rolusuario> rolusuarios, IEnumerable<Proveedores> proveedores, IEnumerable<Compra> compras) GetInfo()
        {
            var roles = _context.Rol.ToList();
            var usuarios = _context.Usuario.Include(x => x.IdpersonaNavigation).ToList();
            var rolusuario = _context.Rolusuario.ToList();
            var proveedores = _context.Proveedores.Include(p => p.IdpersonaNavigation).ToList();
            var compra = _context.Compra.Include(x => x.IdproductoNavigation)
                .ThenInclude(x => x.Precioproducto)
                .Include(p => p.CodproveedorNavigation).ThenInclude(c => c.IdpersonaNavigation);
            return (usuarios, roles, rolusuario, proveedores, compra);
        }
    }
}
