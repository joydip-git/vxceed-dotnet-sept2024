using CalculationLibrary;

namespace ExtensionLibrary
{
    public static class ExtensionMethods
    {
        public static int Multiply(this ICalculation calculation, int x, int y) => x * y;

        public static string SayHello(this string str) => $"Hello " + str;
    }
}
