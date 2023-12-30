using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeIterative
{
    //Note Each Option Has A Try and Catch Preventing incorrect Input and Size
    internal class Program
    {
        public static Stopwatch MyTimer = new Stopwatch();
        static void Main(string[] args)
        {
            
            int choice;
            do
            {
                Console.WriteLine("Option 1: Check if Prime");                                     //Options
                Console.WriteLine("Option 2: All Primes Leading to");
                Console.WriteLine("Option 3: Find the nth Prime");
                Console.WriteLine("Option 4: Prime Factors of a Number");
                Console.WriteLine("Option 5: Exit");
                Console.Write("Enter your choice (1-4): ");
                if (int.TryParse(Console.ReadLine(), out choice))
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
                            Console.WriteLine("Closing.."); break;
                        default:
                            Console.WriteLine("Invalid"); break;                                   //Incase of a invalid entry
                    }
                } else
                  {
                    Console.WriteLine("Invalid Input, Try Again");
                  }
            } while (choice != 5);                                                                  //Loops unless Exit is chosen 
        }
        public static bool PrimeCheck(int num)        
        { 
            int Divider = num / 2;                                                                  //Checking if any number below the half of num is divisable
            if (num < 2)
            {
                return false;
            }
            else
            {
                while (Divider >= 2)                                                                 //If Number is 2 or Larger Continue
                {
                    if (num % Divider == 0)                                                          //If Number has no remainders then not prime
                    {
                        return false;
                    }
                    Divider--;                                                                      
                }
                return true;                                                                         //If no Number is Divisable and reached 2 then it is Prime
            }
        }

        public static List<int> PrimeList(int num)
        {
            List<int> Primelist = new List<int>();                                                   //Creating A List
            for (int i = 0; i < num; i++)                                                            //Looping till num
            {
                if(PrimeCheck(i) == true)                                                            //For each prime found in PrimeCheck, it is added onto a list
                {
                    Primelist.Add(i);   
                    i++;
                }
            }
            return Primelist;
        }

        public static void Option1()
        {
            int number;
            Console.WriteLine("Enter A Number");
            string input = Console.ReadLine();                                                      //Getting input From the user
            try
            {
                MyTimer.Start();
                number = int.Parse(input);                                                          //Switching the string into int
                if (number > 0)
                {
                    Console.WriteLine("The number being Prime is " + PrimeCheck(number));           //Checking if Prime
                }
                else Console.WriteLine("Too Low");
                MyTimer.Stop();
                Console.WriteLine(MyTimer.Elapsed);
            }
            catch (FormatException)                                                                 //This will catch the error should there be a non int
            {
                Console.WriteLine("Wrong Input");
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Too Large!");
            }
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
                if (number > 0)
                {
                    Console.WriteLine("All the Primes leading to that number are ");

                    List<int> Primes = PrimeList(number);                                               //Making List of Primes
                    foreach (int i in Primes)                                                           //Printing
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

        public static void Option3()
        {
            int i = 2;
            int Counter = 0;
            int number;
            List<int> Primelist = new List<int>();
            Console.WriteLine("Enter A Number");
            string input = Console.ReadLine();                                                      //Getting input From the user
            try
            {
                MyTimer.Start();
                number = int.Parse(input);                                                          //Switching the string into int
                if (number > 0)
                {
                    do
                    {
                        if (PrimeCheck(i) == true)                                                  //Counter is only indexed when finding a prime, this will help keep track of the nth
                        {
                            Primelist.Add(i);
                            Counter++;
                        }
                        i++;
                    } while (Counter < number);                                                     //Making sure Counter does not exceed the nth given
                    Console.WriteLine("The " + number + "th prime is " + Primelist[Counter - 1]);   //Reduce a 1 from counter since C# is zero based         
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
            
            List<int> Primelist = new List<int>();                                                 //List Creation
            int number;
            Console.WriteLine("Enter A Number");
            string input = Console.ReadLine();                                                      //Getting input From the user
            try
            {
                MyTimer.Start();
                number = int.Parse(input);                                                          //Switching the string into int
                if (number > 0)
                {
                    for (int i = 2; i < number; i++)
                    {
                        if (PrimeCheck(i) && number % i == 0)                                      //Checkings so that if they are prime and divisable  then add to list
                        {
                            Primelist.Add(i);
                        }
                    }

                Console.WriteLine("All the Prime Factors of " + number + " are ");

                foreach (int i in Primelist)                                                        //Printing
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
            catch (System.OverflowException)
            {
                Console.WriteLine("Too Large!");
            }
        }

        
    }
        
}
