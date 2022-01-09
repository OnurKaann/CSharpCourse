using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Add();
            var result = Add2(10 , 20);
            Console.WriteLine(result);
            Console.WriteLine(Add3(1));
            */
            int number1 = 20;
            int number2 = 100;
            var result2 = Add4(ref number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);

            Console.WriteLine(Multiply(40 , 20));
            Console.WriteLine(Add5(1, 2, 3, 4, 5, 6, 7, 8, 9));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        // Parametreli Methodlar 
        static int Add2(int number1, int number2)
        {
            return number1 + number2;
        }
        // Default parametleri Methodlar
        static int Add3(int number1, int number2 = 30)
        {
            return number1 + number2;
        }
        //Challenge ref
        static int Add4(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        // Burda ref yerine out da kullanabiliriz 
        // farkı ==> refte number1 in bir değeri olması gerekiyor(mutlaka) ancak outta bu geçerli değil.

        //method overloading
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;        
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        // Challenge params
        static int Add5(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
