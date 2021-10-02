using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;



namespace ServicesApp
{
   public class DriverDal
    {
        public List<Driver> GetAll()
        {
            using (MainContext context = new MainContext())
            {
                //Console.WriteLine("Your data is ", context.Drivers.ToList());
                //dgwDriver.DataSource = context.Drivers.ToList();
                return context.Drivers.ToList();
            }
        }
        public void AddDriver(Driver driver)
        {
            using(MainContext context=new MainContext())
            {
                context.Drivers.Add(driver);
                //var entity = context.Entry(driver);
                //entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void UpdateDriver(Driver driver)
        {
            using (MainContext context = new MainContext())
            {
                var entity = context.Entry(driver);
                entity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
        public void DeleteDriver(Driver driver)
        {
            using (MainContext context = new MainContext())
            {
                var entity = context.Entry(driver);
                entity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }
    }
}
