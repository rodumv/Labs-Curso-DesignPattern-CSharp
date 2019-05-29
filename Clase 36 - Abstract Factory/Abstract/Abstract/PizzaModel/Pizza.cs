using System.Collections.Generic;
using static System.Console;

namespace Abstract
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        protected IDough Dough;
        protected ISauce Sauce;
        protected List<IVeggie> Veggies = new List<IVeggie>();
        protected ICheese Cheese;

        public abstract void Prepare();

        public void Bake() => WriteLine($"Cocinar por 20 min");
        public void Cut() => WriteLine($"Pizza fue cortada en partes iguales");
        public void Box() => WriteLine($"Pizza colocada en caja oficial");

    }

}