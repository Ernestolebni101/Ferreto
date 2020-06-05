using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

using Ferreto.Views;
using SimpleInjector;
using Ferreto.Services;
using Ferreto.Models;
using Microsoft.Extensions.DependencyInjection;
using Ferreto.Models.Common;

namespace Ferreto
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        private static Container container;
        [STAThread]
    
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         
            Application.Run(new FirstContainer());
         
        }


        //private static void Startup()
        //{
        //    var optionsbuilder = new DbContextOptionsBuilder<FerretoSContext>();
        //    optionsbuilder.UseSqlServer(Parameter.Connectionstring);
        //    var context = new FerretoSContext(optionsbuilder.Options);
        //    container = new Container();
        //    container.Register<IHelper<Producto>,Helper<Producto>>(Lifestyle.Singleton);
        //    container.Register<Venta>();
        //    container.Verify();

        //}


        //var service = new ServiceCollection();
        //service.AddDbContext<FerretoSContext>(options => options.UseSqlServer(Parameter.Connectionstring));
        //service.AddTransient<IHelper<Producto>, Helper<Producto>>();
        //var provider = service.BuildServiceProvider();
        //var query = provider.GetService<Producto>();
        //private static void Testconnection(FerretoDbcontext context)
        //{
        //    var isconnected = false;
        //    try
        //    {
        //        isconnected = context.Database.EnsureCreated();
        //    }
        //    catch (Exception)
        //    {
        //        isconnected = false;
        //    }
        //    if (isconnected)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine("Connection Succesful");
        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine("Connection Unsuccesful");
        //    }
        //    Console.Read();
        //}
    }
}
