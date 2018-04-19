using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    public abstract class ToppingsDecorator : BasePizza
    {
        protected BasePizza pizza;
        public ToppingsDecorator(BasePizza pizzaToDecorate)
        {
            this.pizza = pizzaToDecorate;
        }

        public override double GetPrice()
        {
            return (this.pizza.GetPrice() + this.myPrice);
        }
    }

}
