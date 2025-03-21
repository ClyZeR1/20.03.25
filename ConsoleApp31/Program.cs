using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main()
        {
            PrintedProducts magazine = new Magazine("Журнал", 500, 3.5);
            PrintedProducts newspaper = new Newspaper("Газета", 12, 0.4, 10000);
            PrintedProducts[] products = new PrintedProducts[] { magazine, newspaper };
            foreach (var product in products)
            {
                product.Print();
                Console.WriteLine($"Общая стоимость: {product.Cost()} USD\n");
            }
            Console.ReadKey();
        }
    }
}