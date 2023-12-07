using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
   
    public class Prime
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Number :");
            int number = int.Parse(Console.ReadLine());
            bool isprime = true;


            for (int i = 2; i < number / 2; i++)
            {

                if (number % 2 == 0)
                {

                    isprime = false;

                    break;

                }
            }

                if (isprime)
                {

                    Console.WriteLine($"Number {number}is prime");
                }

                else
                {
                    Console.WriteLine($"Number {number} is not prime");

                }
                

            }


        }


    }



