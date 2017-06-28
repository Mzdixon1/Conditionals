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
        {
            Console.WriteLine("What is the name on the reservation");
            string reserveName = Console.ReadLine();

            Console.WriteLine("How many people in your party?");
            int numberOfPeople = int.Parse(Console.ReadLine());

            double amountEach = 13.00d;

            double totalBill = numberOfPeople * amountEach;
            Console.WriteLine("Reservation: name" + "reserveName"); //concatenate
            Console.WriteLine("Total due: $" + totalBill);

            if(totalBill >= 50)
            {
                double totaldue = totalBill * 1.1;
                Console.WriteLine("You will get a 10% discount");
            }
            else
            {
                Console.WriteLine("You will get a 5% discount");

            }
            Console.WriteLine("total due: 65 - 10% discount");
        }
    }
}
