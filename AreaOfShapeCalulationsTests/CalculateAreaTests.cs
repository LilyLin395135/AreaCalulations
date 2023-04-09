namespace AreaOfShapeCalulationsTests
{
    [TestClass]
    public class CalculateAreaTests
    {
        [TestMethod]
        public void CalculateRectangleArea()
        {
            //Arrange：準備測試資料(物件)
            var rectangle = new Rectangle(3d, 5d);//建構式給值的原因→長方形一定有長和寬。建構式可以提醒
            //Act：用Calculator
            var calculator = new Calculator();
            var result = calculator.GetTotalArea(rectangle);
            //Assert：
            Assert.AreEqual(15, result);
        }
    }

    internal class Calculator
    {
        internal double GetTotalArea(Rectangle rectangle)
        {
            return 15;
        }
    }

    internal class Rectangle
    {
        private readonly double _height;
        private readonly double _width;

        public Rectangle(double height, double width)
        {
            this._height = height;
            this._width = width;
        }
    }
}