using AreaOfShapeCalulations;

namespace AreaOfShapeCalulationsTests
{
    public class Triangle:IShape
    {
        private double _baseSide;
        private double _height;

        public Triangle(double baseSide, double height)
        {
            this._baseSide = baseSide;
            this._height = height;
        }

        public double Area()
        {
            return (_baseSide*_height)/2;
        }
    }
}