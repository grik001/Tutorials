using DecoratorPattern.Constructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Spoiler(new SportsKit(new Aircondition(new BaseCar())));
            Console.WriteLine($"Car 1 : {car.getDescription()}");

            ICar car2 = new BaseCar();
            Console.WriteLine($"Car 2 : {car2.getDescription()}");

            ICar car3 = new Spoiler(new SportsKit(new BaseCar()));
            Console.WriteLine($"Car 3 : {car3.getDescription()}");


            Console.ReadLine();
        }
    }
}
