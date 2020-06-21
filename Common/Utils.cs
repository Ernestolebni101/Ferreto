using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreto.Common
{
    public static class Utils
    {
        public static string codigo { get; set; } = Guid.NewGuid().ToString();
    }
}
