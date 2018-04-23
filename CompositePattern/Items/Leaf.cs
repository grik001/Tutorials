using CompositePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Items
{
    public class Leaf : ICompositeComponent
    {
        public void Operation()
        {
            Console.WriteLine("I am a leaf!");
        }
    }
}
