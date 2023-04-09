namespace AreaOfShapeCalulations.Shape
{
    public class Rectangle : IShape
    {
        private readonly double _height;
        private readonly double _width;

        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }

        public double Area()
        {
            return _height * _width;
        }
    }
}