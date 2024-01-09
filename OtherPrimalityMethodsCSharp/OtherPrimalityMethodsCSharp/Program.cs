using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherPrimalityMethodsCSharp
{
    internal class Program
    {
        public static Process currentProcess;
        public static Stopwatch stopwatch;
        static void Main(string[] args)
        {
            
            
            
            currentProcess = Process.GetCurrentProcess();
            stopwatch = new Stopwatch();
            Menu();
        }


        public static void Menu()
        {
            int number = 0;
            int choice;
            do
            {
                
                Console.WriteLine("Enter a Number");
                string Input = Console.ReadLine();
                try
                {
                    number = int.Parse(Input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect Input");
                    Menu();
                }
                Console.WriteLine("1:Sieve of Eratosthenes");
                Console.WriteLine("2:Miller-Rabin Primality");
                Console.WriteLine("3:Fermat Method");
                Console.WriteLine("4:Exit");
                Console.WriteLine("Choose an Option 1-4");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)                    //Menu System Calling functions repsecting the options
                    {
                        case 1:
                            SEO(number); break;
                        case 2:
                            Console.WriteLine(MR(number)); break;
                        case 3:
                            Console.WriteLine("Enter Number Of Iterations");
                            int Iterations = int.Parse(Console.ReadLine());
                            Console.WriteLine(Fermat(number, Iterations)); break;
                        case 4:
                            Console.WriteLine("Closing.."); break;
                        default:
                            Console.WriteLine("Invalid"); break;             //Incase of a invalid entry
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input, Try Again");
                }
            } while (choice != 4);
        }


        public static void SEO(int Max)
        {
            stopwatch.Start();
            bool[] isPrime = new bool[Max + 1];

            //We first set all numbers as prime
            for (int i = 0; i < Max; i++)
            {
                isPrime[i] = true;
            }

            //This is the Sieve of Eratosthenes Method
            for (int number = 2; number <= Math.Sqrt(Max); number++)  //Primes Below the Sqrt of Max are added and have their multiples removed
            {
                if (isPrime[number])
                {
                    Console.Write(number + " ");


                    for (int M = number * number; M <= Max; M += number)  // Marking the Current Multiples as not prime
                    {
                        isPrime[M] = false;
                    }
                }

            }

            for (int num = (int)Math.Sqrt(Max) + 1; num <= Max; num++)        //Primes Greater than the sqrt of Max are added and printed
            {
                if (isPrime[num])
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine("");
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.WriteLine($"Memory Usage: {Math.Round(currentProcess.WorkingSet64 / (1024.0 * 1024), 2)} MB");


        }

        public static bool MR(int num, int i = 5)
        {
            stopwatch.Start();
            if (num <= 1 || num == 4) //Base Cases
                return false;
            if (num <= 3)
                return true;

            int r = 0;
            int divisor = num - 1;

            while (divisor % 2 == 0)       //Finding num-1 = 2^r * divisor
            {
                r++;
                divisor /= 2;
            }

            Random rand = new Random();
            for (int l = 0; l < i; l++)
            {

                int a = rand.Next(2, num - 1);  // Randon Num


                int x = ModCalc(a, divisor, num);   //Checking Modulus for x


                if (x == 1 || x == num - 1)  //Check Results hence Continue since its likley prime
                    continue;

                // Square and check for additional factors
                for (int j = 0; j < r - 1; j++)
                {
                    x = ModCalc(x, 2, num);
                    if (x == num - 1)
                        break; // Likely prime, proceed to the next iteration
                }
                // If none of the conditions are met, the number is composite
                if (x != num - 1)
                {
                    stopwatch.Stop();
                    Console.WriteLine(stopwatch.Elapsed);
                    Console.WriteLine($"Memory Usage: {Math.Round(currentProcess.WorkingSet64 / (1024.0 * 1024), 2)} MB");
                    return false;
                }
            }
            // If the number passed all iterations, it is prime
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.WriteLine($"Memory Usage: {Math.Round(currentProcess.WorkingSet64 / (1024.0 * 1024), 2)} MB");
            return true;

        }

        public static int ModCalc(int a, int b, int m)
        {
            int result = 1;
            a %= m;
            // Looping for every B
            while (b > 0)
            {
                if (b % 2 == 1)      //if b is 1, Multiply by a and mod by m
                    result = (result * a) % m;
                b /= 2;  // Next B
                a = (a * a) % m;  //Square A and take mod of M
            }
            return result;
        }

        public static bool Fermat(int num, int l)
        {
            stopwatch.Start();
            //Base Cases
            if (num == 2)
                return true;

            if (num == 1 || num % 2 == 0)
                return false;
            
            var Rnum = new Random(); //Random Number Generation

            for (int i = 0; i < l; i++)  //Fermats Theorm
            {
                int a = Rnum.Next(1, num - 1);

                if (ExponentMod(a, num - 1, num) != 1)
                {
                    stopwatch.Stop();
                    Console.WriteLine(stopwatch.Elapsed);
                    Console.WriteLine($"Memory Usage: {Math.Round(currentProcess.WorkingSet64 / (1024.0 * 1024), 2)} MB");
                    return false;
                }
            }
            
            return true;
        }
        private static int ExponentMod(int Base, int exp, int mod)
        {
            if (mod == 1)//Base Case
                return 0;

            int result = 1;
            Base %= mod; //ensuring it stays within the range of the modulus.

            while (exp > 0)
            {
                if (exp % 2 == 1)  // If the least significant bit of exponent is 1
                {
                    result = (result * Base) % mod;
                }
                exp >>= 1;  // Right shift the exponent into a integer division by 2
                Base = (Base * Base) % mod;
            }

            return result;
        }
    }
}
