using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Constructor
{
    public class Spoiler : ExtrasDecorator
    {
        public Spoiler(ICar car) : base(car)
        {

        }

        public override string getDescription()
        {
            return base.getDescription() + " Spoiler";
        }

        public override double getPrice()
        {
            return base.getPrice() + 50;
        }
    }
}
