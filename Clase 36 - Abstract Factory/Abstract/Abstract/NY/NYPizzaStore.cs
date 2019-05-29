using System;

namespace Abstract
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            return (Pizza)Activator.
                CreateInstance(Type.GetType($"Abstract.{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"), ingredientFactory);
        }

    }

}