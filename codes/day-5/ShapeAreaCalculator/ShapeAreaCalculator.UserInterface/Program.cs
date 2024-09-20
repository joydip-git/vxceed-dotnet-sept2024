
using ShapeAreaCalculator.Entities;

namespace ShapeAreaCalculator.UserInterface
{
    internal class Program
    {
        static void Main()
        {
            PrintMenu();
            char shapeChoice = GetChoice();
            Shape? shape = CreateShape(shapeChoice);
            double? area = shape?.CalculateArea();
            Type? shapeType = shape?.GetType();
            Console.WriteLine(area.HasValue ? $"Area of {shapeType?.Name} is {area}" : "no area calculated");
            //if (shape != null)
            //{
            //    double area = shape.CalculateArea();
            //    Console.WriteLine(area);
            //}else
            //    Console.WriteLine("no area calculated");
        }

        private static Shape? CreateShape(char shapeChoice)
        {
            Shape? shape;
            switch (shapeChoice)
            {
                case 'c':
                    Console.Write("\nEnter Radius: ");
                    double radius = double.Parse(Console.ReadLine() ?? "0");
                    shape = new Circle(radius);
                    break;

                case 't':
                    Console.Write("\nEnter Base: ");
                    double tBase = double.Parse(Console.ReadLine() ?? "0");
                    Console.Write("\nEnter Height: ");
                    double tHeight = double.Parse(Console.ReadLine() ?? "0");
                    shape = new Triangle(tBase, tHeight);
                    break;

                default:
                    shape = null;
                    break;
            }
            return shape;
        }

        static void PrintMenu()
        {
            Console.WriteLine("---MENU---");
            Console.WriteLine("1. Circle (c/C)\n2. Triangle(t/T)");
        }
        static char GetChoice()
        {
            Console.Write("\nEnter Choice[c/t/C/T]: ");
            char choice = char.Parse(Console.ReadLine() ?? "c");
            if (char.IsUpper(choice))
                choice = char.ToLower(choice);
            return choice;
        }
    }
}
