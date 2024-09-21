namespace GenericDemo
{
    internal class Program
    {
        //generic method
        //TInput=> type parameter
        //generic with constraint
        //static void Add<TInput>(TInput x, TInput y) where TInput : struct
        static void Add<TInput>(TInput x, TInput y) where TInput : class, new()
        {
            Console.WriteLine(default(TInput));
        }
        static void Add<TInput1, TInput2>(TInput1 x, TInput2 y)
        {
            Console.WriteLine(default(TInput1));
        }
        static TResult? ApplyLogic<TInput, TResult>(TInput num)
        {
            return default(TResult);
        }
        static void Main()
        {
            /*
            //ApplyLogic<int, bool>(12);

            //Add<int>(12, 13);
            //Add<string>("anil", "kumar");

            //Add<int, long>(12, 13456799876);
            ICollectionBase<int> numbers = new MyCollection<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            */

            List<int> list = new List<int>();
            list.Add(1);//0
            list.Add(20);//1
            list.Add(3);//2
            list.Add(4);//3
            list.Add(5);//4
            list.Insert(2, 20);//index number <=count of elements
            list.Remove(20);
            list.RemoveAt(1);
            
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("\n\n");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n\n");
            IEnumerator<int> enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            Console.WriteLine("count: " + list.Count);
            Console.WriteLine($"capacity: {list.Capacity}");
        }
    }
}
