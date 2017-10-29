using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Ticket
    {
// 1.	Constructors;
//Create class Ticket with following fields Passenger, Flight; 
//	Create constructor with following parameters Passenger, Flight.

        public int passenger { get; set; } 
        public int flight { get; set; }
       // •	Ticket.Add field priceOfTicket to class Ticket;
        public int priceOfTicket { get; set; }


        public Ticket()
        {
            this.passenger = passenger;
            this.flight = flight;
            
        }
        //•	Ticket.Add method which CalculatePrice price of ticket and set priceOfTicket; 
        public int CalculatePrice(ref int a, int b)
        {
            //int a = 5;
            //int b = 5;
           
            return priceOfTicket = a+b;
        }

        public string Summarize()
        {
            return "Ticket #237;"+ " "+"Section A;" + " " + "Sit #46;";
        }
    }
}
