using System;
using System.Collections.Generic;

namespace Program
{
  class Program
  {
    static void Main(string[] args)
    {
      var areaCalculator = new AreaCalculator();
      var shapes = new List<object>()
      {
          new Rectangle { Width = 40, Height = 20},
          new Circle {Radius = 10}
      };
      Console.WriteLine(areaCalculator.Area(shapes));
    }
  }
}
