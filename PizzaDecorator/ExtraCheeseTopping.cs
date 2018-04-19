using PizzaDecorator;

public class ExtraCheeseTopping : ToppingsDecorator
{
    public ExtraCheeseTopping(BasePizza pizzaToDecorate)
        : base(pizzaToDecorate)
    {
        this.myPrice = 0.99;
    }
}
