using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeatures
{
    class Utility
    {
        public void Call()
        {
            int choice;

            PrintMenu();
            GetChoice();

            //local function
            void GetChoice()
            {
                Console.Write("enter choice: ");
                choice = int.Parse(Console.ReadLine() ?? "0");
            }
            void PrintMenu()
            {

            }
        }
    }
}
