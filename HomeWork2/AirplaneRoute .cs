using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    //•	Create class AirplaneRoute with following fields Airplane and Tickets, Date
    public class AirplaneRoute
    {
        public Airplaine airplaine { get; set; }
        public List<Ticket> tickets { get; set; }
        public DateTime date { get; set; }

        public AirplaneRoute(Airplaine airplaine, List<Ticket> tickets, DateTime date)
        {
            this.airplaine = airplaine;
            this.tickets = tickets;
            this.date = date;

        }


    }
}
