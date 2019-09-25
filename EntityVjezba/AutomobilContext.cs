using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityVjezba
{
    class AutomobilContext:DbContext
    {
        public  DbSet<Automobil>Automobili { get; set; }
    }
}
