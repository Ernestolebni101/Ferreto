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
        [STAThread]
    
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);        
            Application.Run(new FirstContainer());
        }
    }
}
