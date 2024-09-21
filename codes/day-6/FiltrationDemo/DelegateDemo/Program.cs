namespace DelegateDemo
{
    //1. delegate declaration
    //delegate signature must match the signature of the callbale method(s)
    //signature =>
    // 1. return type,
    // 2. number, data type and position of parameters

    delegate string Invoker(int num);

    class Utility
    {
        public static string GetMarker(int count)
        {
            return "getting " + count + " markers";

        }
        public string GetWater(int numOfBottles)
        {
            return "getting " + numOfBottles + " bottles of water";

        }
    }
    internal class Program
    {
        static void InvokeDelegate(Invoker funcRef, int value)
        {
            //3. invoking the delegate (calling the method via delegate)
            //Console.WriteLine(funcRef.Invoke(2));
            Console.WriteLine(funcRef(value));
        }
        static void Main()
        {
            //2. create a delegate instance
            //Invoker getMarkerInvoker = new Invoker(Utility.GetMarker);
            //2.a. referring a static method (no need to create an instance of the class having that method)
            Invoker getMarkerInvoker = Utility.GetMarker;
            //2.b. referring an instance method (need to create an instance of the class having that method)
            Utility utility = new();
            Invoker getWaterInvoker = utility.GetWater;

            //anomymous method
            //anonymous delegate (a delegate referring to an anonymous method)
            Invoker getProjectorInvoker = delegate (int num)
            {
                return $"getting {num} projector";
            };

            //passing the method reference via delegate as callback to another method
            InvokeDelegate(getMarkerInvoker, 2);
            InvokeDelegate(getWaterInvoker, 1);
            InvokeDelegate(getProjectorInvoker, 1);
        }
    }
}
