using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
   public class AirplaneFlight
    {
        public DateTime flightDate { get { return DateTime.Today; } }

        public bool IsTodayFlight()
        {
            return flightDate.Equals(DateTime.Now);
        }
    }
}
