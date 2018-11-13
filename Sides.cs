using System;
using System.Collections.Generic;

namespace Triangles {

  public class Program
  {
    public static void Main()
    {
      // List<Triangle> TriangleSides = new List<TriangleSides>() {}
      Console.WriteLine("Enter the length of the first side:");
      string stringFirstSide = Console.ReadLine();
      int FirstSide = int.Parse(stringFirstSide);
      Console.WriteLine("Enter the length of the second side:");
      string stringSecondSide = Console.ReadLine();
      int SecondSide = int.Parse(stringSecondSide);
      Console.WriteLine("Enter the length of the third side:");
      string stringThirdSide = Console.ReadLine();
      int ThirdSide = int.Parse(stringThirdSide);
      Triangle usersTriangle = new Triangle(FirstSide, SecondSide, ThirdSide);
      if(usersTriangle.NotTriangle(FirstSide, SecondSide, ThirdSide))
      {
        Console.WriteLine("That's not a triangle!");
      } else if (usersTriangle.EqualTriangle(FirstSide, SecondSide, ThirdSide)) {
        Console.WriteLine("You've got a Equilateral Triangle!");
      } else if (usersTriangle.IsoTriangle(FirstSide, SecondSide, ThirdSide)) {
        Console.WriteLine("You've got a Isoceles Triangle!");
      } else {
        Console.WriteLine("You've got a Scalene Triangle!");
      }
    }
  }
}
