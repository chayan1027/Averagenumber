using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace averagenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, avarage;
            Console.WriteLine("Enter 1st number :");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number :");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number :");
            number3 = Convert.ToInt32(Console.ReadLine());
            avarage = (number1 + number2 + number3) / 3;
            Console.WriteLine("Avarage of three numbers is {0}", avarage);
            Console.ReadLine();
        }
    }
}
