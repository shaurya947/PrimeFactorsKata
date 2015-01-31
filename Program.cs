using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class PrimeFactors
    {
        static void Main(string[] args)
        {
            int[] retArray = generate(1098);

            foreach(int entry in retArray)
                Console.Write(entry + ", ");

            Console.ReadKey();
        }

        //method that takes in an integer and returns its prime factors as a linkedlist of integers
        static int[] generate(int number)
        {
            //if number is less than 2, return empty array
            if (number < 2)
                return new int[0];

            //list to store factors along the way
            LinkedList<int> pFactors = new LinkedList<int>();

            //local variables for loop
            int factor = 0;
            bool found = false;

            while(!isPrime(number))
            {
                //find smallest prime number that divides temp
                factor = 2;
                found = false;
                
                while(factor <= number && !found)
                {
                    if (isPrime(factor) && number % factor == 0)
                        found = true;
                    
                    else
                        factor++;
                }
                

                //add factor to list
                pFactors.AddLast(factor);
                number = number / factor;
            }

            //finally, add temp's data to factors list
            pFactors.AddLast(number);

            return pFactors.ToArray();
            
        }

        //method to check whether or not a given number is prime
        private static Boolean isPrime(int n)
        {
            if (n <= 1)
                return false;

            Boolean isPrime = true;

            for (int i = 2; i <= (n / 2) && isPrime; i++)
                if (n % i == 0)
                    isPrime = false;

            return isPrime;
        }
    }
}
