using AreaOfShapeCalulations;

namespace AreaOfShapeCalulationsTests
{
    [TestClass]
    public class CalculateAreaTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new Calculator();//����var�N�ܼƦW�٧אּ�P�W������ܼƦW�٦P
        }

        [TestMethod]
        public void CalculateRectangleArea()
        {
            //Arrange�G�ǳƴ��ո��(����)
            var rectangle = new Rectangle(3d, 5d);//�غc�����Ȫ���]������Τ@�w�����M�e�C�غc���i�H����

            TotalAreaShouldBe(15, rectangle);
        }

        [TestMethod]
        public void CalculateSquareArea()
        {
            //Arrange�G�ǳƴ��ո��(����)
            var square = new Square(3d);

            TotalAreaShouldBe(9, square);
        }

        [TestMethod]
        public void CalculateCircleArea()
        {
            //Arrange�G�ǳƴ��ո��(����)
            var circle = new Circle(4d);

            TotalAreaShouldBe(50.27, circle);
        }

        private void TotalAreaShouldBe(double expected, IShape shape)
        {
            //Act�G��Calculator
            var result = _calculator.GetTotalArea(shape);
            //Assert�G
            Assert.AreEqual(expected, result);
        }
    }
}