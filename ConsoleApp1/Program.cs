using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            ReadheadDuck readheadDuck = new ReadheadDuck();

            Duck[] ducks = new Duck[] { mallardDuck, readheadDuck };
            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i].Display());
                Console.WriteLine(ducks[i].Quack());
                Console.WriteLine(ducks[i].Swim());
            }

            Console.ReadKey();
        }
    }

    abstract class Duck
    {
        public string Quack()
        {
            return "Quack " + this.GetType();
        }
        public string Swim()
        {
            return "Swim " + this.GetType();
        }
        abstract public string Display();
    }
    class MallardDuck : Duck
    {
        public override string Display()
        {
            return "Display " + this.GetType();
        }
    }
    class ReadheadDuck : Duck
    {
        public override string Display()
        {
            return "Display " + this.GetType();
        }
    }
}

