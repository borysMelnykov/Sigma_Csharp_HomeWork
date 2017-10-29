using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public static class TicketCalculator
    {
       // •	Add static class TicketCalculator, add static method Calculate which will receive as input parameter Ticket return price; 
        public static int Calculate( ref Ticket p) //8.	Change TicketCalculator method Calculate parameter input amount with ref keyword and out keyword and do previous point.
        {
            int a = 5;
            int b = 5;

            return p.CalculatePrice(ref a,b);
        }
         //•	add static method(overloaded) Calculate which will receive as input parameter Passenger and Flight return price; 
        public static bool Calculate(Passenger p, Flight f)
        {
            f.price = 10;
            p.somePrice = 5;
            int price = f.price * p.somePrice;
            return price.Equals(500);//•	Create event TicketAdded and call it after adding purchase in Add method.
            //7.In TicketCalculator to method Calculate try change received parameter amount and check it after calling parameter, try do the same for Ticket price. 

    }

}
}
//12345