using BetaService.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaService.Controller
{
    class DailyDriveDal
    {

        public List<DailyDrive> GetAllDaily()
        {
            using (DevContext context = new DevContext())
            {

                return context.DailyDrive.ToList();

            }
        }


        public void AddDailyDrive(DailyDrive dailyDrive)
        {
            using (DevContext context = new DevContext())
            {
                var entity = context.Entry(dailyDrive);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void UpdateDailDrive(DailyDrive dailyDrive)
        {
            using (DevContext context = new DevContext())
            {
                var entity = context.Entry(dailyDrive);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteDailyDrive(DailyDrive dailyDrive)
        {
            using (DevContext context = new DevContext())
            {
                var entity = context.Entry(dailyDrive);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
