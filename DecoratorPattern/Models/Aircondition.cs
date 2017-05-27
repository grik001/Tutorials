using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Constructor
{
    public class Aircondition : ExtrasDecorator
    {
        public Aircondition(ICar car) : base(car)
        {

        }

        public override string getDescription()
        {
            return base.getDescription() + " AC";
        }

        public override double getPrice()
        {
            return base.getPrice() + 500;
        }
    }
}
