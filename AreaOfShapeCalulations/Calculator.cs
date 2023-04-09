namespace AreaOfShapeCalulations
{
    public class Calculator
    {
        public double GetTotalArea(Rectangle rectangle)
        {
            return rectangle.Area();
        }

        public double GetTotalArea(Square square)
        {
            return square.Area();
        }
    }
}