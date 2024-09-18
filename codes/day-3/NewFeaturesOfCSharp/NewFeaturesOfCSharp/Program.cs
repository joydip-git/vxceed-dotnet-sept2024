namespace NewFeaturesOfCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  //Nullable<int> numData = null;
            //? -> can be used to declare a nullable value type
            int? numData = null;
            numData = 10;

            if (numData.HasValue)
            {
                Console.WriteLine(numData);
            }
            else
                Console.WriteLine("no data");

            //? -> can be used to declare a nullable reference type
            string? name = "anil";
            //if (name != null)
            //    name.Split(' ');

            //? -> null check
            //name?.Split(' ');

            //Console.WriteLine(name != null ?  name:"no name");
            //or
            //?? -> null coalesce operator
            Console.WriteLine(name ?? "no name");

            //null coalesce assignment
            name ??= "joydip";
            Console.WriteLine(name);
             */

            int a = 10;
            int b = 20;
            //int c;
            //int addRes = Add(a, ref b, out c);

            //in-line out variable
            //int addRes = Add(a, ref b, out int c);

            //named arguments
            int addRes = Add(y: ref b, z: out int c, x: a);
            Console.WriteLine($"Main: {a},{b},{c}");
            Console.WriteLine(addRes);

            Console.WriteLine("enter value: ");
            int val = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("enter dob: ");
            //DateTime dob = DateTime.Parse(Console.ReadLine() ?? "");

            bool possibleOrNot = DateTime.TryParse(Console.ReadLine(), out DateTime dob);
            Console.WriteLine(dob);
            
            CalculateArea(12);
            CalculateArea(12, 13);
        }
        static bool TP(string? s, out DateTime dob)
        {
            dob = DateTime.MinValue;
            if (s != null)
            {
                dob = DateTime.Parse(s);
                return true;
            }
            return false;
        }
        static int Add(int x, ref int y, out int z)
        {
            Assign(out z);
            Console.WriteLine($"Add =>{x},{y},{z}");
            x = 11;
            y = 22;

            Console.WriteLine($"Add =>{x},{y},{z}");
            int res = x + y + z;
            return res;
        }
        static void Assign(out int m)
        {
            m = 33;
        }
        //optional arguments with default value
        static double CalculateArea(double a, double b = 0, double c = 0, double d = 0)
        {
            return a + b + c + d;
        }
    }
}
