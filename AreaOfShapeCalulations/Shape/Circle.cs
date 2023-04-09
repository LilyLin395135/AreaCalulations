namespace AreaOfShapeCalulations.Shape
{
    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Area()
        {
            return Math.Round(Math.PI * _radius * _radius, 2);
        }
    }
}