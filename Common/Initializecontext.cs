using Ferreto.Models;
using Ferreto.Models.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreto.Common
{
    public static class Initializecontext
    {

        public static FerretoSContext initcontext()
        {
            var optionsbuilder = new DbContextOptionsBuilder<FerretoSContext>();
            optionsbuilder.UseSqlServer(Parameter.Connectionstring);
            var context = new FerretoSContext(optionsbuilder.Options);
            return context;
        }

    }
}
