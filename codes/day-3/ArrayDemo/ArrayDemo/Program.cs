namespace ArrayDemo
{
    internal class Program
    {
        static void Main()
        {
            /*
            //string[] names = new string[] { "anil", "sunil", "suresh" };
            string[] names = { "anil", "sunil", "suresh" };

            Person[] people = [
                new Person(1, "anil"),
                new Person(2, "sunil"),
                new Person(3, "vinod")
            ];

            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"enter value for index={i}: ");
                numbers[i] = int.Parse(Console.ReadLine() ?? "0");
            }
            Console.WriteLine("\nValues\n");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            //Person p = new Person();
            //p.Id = 1;
            //p.Name = "Test";
            //p[0] = 1;
            //p[1] = "Test";

            //p["id"] = 1;
            //p["name"] = "Test";

            //Console.WriteLine(p["id"]);
            //Console.WriteLine(p["name"]);
            //Console.WriteLine(p["unknown"]);
            */
            int[,] twoDimArr = new int[2, 3];
            for (int i = 0; i < twoDimArr.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimArr.GetLength(1); j++)
                {
                    Console.Write($"enter value at [{i}][{j}]: ");
                    twoDimArr[i, j] = int.Parse(Console.ReadLine() ?? "0");
                }
            }
            Console.WriteLine("\nvalues\n");
            for (int i = 0; i < twoDimArr.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimArr.GetLength(1); j++)
                {
                    Console.WriteLine($"value at [{i}][{j}]: {twoDimArr[i, j]}");
                }
            }
        }
    }
}
