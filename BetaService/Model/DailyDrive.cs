using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaService.Model
{
    class DailyDrive
    {
        public int Id { get; set; }
        public int driverId { get; set; }
        public int serviceId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public float startKm { get; set; }
        public float model { get; set; }
    }
}
