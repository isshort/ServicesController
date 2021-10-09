using BetaService.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaService.Controller
{
    class ServiceDal
    {
        public List<Service> GetAllServices()
        {
            using (DevContext context = new DevContext())
            {
                return context.Services.ToList();
            }
        }

        public void AddNewSerivce(Service service)
        {
            using (DevContext context = new DevContext())
            {
                context.Services.Add(service);
                context.SaveChanges();
            }
        }
        public void UpdateService(Service service)
        {
            using (DevContext context = new DevContext())
            {
                var entity = context.Entry(service);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteService(Service service)
        {
            using (DevContext context = new DevContext())
            {
                var entity = context.Entry(service);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
