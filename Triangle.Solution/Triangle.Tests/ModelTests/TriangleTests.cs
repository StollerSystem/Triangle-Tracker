using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TrackerTests
  {
    [TestMethod]
    public void TriangleCheck_IsNotATriangle_true()
    {
      Tracker testTriangle = new Tracker();
      Assert.AreEqual(true, testTriangle.TriangleCheck(2, 2, 8));
    }

    [TestMethod]
    public void TriangleCheck_IsATriangle_false()
    {
      Tracker testTriangle = new Tracker();
      Assert.AreEqual(false, testTriangle.TriangleCheck(5, 5, 5));
    }
    [TestMethod]
    public void EquilateralCheck_AllSidesEqual_true()
    {
      Tracker testTriangle = new Tracker();
      Assert.AreEqual(true, testTriangle.EquilateralCheck(5, 5, 5));
    }
    [TestMethod]
    public void EquilateralCheck_AllSidesEqual_false()
    {
      Tracker testTriangle = new Tracker();
      Assert.AreEqual(false, testTriangle.EquilateralCheck(5, 5, 6));
    }
    [TestMethod]
    public void IsoscelesCheck_TwoSidesEqual_true()
    {
      Tracker testTriangle = new Tracker();
      Assert.AreEqual(true, testTriangle.IsoscelesCheck(5, 5, 6));
    }
    [TestMethod]
    public void IsoscelesCheck_TwoSidesNotEqual_false()
    {
      Tracker testTriangle = new Tracker();
      Assert.AreEqual(false, testTriangle.IsoscelesCheck(3, 4, 5));
    }
    [TestMethod]
    public void ScaleneCheck_AllSidesDifferent_true()
    {
      Tracker testTriangle = new Tracker();
      Assert.AreEqual(true, testTriangle.ScaleneCheck(3, 4, 5));
    }
  }
}