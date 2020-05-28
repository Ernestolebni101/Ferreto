using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreto.Dbcontrollers
{
    public class FerretoDbcontext: DbContext
    {
        public FerretoDbcontext(DbContextOptions<FerretoDbcontext> options) :base(options)
        {

        }
    }
}
