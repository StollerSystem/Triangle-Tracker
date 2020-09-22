using System;
using System.Collections.Generic;
namespace Triangle
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter three numbers to see what type of triangle it would make: ");
      string stringSides = Console.ReadLine();
      string[] sidesArray = stringSides.Split(" ");

      Console.WriteLine("side 1: " + sidesArray[0]);
      Console.WriteLine("side 2: " + sidesArray[1]);
      Console.WriteLine("side 3: " + sidesArray[2]);

      int side1 = int.Parse(sidesArray[0]);
      int side2 = int.Parse(sidesArray[1]);
      int side3 = int.Parse(sidesArray[2]);

      Tracker tracker = new Tracker();

      if (tracker.EquilateralCheck(side1, side2, side3))
      {
        Console.WriteLine("This is an Equalateral Triangle!");

      }
      else if (tracker.IsoscelesCheck(side1, side2, side3))
      {
        Console.WriteLine("This is an Isosceles Triangle!");
      }
      else if (tracker.TriangleCheck(side1, side2, side3))
      {
        Console.WriteLine("This is not a Triangle!!!");
      }
      else
      {
        Console.WriteLine("This is an Scalene Triangle!");
      }
    }
  }
}