using PizzaDecorator;

public class JalapenoTopping : ToppingsDecorator
{
    public JalapenoTopping(BasePizza pizzaToDecorate)
        : base(pizzaToDecorate)
    {
        this.myPrice = 1.49;
    }
}