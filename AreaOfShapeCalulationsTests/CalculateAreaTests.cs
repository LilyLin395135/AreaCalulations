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

        [TestMethod]
        public void CalculateTriangleArea()
        {
            //Arrange：準備測試資料(物件)
            var triangle = new Triangle(4d, 5d);

            TotalAreaShouldBe(10, triangle);
        }

        [TestMethod]
        public void CalculateDifferentShapesArea()
        {
            //Arrange：準備測試資料(物件)
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
            //Arrange：準備測試資料(物件)
            var rectangle = new Rectangle(3.251d, 1d);
            var circle = new Circle(1d);

            TotalAreaShouldBe(6.39, rectangle, circle);
        }

        [TestMethod]
        public void CalculateNoShapeArea()
        {
            TotalAreaShouldBe(0);
        }

        private void TotalAreaShouldBe(double expected, params IShape[] shape)//params關鍵字允許可變數量的參數傳進params後的陣列。
        {
            //Act：用Calculator
            var result = _calculator.GetTotalArea(shape);
            //Assert：
            Assert.AreEqual(expected, result);
        }
    }
}