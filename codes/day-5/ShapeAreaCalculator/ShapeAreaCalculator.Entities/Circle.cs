namespace ShapeAreaCalculator.Entities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle() { }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
