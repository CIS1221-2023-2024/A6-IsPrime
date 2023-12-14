using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeRecursive
{
    internal class IsPrime
    {
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
                Console.WriteLine("Option 5: Exit");
                Console.Write("Enter your choice (1-4): ");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                  if( choice != 5)
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
        public static bool PrimeCheck(int num, int Divider)
        {
            if (num < 2) return false;                               //If the num is below 2 then its not a prime
            else if (Divider <= 1) return true;                      //If after all the loops an no divider lead to no remainders then its prime
            else if (num % Divider == 0) return false;               //Checks if its prime with the divider
            return PrimeCheck(num, Divider - 1);                     //A recursive loop that decremnets the divider
        }

        public static List<int> PrimeList(int num, int i, List<int> Primelist)
        {
            if (i < num)
            {
                if (PrimeCheck(i, i / 2) == true)                                                            //For each prime found in PrimeCheck, it is added onto a list
                {
                    Primelist.Add(i);
                }
             return PrimeList(num, i + 1,Primelist);                                                         //Incrimenting the i for each number to be checked
            }
             return Primelist;
        }
        public static void NthFind(int num, int i, int count, List<int> primes)
        {
            if(count < num)
            {
                if(PrimeCheck(i, i / 2))
                {
                    primes.Add(i);
                    NthFind(num,i+1, count+1, primes);
                }
                else
                {
                    NthFind(num, i + 1, count, primes);
                }
            } else Console.WriteLine("The " +  num + "th prime is " + primes[count - 1] );         //Reduce a 1 from counter since C# is zero based     
        }

        public static List<int> FactorsofNum(int num, int i, List<int> primes)
        {
            if (i < num)
            {
                if (PrimeCheck(i, i / 2) && num % i == 0)                                          //Checkings so that if they are prime and divisable  then add to list
                {
                    primes.Add(i);
                }

                FactorsofNum(num, i + 1, primes);                                                  //Incriment i
            }
            return primes;
        }

        public static void Option1()
        {
            int Number;
            Console.WriteLine("Enter A Number");
            string input = Console.ReadLine();
            Number = int.Parse(input);                                                            //Switching the string into int
            Console.WriteLine("The number being Prime is " + PrimeCheck(Number, Number / 2));     //Checking if Prime//Getting input From the user
        }
        public static void Option2()
        {
            int number;
            Console.WriteLine("Enter A Number");
            string input = Console.ReadLine();                                                      //Getting input From the user
            try
            {
                number = int.Parse(input);                                                          //Switching the string into int
                Console.WriteLine("All the Primes leading to that number are ");

                List<int> Primes = PrimeList(number, 2, new List<int>());                           //Making List of Primes
                foreach (int i in Primes)                                                           //Printing
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("");
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
                number = int.Parse(input);                                                          //Switching the string into int
                if (number > 0)
                {
                    NthFind(number, 2, 0, primes);                                                                       
                }
                else Console.WriteLine("Too Low");
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
            }
            catch (FormatException)                                                                 //This will catch the error should there be a non int
            {
                Console.WriteLine("Wrong Input");
            }
        }
    }
}
