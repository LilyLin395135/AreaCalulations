namespace AreaOfShapeCalulations
{
    public class Calculator
    {
        public double GetTotalArea(params IShape[] shapes)
        {
            //shapes.Sum(s => s.Area());//使用LINQ方式
            var totalArea = 0d;
            foreach (var shape in shapes)
            {
                totalArea += shape.Area();
            }
            return Math.Round(totalArea, 2);
        }
    }
}