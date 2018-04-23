using CompositePattern.Interfaces;
using CompositePattern.Items;
using System;
using System.Collections.Generic;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICompositeComponent> components = new List<ICompositeComponent>();

            Leaf l1 = new Leaf();


            Branch b1 = new Branch();
            Leaf l2 = new Leaf();
            Leaf l3 = new Leaf();

            Branch b2 = new Branch();
            Leaf l4 = new Leaf();

            b1.AddComponent(l2);
            b1.AddComponent(l3);
            b1.AddComponent(b2);
            b2.AddComponent(l4);

            l1.Operation();
            b1.Operation();
            b2.Operation();

            Console.ReadLine();
        }
    }
}
