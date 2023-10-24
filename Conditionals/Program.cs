using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 10;

            //Console.WriteLine(number == 10? "Number is 10." : "Number is not 10.");

            //if (number == 10)
            //{
            //    Console.WriteLine("Number is 10.");
            //}
            //else if (number == 20)
            //{
            //    Console.WriteLine("Number is 20.");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not 10 or 20.");
            //}

            //switch (number)
            //{
            //    case 10:
            //        console.writeline("number is 10.");
            //        break; //break ile kodu kesiyoruz.
            //    case 20:
            //        console.writeline("number is 20.");
            //        break;
            //    default: //else'e denk
            //        console.writeline("number is not 10 or 20.");
            //        break;
            //}

            //if (number>=0 && number<=100)
            //{
            //    Console.WriteLine("Number is between 0-100.");
            //}
            //else if (number>100 && number<=200)
            //{
            //    Console.WriteLine("Number is between 101-200");
            //}
            //else if (number>200 || number<0)
            //{
            //    Console.WriteLine("Number is less than 0 or greater than 200.");
            //}

            if (number < 100)
            {
                if (number >= 90 && number < 95)
                {
                    //içiçe if blokları kullanılabilir.
                }
                else
                {

                }
            }





            Console.ReadLine();
        }
    }
}
