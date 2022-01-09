using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3]; // 3 elemanlı bir dizi
            students[0] = "Engin";
            students[1] = "derin";
            students[2] = "salih";

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            string[] students2 = new[]{"Engin","Derin","Salih"}; // Bu new[] ifadesini yazmak bu örnekte zorunlu değil.
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            // Çok boyutlu arrayler
            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir"},
                {"1","2","3"},
                {"1","2","3"},
                {"1","2","3"},
                {"1","2","3"}
            };
            for(int i = 0; i <= regions.GetUpperBound(0);i++)
            {
                for(int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}









