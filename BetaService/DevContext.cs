using BetaService.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaService
{

    class DevContext :DbContext
    {
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<DailyDrive> DailyDrive { get; set; }
    }
}
