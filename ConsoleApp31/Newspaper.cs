using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Newspaper : PrintedProducts
    {
        private int PageCount;       // Кол-во страниц
        private double pricePerPage; // Стоимость страницы
        private int circulation;     // Тираж
        public Newspaper() { }
        public Newspaper(string name, int pageCount, double pricePerPage, int circulation)
            : base(name)
        {
            this.PageCount = pageCount;
            this.pricePerPage = pricePerPage;
            this.circulation = circulation;
        }
        public override void Print()
        {
            Console.WriteLine($"Газета: {Name}, {PageCount} листов, {pricePerPage} USD/лист, Тираж: {circulation}");
        }
        public override double Cost()
        {
            return PageCount * pricePerPage * circulation;
        }
    }
}