namespace Triangle
{
  public class Tracker
  {
    public bool TriangleCheck(int side1, int side2, int side3)
    {
      if ((side1 + side2) <= side3 || (side1 + side3) <= side2 || (side2 + side3) <= side1)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool EquilateralCheck(int side1, int side2, int side3)
    {
      if (side1 == side2 && side2 == side3 && side1 == side3)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool IsoscelesCheck(int side1, int side2, int side3)
    {
      if (side1 == side2 || side1 == side3 || side2 == side3)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}