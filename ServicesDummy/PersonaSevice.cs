using Ferreto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreto.Services
{
   
    public class PersonaSevice
    {
        private readonly FerretoSContext _context;
        public PersonaSevice(FerretoSContext context)
        {
            _context = context;
        }
        public void newpersona(List<Persona>persona)
        {
            _context.AddRange(persona);
            _context.SaveChanges();
        }
        public bool Existbyname(string name,string lastname,string email, string address,
            string phone)
        {
            return _context.Persona
                .Any(x=> x.Nombre==name && x.Apellido== lastname && x.Email==email && x.Direccion== address
                && x.Telefono== phone);
        }
        //public IEnumerable<Persona> Getid()
        //{
        //    return _context.Persona.OrderByDescending()
        //}
    }
}
