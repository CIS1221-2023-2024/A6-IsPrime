using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace IsPrimeRecursive
{
    internal class IsPrime
    {
        public static Stopwatch MyTimer = new Stopwatch();   //StopWatch
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            
            int choice;
            Console.WriteLine("Option 1: Check if Prime");                                     //Options
            Console.WriteLine("Option 2: All Primes Leading to");
            Console.WriteLine("Option 3: Find the nth Prime");
            Console.WriteLine("Option 4: Prime Factors of a Number");
            Console.WriteLine("Option 5: Find all primes between 2 numbers");
            Console.WriteLine("Option 6: Exit");
            Console.Write("Enter your choice (1-6): ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice != 6)
                {
                    switch (choice)                                                                //Menu System Calling functions repsecting the options
                    {
                        case 1:
                            Option1(); break;
                        case 2:
                            Option2(); break;
                        case 3:
                            Option3(); break;
                        case 4:
                            Option4(); break;
                        case 5:
                            Option5(); break;
                        default:
                            Console.WriteLine("Invalid"); break;                                   //Incase of a invalid entry
                    }
                    Menu();
                }
                else Console.WriteLine("Closing..");
            }
            else
            {
                Console.WriteLine("Invalid Input, Try Again");
            }
        }
        public static bool PrimeCheck(int num, int i = 2)
        {
            if (num < 2) return false;                         //If the num is below 2 then its not a prime
            else if (i * i > num) return true;                   //If N is divisible by i, then not a prime number
            else if (num % i == 0) return false;               //Checks if its prime with the i
            return PrimeCheck(num, i + 1);                     //A recursive loop that incriments i
        }

        public static List<int> PrimeList(int num, int i, List<int> Primelist)
        {
            if (i < num)
            {
                if (PrimeCheck(i) == true)                                                            //For each prime found in PrimeCheck, it is added onto a list
                {
                    Primelist.Add(i);
                }
                return PrimeList(num, i + 1, Primelist);                                                         //Incrimenting the i for each number to be checked
            }
            return Primelist;
        }
        public static void NthFind(int num, int i, int count, List<int> primes)
        {
            if (count < num)
            {
                if (PrimeCheck(i))
                {
                    primes.Add(i);
                    NthFind(num, i + 1, count + 1, primes);                                     //Incriments count  where needed
                }
                else
                {
                    NthFind(num, i + 1, count, primes);
                }
            }
            else Console.WriteLine("The " + num + "th prime is " + primes[count - 1]);         //Reduce a 1 from counter since C# is zero based     
        }

        public static List<int> FactorsofNum(int num, int i, List<int> primes)
        {
            if (i < num)
            {
                if (PrimeCheck(i) && num % i == 0)                                          //Checkings so that if they are prime and divisable  then add to list
                {
                    primes.Add(i);
                }

                FactorsofNum(num, i + 1, primes);                                                  //Incriment i
            }
            return primes;
        }

        public static List<int> PrimeBetween(int max, int min, int i, List<int> primes)
        {
            if(i < max)
            {
                if (PrimeCheck(i))                                                                    //Simple Loop, incriminting I, if prime add to list
                {                                                                                     //Altough similiar to PrimeList(), this one has the Max and Min which is needed
                    primes.Add(i);
                }
                PrimeBetween(max,min, i + 1, primes);   
            }
            return primes;
        }

        public static void Option1()
        {
            int Number;
            Console.WriteLine("Enter A Number");
            string input = Console.ReadLine();
            MyTimer.Start();
            Number = int.Parse(input);                                                            //Switching the string into int
            Console.WriteLine("The number being Prime is " + PrimeCheck(Number));     //Checking if Prime//Getting input From the user
            MyTimer.Stop();
            Console.WriteLine(MyTimer.Elapsed);
        }
        public static void Option2()
        {

            int number;
            Console.WriteLine("Enter A Number");
            string input = Console.ReadLine();                                                      //Getting input From the user
            try
            {
                MyTimer.Start();
                number = int.Parse(input);                                                          //Switching the string into int
                Console.WriteLine("All the Primes leading to that number are ");

                List<int> Primes = PrimeList(number, 2, new List<int>());                           //Making List of Primes
                foreach (int i in Primes)                                                           //Printing
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("");
                MyTimer.Stop();
                Console.WriteLine(MyTimer.Elapsed);
            }
            catch (FormatException)                                                                 //This will catch the error should there be a non int
            {
                Console.WriteLine("Wrong Input");
            }
        }
        public static void Option3()
        {
            int number;
            List<int> primes = new List<int>();
            Console.WriteLine("Enter A Number");
            string input = Console.ReadLine();                                                      //Getting input From the user
            try
            {
                MyTimer.Start();
                number = int.Parse(input);                                                          //Switching the string into int
                if (number > 0)
                {
                    NthFind(number, 2, 0, primes);
                }
                else Console.WriteLine("Too Low");
                MyTimer.Stop();
                Console.WriteLine(MyTimer.Elapsed);
            }
            catch (FormatException)                                                                 //This will catch the error should there be a non int
            {
                Console.WriteLine("Wrong Input");
            }
        }

        public static void Option4()
        {
            int number;
            List<int> primes = new List<int>();
            Console.WriteLine("Enter A Number");
            string input = Console.ReadLine();                                                      //Getting input From the user
            try
            {
                MyTimer.Start();
                number = int.Parse(input);                                                          //Switching the string into int
                if (number > 0)
                {
                    primes = FactorsofNum(number, 2, primes);
                    Console.WriteLine("The Factors of " + number + " are");
                    foreach (int i in primes)                                                           //Printing
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine("");
                }
                else Console.WriteLine("Too Low");
                MyTimer.Stop();
                Console.WriteLine(MyTimer.Elapsed);
            }
            catch (FormatException)                                                                 //This will catch the error should there be a non int
            {
                Console.WriteLine("Wrong Input");
            }
        }

        public static void Option5()
        {
            int num1;
            int num2;
            int i = 0;
            List<int> primes = new List<int>();                                                    //Printing List and getting Input
            Console.WriteLine("Enter A Max");
            string input = Console.ReadLine();
            Console.WriteLine("Enter A Min");
            string input2 = Console.ReadLine();
            try
            {
                MyTimer.Start();
                num1 = int.Parse(input);
                num2 = int.Parse(input2);

                if (num2 > num1)
                {
                    Console.WriteLine("Incorrect");
                }
                else
                {
                    i = num2;
                    primes = PrimeBetween(num1, num2, i, primes);
                    foreach (int x in primes)                                                           //Printing
                    {
                        Console.Write(x + " ");
                    }
                    MyTimer.Stop();
                    Console.WriteLine(MyTimer.Elapsed);
                    Console.WriteLine("");
                }
            }
            catch (FormatException)                                                                 //This will catch the error should there be a non int
            {
                Console.WriteLine("Wrong Input");
            }
        }
    }
}



