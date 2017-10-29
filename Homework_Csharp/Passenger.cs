using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Csharp
{
    class Passenger
    {
        public string firstName;
        public string lastName;
        public int age;
        public DateTime regDate;
        public bool isPrimary;


        public Passenger()
        {
            firstName = "Leo";
            lastName = "Messi";
            age = 12;
            regDate = DateTime.Now;
            isPrimary = true;
        }

    }
}
