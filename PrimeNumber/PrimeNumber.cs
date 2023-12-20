using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
   
    public class Prime
    {
       public static void primenumber ()
        {

            int firstnumber = 0;
            int secondnumber = 1;
            int nextNumber;
            int numberofElements;

             Console.Write("Enter number of Elements:");

            numberofElements = int.Parse(Console.ReadLine());

            if(numberofElements < 2) {

                Console.Write("Enter number Greater than two");
            
            
            }

            else
            {

               Console.Write(firstnumber + " " +  secondnumber + " ");

            }


            for (int i = 2;numberofElements > i;i++ )
            {
                nextNumber = firstnumber + secondnumber;

                Console.Write(nextNumber+ " ");

                

                firstnumber = secondnumber;

                secondnumber = nextNumber;



            }

            



            Console.ReadKey();  


            }


        }


    }



