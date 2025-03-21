using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    abstract class PrintedProducts
    {
        private string name;
        public PrintedProducts() { }
        public PrintedProducts(string name)
        {
            Name = name;
        }
        public string Name
        {
            get { return name; }
            set { name = (value != "") ? value : "noName"; }
        }
        public abstract void Print();
        public abstract double Cost();
    }
}