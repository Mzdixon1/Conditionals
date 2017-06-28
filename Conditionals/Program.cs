using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        //        {
        //            Console.WriteLine("What is the name on the reservation");
        //            string reserveName = Console.ReadLine();

        //            Console.WriteLine("How many people in your party?");
        //            int numberOfPeople = int.Parse(Console.ReadLine());

        //            double amountEach = 13.00d;

        //            double totalBill = numberOfPeople * amountEach;
        //            Console.WriteLine("Reservation: name" + "reserveName"); //concatenate
        //            Console.WriteLine("Total due: $" + totalBill);

        //            double totalBill = double.Parse(Console.ReadLine());

        //            if (totalBill >= 50)
        //            {

        //                Console.WriteLine("You will get a 10% discount");
        //                Console.WriteLine("Your total with discount: $" + discountTen);
        //            }
        //            else
        //            {
        //                Console.WriteLine("You will get a 5% discount");
        //                Console.WriteLine("Your total with discount: $" + discountFive);
        //            }
        //            Console.WriteLine("total due: 65 - 10% discount");
        //        }
        //    }
        //}
        {
            Console.WriteLine("What is your age");
            int age = int.Parse(Console.ReadLine());
             if (age >= 0 && age <= 2)
            {
                Console.WriteLine("Still in Mama's Arms");

            }
            else if (age == 3 || age == 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (age >= 5 && age <= 11)
            {
                Console.WriteLine("Elementary School");
            }
            else if (age >= 12 && age <= 14)
            {
                Console.WriteLine("Middle School");
            }
            else if (age >= 15 && age <= 18)
            {
                Console.WriteLine("High School");
            }
            else if (age >= 19 && age <= 22)
            {

            }
            else if (age >= 23 && age <= 65)
            {
                Console.WriteLine("Working for the Man");
            } 
            else if (age >= 66 && age <= 100)
            {
                Console.WriteLine("The Golden Years");
            }
        }
    }
}