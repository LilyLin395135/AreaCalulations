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
            _calculator = new Calculator();//拿掉var將變數名稱改為與上面欄位變數名稱同
        }

        [TestMethod]
        public void CalculateRectangleArea()
        {
            //Arrange：準備測試資料(物件)
            var rectangle = new Rectangle(3d, 5d);//建構式給值的原因→長方形一定有長和寬。建構式可以提醒

            TotalAreaShouldBe(15, rectangle);
        }

        [TestMethod]
        public void CalculateSquareArea()
        {
            //Arrange：準備測試資料(物件)
            var square = new Square(3d);

            TotalAreaShouldBe(9, square);
        }

        [TestMethod]
        public void CalculateCircleArea()
        {
            //Arrange：準備測試資料(物件)
            var circle = new Circle(4d);

            TotalAreaShouldBe(50.27, circle);
        }

        private void TotalAreaShouldBe(double expected, IShape shape)
        {
            //Act：用Calculator
            var result = _calculator.GetTotalArea(shape);
            //Assert：
            Assert.AreEqual(expected, result);
        }
    }
}