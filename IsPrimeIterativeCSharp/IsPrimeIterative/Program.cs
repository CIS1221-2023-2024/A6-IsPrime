using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeIterative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter A Number");
            string input = Console.ReadLine();                                                      //Getting input From the user
            try
            {
                number = int.Parse(input);                                                          //Switching the string into int
                Console.WriteLine("The number being Prime is " + PrimeCheck(number));               //Checking if Prime
                Console.WriteLine("All the Primes leading to that number are ");

                List<int> Primes = PrimeList(number);                                               //Making List of Primes
                foreach (int i in Primes)                                                           //Printing
                {
                    Console.Write(i + " ");
                }
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
        public static bool PrimeCheck(int num)        
        { 
            int Divider = num / 2;                                                                  //Checking if any number below the half of num is divisable
            if (num < 2)
            {
                return false;
            }
            else
            {
                while (Divider >= 2)
                {
                    if (num % Divider == 0)
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
            List<int> Primelist = new List<int>();
            for (int i = 0; i < num; i++)                                                
            {
                if(PrimeCheck(i) == true)                                                            //For each prime found in PrimeCheck, it is added onto a list
                {
                    Primelist.Add(i);   
                    i++;
                }
            }
            return Primelist;
        }
    }
        
}
