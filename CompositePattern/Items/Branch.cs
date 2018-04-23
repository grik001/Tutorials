using CompositePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Collections;

namespace CompositePattern.Items
{
    public class Branch : ICompositeComponent, IEnumerable<ICompositeComponent>
    {
        public List<ICompositeComponent> Components { get; set; }

        public Branch()
        {
            Components = new List<ICompositeComponent>();
        }

        public void Operation()
        {
            Console.WriteLine($"I am a Branch: Number of Children: {Components.Count}");
        }

        public void AddComponent(ICompositeComponent component)
        {
            Components.Add(component);
        }

        public void RemoveChild(ICompositeComponent component)
        {
            Components.Remove(component);
        }

        public IEnumerator<ICompositeComponent> GetEnumerator()
        {
            foreach (ICompositeComponent child in Components)
            {
                yield return child;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
