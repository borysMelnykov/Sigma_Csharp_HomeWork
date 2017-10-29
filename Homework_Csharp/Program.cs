using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Csharp
{
    class Program
    {
       public static void Main(string[] args)
        {
            string surname = "mySurname";
            const int daysOfWeekCount = 7;
            decimal dollarRate = 25;
            var rendomVariable = 28;
            char symbolvariable = '~';
            byte minSpeed = 20;
            long variableLong = 131464646;
            uint uint1 = 146u;
            DateTime date = DateTime.Now;
            string longdate = date.ToLongDateString();
            double variableDouble = 12.42;

            Passenger passenger1 = new Passenger();
          
            Console.WriteLine(passenger1.firstName);
            Console.WriteLine(passenger1.lastName);
            Console.WriteLine(passenger1.age);

            //Console.WriteLine(daysOfWeekCount);
            //Console.WriteLine(surname);
            //Console.WriteLine(longdate);
            Console.ReadKey();

           
        }
    }
}
