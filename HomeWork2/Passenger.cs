using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Passenger
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime RegDate { get; set; }
        public bool IsPrimary { get; set; }
        public int SomePrice { get; set; }

        //•	Add new property DiscountType to Passenger class(Homework 3).
        public DiscountType DiscountType { get; set; }

        //Passenger.Make DateOfRegistration field readonly;
        public DateTime DateOfRegistration { get { return DateTime.Now; } } //•	Make DateOfRegistration property only get access method;

        //•	Create parameter constructor for Passenger class.
        public Passenger(string firstName, string lastName, int age, DateTime regDate, bool isPrimary, DiscountType discountType)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            RegDate = regDate;
            IsPrimary = isPrimary;
            DiscountType = discountType;
        }
        public void wde()
        {


        }
    }
}


