namespace AreaOfShapeCalculations.Shape
{
    public class Square : IShape
    {
        private readonly double _length;

        public Square(double length)
        {
            _length = length;
        }

        public double Area()
        {
            return _length * _length;
        }
    }
}