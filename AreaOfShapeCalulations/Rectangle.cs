namespace AreaOfShapeCalulations
{
    public class Rectangle
    {
        private readonly double _height;
        private readonly double _width;

        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }

        internal double Area()
        {
            return _height * _width;
        }
    }
}