using ServicesApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesApp.Controller
{
    class ServiceDal
    {
        public List<Service> GetAllServices()
        {
            using(MainContext context=new MainContext())
            {
                return context.Services.ToList();
            }
        }

        public void AddNewSerivce(Service service)
        {
            using(MainContext context=new MainContext())
            {
                context.Services.Add(service);
                context.SaveChanges();
            }
        }
        public void UpdateService(Service service)
        {
            using(MainContext context =new MainContext())
            {
                var entity = context.Entry(service);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteService(Service service)
        {
            using (MainContext context = new MainContext())
            {
                var entity = context.Entry(service);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
