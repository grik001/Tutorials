using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Constructor
{
    public abstract class ExtrasDecorator : ICar
    {
        protected ICar car;

        public ExtrasDecorator(ICar car)
        {
            this.car = car;
        }

        public virtual string getDescription()
        {
            return car.getDescription();
        }

        public virtual double getPrice()
        {
            return car.getPrice();
        }
    }
}
