using BetaService.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaService.Controller
{
    class DriverDal
    {
        public List<Driver> GetDriverName()
        {
            using (DevContext context = new DevContext())
            {
                return context.Drivers.SqlQuery("select name ,id from table1 where name=@name", new SqlParameter("@name", "Nematullah")).ToList<Driver>();
            }
        }

        public List<Driver> GetAll()
        {
            using (DevContext context = new DevContext())
            {
                //Console.WriteLine("Your data is ", context.Drivers.ToList());
                //dgwDriver.DataSource = context.Drivers.ToList();
                return context.Drivers.ToList();
            }
        }
        public void AddDriver(Driver driver)
        {
            using (DevContext context = new DevContext())
            {
                context.Drivers.Add(driver);
                //var entity = context.Entry(driver);
                //entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void UpdateDriver(Driver driver)
        {
            using (DevContext context = new DevContext())
            {
                var entity = context.Entry(driver);
                entity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
        public void DeleteDriver(Driver driver)
        {
            using (DevContext context = new DevContext())
            {
                var entity = context.Entry(driver);
                entity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }


    }
}
