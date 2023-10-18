using System;
using System.Collections.Generic;

namespace Program
{
  public class AreaCalculator
  {
    public string Area(List<object> shapes)
    {
      string area = "";
      foreach (var shape in shapes)
      {
        if (shape is Rectangle)
        {
          Rectangle rectangle = (Rectangle)shape;
          area += "Rectangulo: " + rectangle.Width * rectangle.Height;
        }
        else
        {
          Circle circle = (Circle)shape;
          area += "Curculo: " + circle.Radius * circle.Radius * Math.PI;
        }

        area += Environment.NewLine;
      }
      return area;

    }
  }
}