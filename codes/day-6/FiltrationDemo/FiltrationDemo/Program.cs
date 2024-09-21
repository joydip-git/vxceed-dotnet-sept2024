namespace FiltrationDemo
{
    delegate int CalculationDel(int a, int b);
    internal class Program
    {
        static void TestCalculation()
        {
            CalculationDel addDel = delegate (int x, int y)
            {
                return x + y;
            };
            CalculationDel subDel = (x, y) => x - y;

            Console.WriteLine(addDel(1, 2));
            Console.WriteLine(subDel(12, 3));
        }
        static IEnumerable<T> Filter<T>(List<T> list, LogicDel<T> logicRef)
        {
            //List<T> result = new List<T>();
            //or
            //List<T> result = new();

            //or
            //simplified collecion initializer
            List<T> result = [];
            foreach (T item in list)
            {
                if (logicRef(item))
                    result.Add(item);
            }
            return result;
        }
        static void Main()
        {
            TestCalculation();
            //List<int> list = new List<int>();
            //list.Add(1);

            //collection initializer
            var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            LogicDel<int> evenLogic = new Logic().IsEven;
            var evenNumbers = Filter(numbers, evenLogic);

            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n");
            //LogicDel<int> oddLogic = Logic.IsOdd;
            //var oddNumbers = Filter(numbers,oddLogic);
            var oddNumbers = Filter(numbers, Logic.IsOdd);
            foreach (var item in oddNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n");
            LogicDel<int> greaterLogic = delegate (int item)
            {
                return item > 5;
            };
            var greaterNumbers = Filter(numbers, greaterLogic);
            foreach (var item in greaterNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n");
            //Lambda Expression: a new style of creating anonymous method
            //<del-name> <delegate-variable> = (param1,param2,..) => expression-body;

            //LogicDel<int> lesserLogic = (int num) => num < 5;
            //LogicDel<int> lesserLogic = (num) => num < 5;

            //LogicDel<int> lesserLogic = num => num < 5;
            //var lesserNumbers = Filter(numbers, lesserLogic);
            var lesserNumbers = Filter(numbers, num => num < 5);
            foreach (var item in lesserNumbers)
            {
                Console.WriteLine(item);
            }

            List<string> names = ["anil", "sunil", "joydip"];
           
            LogicDel<string> filterByN = (name) => name.Contains('n');
            var filteredNames = Filter(names, filterByN);
            foreach (var item in filteredNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
