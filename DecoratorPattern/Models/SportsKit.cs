using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Constructor
{
    public class SportsKit : ExtrasDecorator
    {
        public SportsKit(ICar car) : base(car)
        {

        }

        public override string getDescription()
        {
            return base.getDescription() + " SportsKit";
        }

        public override double getPrice()
        {
            return base.getPrice() + 1000;
        }
    }
}
