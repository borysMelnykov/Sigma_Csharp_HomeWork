using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
   public class Passenger
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public DateTime regDate { get; set; }
        public bool isPrimary { get; set; }
        public int somePrice;
        //Passenger.Make DateOfRegistration field readonly;
        public DateTime DateOfRegistration { get { return DateTime.Now; } } //•	Make DateOfRegistration property only get access method;

        //•	Create parameter constructor for Passenger class.
        public Passenger(string firstName, string lastName, int age, DateTime regDate, bool isPrimary)
        {
            firstName = "Leo";
            lastName = "Messi";
            age = 12;
            regDate = DateTime.Now;
            isPrimary = true;

        }
        public void wde()
        {
           

        }
    }
}


