using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            var varKeyword = 10;
            char character = 'A';
            bool condition = true;
            byte number4 = 0; // ==> 0 - 255
            short number3 = 130;
            int number1 = 56789;
            long number2 = 1234567890;
            double number5 = 10;
            number5 = 65.433;
            decimal number6 = 10.4m;
            Console.WriteLine(number1);
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Condition is {0}", condition);
            Console.WriteLine("Character is {0}", character);
            Console.WriteLine("(int)Character is {0}", (int)character);
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
        enum Days
        {
            Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
        }
    }
}   
    

