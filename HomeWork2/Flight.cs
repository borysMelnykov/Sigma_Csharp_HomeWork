using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Flight
    {
        public string from;
        public string to;
        public int price;
        public string filghtType { get; set; }
        //private DateTime passengerDateOfRegistration;
        //protected string passengerAddress;
        //internal string passengerMobileNumber;

        public Flight(string from, string to, int price, string filghtType)
        {
            this.from = from;
            this.to = to;
            this.price = price;
            this.filghtType = filghtType;
        }
        //public string FilghtType        что было не так?
        //{
        //    get
        //    {
        //        return filghtType;
        //    }
        //    set
        //    {
        //        filghtType = value;
        //    }
        //}

        public enum FilghtType
        {
            Charter,
            Public,
            Service,

        }
    }
}
