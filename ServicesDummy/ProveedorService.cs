using Ferreto.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ferreto.Services
{

    public class ProveedorService
    {
        private readonly FerretoSContext _context;

        public ProveedorService(FerretoSContext context)
        {
            _context = context;
        }
        Proveedores Pro;
        public void createprovider(string empresa, int idpersona, bool estado)
        {
            Pro = new Proveedores();
            Pro.Idpersona = idpersona;
            Pro.Empresa = empresa;
            Pro.Estado = estado;
            _context.Add(Pro);
            _context.SaveChanges();
        }

      
        //public Proveedores getidproveedores()
        //{
        //    return 
        //}
    }
}
