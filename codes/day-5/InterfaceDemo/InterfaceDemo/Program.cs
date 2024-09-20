namespace InterfaceDemo
{
    interface ICalculation
    {
        //const int DATA = 100;
        //static int x = 10;
        int Add(int x, int y);
        string? Name { set; get; }
    }
    interface IOperations
    {
        int Subtract(int x, int y);
    }
    class A { }
    class Calculation : A, ICalculation, IOperations
    {
        string? name;
        public int Add(int x, int y) { return x + y; }
        public string? Name { set => name = value; get => name; }
        public int Subtract(int x, int y) { return x - y; }
    }
    interface Keyboard
    {
        void Type();
        string? TypingSettings { set; get; }
    }
    abstract class Device : Keyboard
    {
        string? settings;
        public abstract void Type();
        public string? TypingSettings
        {
            set => settings = value; get => settings;
        }
    }
    //class Laptop : Keyboard
    class Laptop : Device
    {
        //public void Type() { }
        public override void Type()
        {

        }
    }
    class Mobile : Keyboard
    {
        public string? TypingSettings
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public void Type() { }
    }
    internal class Program
    {
        static void Main()
        {
            Calculation calculation = new Calculation();
            //implicit invocation of interface members (via reference variable of the class itself)
            calculation.Add(1, 2);
            calculation.Subtract(10, 2);
            calculation.Name = "anil";

            //explicit invocation of interface members (via reference variable of the interface itself)
            ICalculation calc = new Calculation();
            calc.Add(1, 2);
            calculation.Name = "anil";

            IOperations operations = new Calculation();
            operations.Subtract(10, 2);
        }
    }
}
