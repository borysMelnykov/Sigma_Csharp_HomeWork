using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class DiscountCalculator
    {
        //Homework 3
        //•	Add new class DiscountCalculator with method 
        //Calculate which receive input parameter price and input parameter discount type:
        //i.  if discount type is None, discount is 0%;
        //ii. if discount type is Low, discount is 1%;

        public double Calculate(double price, DiscountType discountType)
        {
            int discount;

            if (discountType == DiscountType.Low)
            {
                discount = 3;
            }
            else if (discountType == DiscountType.Medium)
            {
                discount = 5;
            }
            else if (discountType == DiscountType.High)
            {
                discount = 7;
            }
            else
            {
                discount = 0;
            }

            return price * (100 - discount) / 100;

            //3.	Rewrite method calculate to switch statement (Homework 3)
            //•	Try to use DiscountCalculator, create passenger with different discount type and calculate discount for different sum;

            //switch (discountType)
            //{
            //    case DiscountType.Low:

            //        return discount = 3;

            //    case DiscountType.Medium:
            //        return discount = 5;

            //    case DiscountType.High:

            //        return discount = 7;
            //    default:
            //        return discount = 0;
            //}
        }

    }
}

