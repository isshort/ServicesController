using ServicesApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp
{
    class MainContext:DbContext
    {
         
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Service> Services { get; set; }
 
    }
}
