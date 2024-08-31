using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asks user to enter the number
            Console.WriteLine("Enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            //sets up sum variable, and while statement runs until the num variable runs out of digits
            int sum = 0;
            while (num != 0)
            {
                /* Found the += online, and it makes sense! What it means is the number the user input is divided by 10, and the last digit (in the decimal place) is added to the sum.
                 * Then the num /= 10 removes that last digit, and it repeats until there are no more digits, where it outputs the sum. */
                sum += num % 10;
                num /= 10;
            }
            //prints out sum for user
            Console.WriteLine("The sum of the digits is: " + sum);
            Console.Read();

        }
    }
}
