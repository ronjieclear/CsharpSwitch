using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day;
            Console.Write("Enter day number 1-7: ");
            day = int.Parse(Console.ReadLine());
            switch(day)
            {
               case 1:
                    Console.WriteLine("Monday");
                    break;
               case 2:
                    Console.WriteLine("Tuesday");
                    break;
               case 3:
                    Console.WriteLine("Wednesday");
                    break;
               case 4:
                    Console.WriteLine("Thursday");
                    break;
               case 5:
                    Console.WriteLine("Friday");
                    break;
               case 6:
                    Console.WriteLine("Saturday");
                    break;
               case 7:
                    Console.WriteLine("Sunday");
                    break;
               default:
                    Console.WriteLine("Not in the option");
                    break;
            }//end of switch

            Console.ReadLine();
        }
    }
}
