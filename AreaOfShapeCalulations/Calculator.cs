namespace AreaOfShapeCalulations
{
    public class Calculator
    {
        public double GetTotalArea(IShape shape)
        {
            return shape.Area();
        }
    }
}