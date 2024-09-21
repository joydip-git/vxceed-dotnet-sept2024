namespace FiltrationDemo
{
    delegate bool LogicDel<in T>(T value);

    internal class Logic
    {
        public bool IsEven(int num) => num % 2 == 0;
        public static bool IsOdd(int num) => num % 2 != 0;
    }
}
