﻿using CaculatorApp.Entities;
//static import
using static CalculatorApp.UserInterface.utility.CalculatorUtility;

namespace CalculatorApp.UserInterface
{
    internal class Program
    {
        static void Main()
        {
            char toContinue = 'n';
            do
            {
                //1. prints menu
                PrintMenu();

                //2. ask for choice from user
                int choice = GetChoice();

                //3. ask user to enter values
                GetValue(out int first, out int second);

                //4. perform calculation
                //Calculation calculation = new Calculation();
                Calculation calculation = new();                
                int? result = Calculate(choice, first, second, calculation);

                //5. print calculation result
                Console.WriteLine(result.HasValue ? result.Value : "no result");

                //6. ask user whether to terminate or continue
                AskToContinue(ref toContinue);
            }
            while (toContinue != 'n');
        }
    }
}
