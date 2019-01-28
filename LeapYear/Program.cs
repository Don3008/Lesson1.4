using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            double year;
            Console.WriteLine("Введите год, чтобы узнать, является ли он високосным:");
            year = Convert.ToDouble(Console.ReadLine());
            if (year > 0 && year % 1 == 0)
            {
                if (year % 400 == 0 || year % 4 == 0) 
                {
                    Console.WriteLine("Год " + year + " - високосный");
                }
                else
                {
                    Console.WriteLine("Год " + year + " - невисокосный");
                }
            }
            else
            {
                Console.WriteLine("Введено неверное значения для года");
            }
        }
    }
}
