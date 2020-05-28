using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreto.Dbcontrollers;
using Microsoft.EntityFrameworkCore;
using Ferreto.Views;

namespace Ferreto
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FirstContainer());
            var optionsbuilder= new DbContextOptionsBuilder<FerretoDbcontext>();
            optionsbuilder.UseSqlServer("Server=Desk");
            var context = new FerretoDbcontext(optionsbuilder.Options);
        }
        private static void Testconnection()
        {
        
        }
    }
}
