using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client-code
            Margherita pizza = new Margherita();
            Console.WriteLine("Plain Margherita: " + pizza.GetPrice().ToString());

            ExtraCheeseTopping moreCheese = new ExtraCheeseTopping(pizza);
            ExtraCheeseTopping someMoreCheese = new ExtraCheeseTopping(moreCheese);
            Console.WriteLine("Plain Margherita with double extra cheese: " + someMoreCheese.GetPrice().ToString());

            MushroomTopping moreMushroom = new MushroomTopping(someMoreCheese);
            Console.WriteLine("Plain Margherita with double extra cheese with mushroom: " + moreMushroom.GetPrice().ToString());

            JalapenoTopping moreJalapeno = new JalapenoTopping(moreMushroom);
            Console.WriteLine("Plain Margherita with double extra cheese with mushroom with Jalapeno: " + moreJalapeno.GetPrice().ToString());

            Console.ReadLine();
        }
    }
}
