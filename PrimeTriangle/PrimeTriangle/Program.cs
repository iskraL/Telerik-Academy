using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());


            List<int> sequence = new List<int>();
            List<int> sequencePrimes = new List<int>();

            for (int i = 1; i <= input; i++)
            {
                sequence.Add(i);
            }

            for (int i = 0; i < sequence.Count; i++)
            {
                bool isPrime = IsPrime(sequence[i]);
                if (isPrime == true)
                {
                    sequencePrimes.Add(sequence[i]);
                }
            }

            for (int i = 0; i < sequencePrimes.Count; i++)
            {
                for (int j = 1; j <= sequencePrimes[i]; j++)
                {
                    bool isPrime = IsPrime(j);
                    if (isPrime)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine();
            }
        }

        public static bool IsPrime(int number)
        {
            if (number == 1) return true;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
