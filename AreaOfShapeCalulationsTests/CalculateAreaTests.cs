using AreaOfShapeCalulations;

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
            Assert.AreEqual(15d, result);
        }

        [TestMethod]
        public void CalculateSquareArea()
        {
            //Arrange�G�ǳƴ��ո��(����)
            var square = new Square(3d);
            //Act�G��Calculator
            var calculator = new Calculator();
            var result = calculator.GetTotalArea(square);
            //Assert�G
            Assert.AreEqual(9d, result);
        }
    }
}