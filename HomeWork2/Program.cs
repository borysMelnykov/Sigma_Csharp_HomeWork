using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new Ticket().Summarize());



            var lennon = new Passenger("John", "Lennon", 28, DateTime.Today, true, DiscountType.High);
            var george = new Passenger("George", "Harrison", 28, DateTime.Today, true, DiscountType.Medium);
            var paul = new Passenger("Paul", "Mccartney", 32, DateTime.Today, true, DiscountType.Low);
            var starr = new Passenger("Starr", "Ringo", 29, DateTime.Today, true, DiscountType.None);


            var airplane = new Airplaine("Boeing 747", 800);
            var flight = new Flight("Kiev", "France", 100, "First class");

            var ticket = new Ticket(lennon, flight);
            var ticket1 = new Ticket(george, flight);
            var ticket2 = new Ticket(paul, flight);
            var ticket3 = new Ticket(starr, flight);


            var tickets = new List<Ticket>();
            tickets.Add(ticket);
            tickets.Add(ticket1);
            tickets.Add(ticket2);
            tickets.Add(ticket3);

            var airplaneRoute = new AirplaneRoute(airplane, tickets, DateTime.Today);


            //4.	Create AirplaneRoute with 5 ticket and calculate discount 
            //for each ticket and calculate sum of discount with using statement for;

            double sumOfDiscount = 0.0;
            DiscountCalculator discountCalculator = new DiscountCalculator();

            for (int i = 0; i < tickets.Count(); i++)
            {
                sumOfDiscount = sumOfDiscount + discountCalculator.Calculate(tickets[i].Flight.price, lennon.DiscountType);


            }
            Console.WriteLine($"forLoop.sumOfDiscount for John Lennon: {sumOfDiscount}");


            //5.Create AirplaneRoute with 5 ticket and calculate discount  for each ticket and calculate sum of discount with using statement foreach;
            // foreach
            sumOfDiscount = 0.0;
            foreach (Ticket card in tickets)
            {
                sumOfDiscount = sumOfDiscount + discountCalculator.Calculate(ticket1.Flight.price, george.DiscountType);
            }
            Console.WriteLine($"foreach loop.sumOfDiscount for George Harrison: {sumOfDiscount}");

            // 6.Create AirplaneRoute with 5 ticket and calculate discount  for each ticket and calculate sum of discount with using statement while;
            sumOfDiscount = 0.0;
            var index = 0;
            while (index < tickets.Count)
            {
                sumOfDiscount += discountCalculator.Calculate(tickets[index].Flight.price, paul.DiscountType);
                index++;
            }
            Console.WriteLine($"while loop.sumOfDiscount for Paul Mccartney: {sumOfDiscount}");
         

            //  7.Create AirplaneRoute with 5 ticket and calculate discount  for each ticket and calculate sum of discount with using statement do while;
            sumOfDiscount = 0.0;
            var count = tickets.Count - 1;
            do
            {
                sumOfDiscount += discountCalculator.Calculate(tickets[count].Flight.price, starr.DiscountType);
                count--;
            }
            while (count >= 0);
            Console.WriteLine($"do while loop.sumOfDiscount for Ringo Starr: {sumOfDiscount}");
            Console.Read();
        }
    }
}
