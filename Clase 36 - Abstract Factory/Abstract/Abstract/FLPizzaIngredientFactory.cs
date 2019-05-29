using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class FLPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            throw new NotImplementedException();
        }

        public IDough CreateDough()
        {
            throw new NotImplementedException();
        }

        public ISauce CreateSauce()
        {
            throw new NotImplementedException();
        }

        public List<IVeggie> CreateVeggies()
        {
            throw new NotImplementedException();
        }
    }
}
