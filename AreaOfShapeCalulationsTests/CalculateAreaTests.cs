using AreaOfShapeCalulations;
using AreaOfShapeCalulations.Shape;

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

        [TestMethod]
        public void CalculateTriangleArea()
        {
            //Arrange�G�ǳƴ��ո��(����)
            var triangle = new Triangle(4d, 5d);

            TotalAreaShouldBe(10, triangle);
        }

        [TestMethod]
        public void CalculateDifferentShapesArea()
        {
            //Arrange�G�ǳƴ��ո��(����)
            var rectangle1 = new Rectangle(3d, 5d);
            var rectangle2 = new Rectangle(4d, 8d);
            var circle = new Circle(4d);
            var square = new Square(3d);
            var triangle = new Triangle(4d, 5d);

            TotalAreaShouldBe(
                116.27,
                rectangle1,
                rectangle2,
                circle,
                square,
                triangle);
        }

        [TestMethod]
        public void CalculateShapesArea()
        {
            //Arrange�G�ǳƴ��ո��(����)
            var rectangle = new Rectangle(3.251d, 1d);
            var circle = new Circle(1d);

            TotalAreaShouldBe(6.39, rectangle, circle);
        }

        [TestMethod]
        public void CalculateNoShapeArea()
        {
            TotalAreaShouldBe(0);
        }

        private void TotalAreaShouldBe(double expected, params IShape[] shape)//params����r���\�i�ܼƶq���ѼƶǶiparams�᪺�}�C�C
        {
            //Act�G��Calculator
            var result = _calculator.GetTotalArea(shape);
            //Assert�G
            Assert.AreEqual(expected, result);
        }
    }
}