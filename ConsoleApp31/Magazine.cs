using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Magazine : PrintedProducts
    {
        private int circulation;
        private double price;
        public Magazine() { }
        public Magazine(string name, int circulation, double price)
            : base(name)
        {
            this.circulation = circulation;
            this.price = price;
        }
        public override void Print()
        {
            Console.WriteLine($"Название: {Name}, количество: {circulation}, {price} USD/штука");
        }
        public override double Cost()
        {
            return circulation * price;
        }
    }
}