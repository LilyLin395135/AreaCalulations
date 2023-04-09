namespace AreaOfShapeCalulationsTests
{
    [TestClass]
    public class CalculateAreaTests
    {
        [TestMethod]
        public void CalculateRectangleArea()
        {
            //Arrange�G�ǳƴ��ո��(����)
            var rectangle = new Rectangle(3d, 5d);//�غc�����Ȫ���]������Τ@�w�����M�e�C�غc���i�H����
            //Act�G��Calculator
            var calculator = new Calculator();
            var result = calculator.GetTotalArea(rectangle);
            //Assert�G
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