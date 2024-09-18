using CaculatorApp.Entities;

namespace CalculatorApp.UserInterface
{
    internal class Program
    {
        static void Main()
        {
            char toContinue = 'n';
            do
            {
                PrintMenu();
                int choice = GetChoice();
                GetValue(out int first, out int second);
                //Calculation calculation = new Calculation();
                Calculation calculation = new();
                int? result = Calculate(choice, first, second, calculation);
                Console.WriteLine(result.HasValue ? result.Value : "no result");
                AskToContinue(ref toContinue);
            }
            while (toContinue != 'n');
        }
        static void PrintMenu()
        {
            Console.WriteLine("---Menu---");
            Console.WriteLine("1. Add\n2. Subtract\n3. Multiply\n4. Divide");
        }
        static int GetChoice()
        {
            Console.Write("\nEnter Choice[1/2/3/4]: ");
            return int.Parse(Console.ReadLine() ?? "1");
        }
        static void GetValue(out int first, out int second)
        {
            Console.Write("\nEnter 1st Value: ");
            first = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter 2nd Value: ");
            second = int.Parse(Console.ReadLine() ?? "0");
        }
        static int? Calculate(int choice, int first, int second, Calculation calculation)
        {
            //int? result;
            //switch (choice)
            //{
            //    case 1:
            //        result = calculation.Add(first, second);
            //        break;

            //    case 2:
            //        result = calculation.Subtract(first, second);
            //        break;

            //    case 3:
            //        result = calculation.Multiply(first, second);
            //        break;

            //    case 4:
            //        result = calculation.Divide(first, second);
            //        break;

            //    default:
            //        result = null;
            //        break;
            //}
            int? result = choice switch
            {
                1 => calculation.Add(first, second),
                2 => calculation.Subtract(first, second),
                3 => calculation.Multiply(first, second),
                4 => calculation.Divide(first, second),
                _ => null,
            };
            return result;
        }
        static void AskToContinue(ref char toContinue)
        {
            Console.Write("\nWould you like to continue?[y/Y/n/N]: ");
            toContinue = char.Parse(Console.ReadLine() ?? "n");
            if (char.IsUpper(toContinue))
                toContinue = char.ToLower(toContinue);

        }

    }
}
