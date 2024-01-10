using System;

namespace Prime
{
    public class Prime
    {
        public static void SieveOfEratosthenes(int n)
        {
            bool[] primes = new bool[n + 1];

            for (int i = 0; i <= n; i++)
                primes[i] = true;

            for (int c = 2; c * c <= n; c++)
            {
                if (primes[c] == true)
                {
                    for (int i = c * c; i <= n; i += c)
                        primes[i] = false;
                }
            }

            Console.Write("Prime numbers up to " + n + ": ");
            for (int i = 2; i <= n; i++)
            {
                if (primes[i] == true)
                    Console.Write(i + " ");
            }
        }

        public static void Main()
        {
            Console.Write("Enter number to find prime up to: ");
            string userInput = Console.ReadLine();

            // Attempt to parse the string to an integer
            if (int.TryParse(userInput, out int userInteger))
            {
                Console.WriteLine($"You entered: {userInteger}");
                Console.Write("These are the prime numbers equal or smaller to " + userInteger + ": ");
                SieveOfEratosthenes(userInteger);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
