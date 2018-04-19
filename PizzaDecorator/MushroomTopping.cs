using PizzaDecorator;

public class MushroomTopping : ToppingsDecorator
{
    public MushroomTopping(BasePizza pizzaToDecorate)
        : base(pizzaToDecorate)
    {
        this.myPrice = 1.49;
    }
}
