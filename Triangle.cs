using System;
namespace Triangles {

  class Triangle
  {
    public int FirstSide;
    public int SecondSide;
    public int ThirdSide;

    public Triangle(int firstSide, int secondSide, int thirdSide)
    {
      FirstSide = firstSide;
      SecondSide = secondSide;
      ThirdSide = thirdSide;
    }
    public int GetFirstSide()
    {
      return FirstSide;
    }
    public int GetSecondSide()
    {
      return SecondSide;
    }
    public int GetThirdSide()
    {
      return ThirdSide;
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
