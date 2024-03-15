using FigureClassLibrary;

namespace Test_Figure
{
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void CheckRightTriangle_Test1()
        {
            Triangle figure = new Triangle(1,2,3);
            Assert.IsFalse(figure.CheckRightTriangle());
        }
        [TestMethod]
        public void CheckRightTriangle_Test2()
        {
            Triangle figure = new Triangle(3, 4, 5);
            Assert.IsTrue(figure.CheckRightTriangle());
        }
        [TestMethod]
        public void Circle_GetArea_Test()
        {
            Figure figure = new Circle(1);
            double expected = Math.PI;
            Assert.AreEqual(expected, figure.GetArea());
        }
        [TestMethod]
        public void Triangle_GetArea_Test()
        {
            Figure figure = new Triangle(3, 4, 5);
            double expected = 3*4/2;
            Assert.AreEqual(expected, figure.GetArea());
        }
    }
}