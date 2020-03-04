using System;

namespace ProjectEulerProject1
{
    class Program
    {
        /*
         * Author: Matthew T Aylward
         * Start Date: March 3rd, 2020
         * Last Modified: March 3rd, 2020
         * Status: COMPLETE
         * 
         * Description: Completing the Project Euler problems for me is a fun means of testing my development skills. Learn more about Project Euler here: https://projecteuler.net/about
         * 
         * Problem Details (https://projecteuler.net/problem=1): If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23. 
         * Find the sum of all the multiples of 3 or 5 below 1000.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Number value is 10");
            int userInput = 1000, count = 0, sum = 0;
            Console.WriteLine(  "UserInput: {0}, " +
                                "Count: {1}, " +
                                "Sum: {2}", userInput, count,sum);
            while (count < userInput) {
                Console.WriteLine("Count: {0}", count);
                if (count % 3 == 0 || count % 5 == 0)
                {
                    sum += count;
                }
                count++; 
            }
            Console.WriteLine("Sum is " + sum);
        }
    }
}
