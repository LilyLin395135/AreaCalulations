namespace AreaOfShapeCalulations
{
    public class Square
    {
        private readonly double _length;

        public Square(double length)
        {
            _length = length;
        }

        internal double Area()
        {
            return _length * _length;
        }
    }
}