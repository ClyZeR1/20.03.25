using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    abstract class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public abstract void SayHello();
    }
    class Russia : Person
    {
        public Russia(string name) : base(name) { }
        public override void SayHello()
        {
            Console.WriteLine($"{Name} говорит: Привет!");
        }
    }
    class Ukrainian : Person
    {
        public Ukrainian(string name) : base(name) { }
        public override void SayHello()
        {
            Console.WriteLine($"{Name} говорит: Привит!");
        }
    }
    class English : Person
    {
        public English(string name) : base(name) { }
        public override void SayHello()
        {
            Console.WriteLine($"{Name} говорит: Hello!");
            Console.ReadKey();
        }
    }
}
