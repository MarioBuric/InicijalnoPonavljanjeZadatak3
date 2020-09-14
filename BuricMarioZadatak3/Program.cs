using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuricMarioZadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 4 == 0 && number % 6 == 0) Console.WriteLine("number is divided with 4 and 6");

            else if (number % 6 == 0) Console.WriteLine("number is divided with 6 ");
            else if(number % 4 == 0) Console.WriteLine("number is divided with 4 ");
            
           
            else if (number % 4 != 0 && number % 6 != 0) Console.WriteLine("number is not divided with 4 and 6 ");

            Console.ReadKey();

        }
    }
}
