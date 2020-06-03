using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            //var optionsbuilder= new DbContextOptionsBuilder<FerretoDbcontext>();
            //optionsbuilder.UseSqlServer("Server=localhost\\Database=FerretoS;Trusted_Connection=True;MultipleActiveResultSets=true;");
            //var context = new FerretoDbcontext(optionsbuilder.Options);
            //Testconnection(context);
        }
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
