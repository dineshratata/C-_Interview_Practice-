using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    
        public class finonacciSeries
        {
            static void Main(string[] args)
            {
                Console.Write("Please enter the Length of the Fibonacci Series : ");
                int number = int.Parse(Console.ReadLine());
                fibonacciseries(0, 1, 1, number);

                Console.ReadKey();


            }

            public static void fibonacciseries(int firstNumber, int secondNumber, int counter, int number)
            {
                Console.Write(firstNumber + " ");
                if (counter < number)
                {
                    fibonacciseries(secondNumber, firstNumber + secondNumber, counter + 1, number);


                     
                }
            }
        }
    }


