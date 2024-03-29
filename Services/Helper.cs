﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Ferreto.Models;
using Microsoft.EntityFrameworkCore;

namespace Ferreto.Services
{
    public class Helper<T> : IHelper<T> where T : class
    {
        private readonly FerretoSContext _context;
        public Helper(FerretoSContext context)
        {
            _context = context;
        }

        public void Editaritem(byte accion, int idmarca = 0, int idrol = 0)
        {
            if (idmarca != 0)
            {
                var marca = _context.Marca.Single(x => x.Idmarca == idmarca);
                switch (accion)
                {
                    case 1:
                        marca.Estado = true;
                        break;
                    case 2:
                        marca.Estado = false;
                        break;
                }
            }
            else if (idrol != 0)
            {
                var rol = _context.Rol.Single(x => x.Idrol.Equals(idrol));
                switch (accion)
                {
                    case 3:
                        rol.Estado = true;
                        break;
                    case 4:
                        rol.Estado = false;
                        break;
                }
            }
            _context.SaveChanges();
        }

        public T add(T t)
        {
            _context.Set<T>().Add(t);
            _context.SaveChanges();
            return t;
        }
        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public async Task<T> GetAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> GetAsync(Int16 id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
        public T Update(T t)
        {
            _context.Set<T>().Update(t);
            return t;
        }

        public List<T> Update(List<T> t)
        {
            _context.Set<T>().AddRange(t);
            return t;
        }

        public T Remove(T t)
        {
            _context.Set<T>().Remove(t);
            return t;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }



        public async Task<bool> SaveAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }

        public T Find(Expression<Func<T, bool>> match)
        {
            throw new NotImplementedException();
        }
        //public Task<T> Find(int Id)
        //{
        //    return DbContext.Set<T>().FindAsync(Id);
        //}

        public List<T> AddDetails(List<T> t)
        {
            _context.Set<T>().AddRange(t);
            _context.SaveChanges();
            return t;
        }

        public bool validatecredentials(Usuario U)
        {
            return _context.Usuario.Any(x => x.Login == U.Login && x.Password == U.Password);
        }

        public bool Existbymarc(T t)
        {
            return _context.Marca.Any(x => x.Equals(t));
        }
        public IEnumerable<Rolusuario> RolAcc()
        {
            return _context.Rolusuario.Include(x => x.IdusuarioNavigation)
                                      .Include(x => x.IdrolNavigation);
        }

        public IEnumerable<T> Get()
        {
            return _context.Set<T>().ToList();
        }

        public IEnumerable<Producto> ConcatenarProductos()
        {
            return _context.Producto.Include(x => x.IdcategoriaNavigation)
                                    .Include(x => x.IdmarcaNavigation);
        }

        public IEnumerable<Precioproducto> PrecioProducto()
        {
            return _context.Precioproducto
                .Include(x => x.IdproductoNavigation).ToList();
        }

        public IEnumerable<Inventario> Inventory()
        {
            return _context.Inventario.Include(x => x.IdproductoNavigation);
        }
        public void UpdateIn(int id, int cantidad, int accion)
        {
            var originalEntry = _context.Inventario.Single(y => y.Idinventario == id);
            var d = originalEntry.Precio.ToString();
            switch (accion)
            {
                case 0:
                    originalEntry.Existencia -= cantidad;
                    originalEntry.Unidademonetarias = originalEntry.Existencia * Decimal.Parse(d);
                    break;
                case 1:
                    originalEntry.Existencia += cantidad;
                    originalEntry.Unidademonetarias = originalEntry.Existencia * Decimal.Parse(d);
                    break;
            }
            _context.Update(originalEntry);
        }

    }
}
