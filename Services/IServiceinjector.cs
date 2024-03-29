﻿using Ferreto.Models;
using Ferreto.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreto.Services
{
    /// <summary>
    /// Se hará cargo de proveer servicios puntuales para trabajar con los modelos de la base de datos
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IServiceinjector<T> where T : class
    {
        IEnumerable<Inventario> ConsultInventory();
        IEnumerable<Precioproducto> ConsultPrice();
        //async void UpdateIn(int id, int cantidad, int accion);
        void ChangeStatus(int id, byte accion);
        IEnumerable<Proveedores> GetProveedores();
        void ChangeStatusProvider(int id, byte accion);
        IEnumerable<Detallefactura> GetDetails();

    }
}
