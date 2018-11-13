using System;
namespace Triangles {

  class Triangle
  {
    private int FirstSide;
    private int SecondSide;
    private int ThirdSide;

    public Triangle(int firstSide, int secondSide, int thirdSide)
    {
      FirstSide = firstSide;
      SecondSide = secondSide;
      ThirdSide = thirdSide;
    }
    
    public bool NotTriangle(int FirstSide, int SecondSide, int ThirdSide)
    {
      return((FirstSide + SecondSide <= ThirdSide)||
              (SecondSide + ThirdSide <= FirstSide)||
              (FirstSide + ThirdSide <= SecondSide));
    }
    public bool EqualTriangle(int FirstSide, int SecondSide, int ThirdSide){
      return((FirstSide == SecondSide) && (SecondSide == ThirdSide));
    }
    public bool IsoTriangle(int FirstSide, int SecondSide, int ThirdSide){
      return((FirstSide == SecondSide)||
              (SecondSide == ThirdSide)||
              (ThirdSide == FirstSide));
    }
  }
}
