using PayrollApp.Entities;

namespace PayrollApp.UserInterface
{
    internal class Program
    {
        static void Main()
        {
            //1. create a single dimensional array to store all types of objects (developer/hr)
            //1.1. ask user about the length of the array

            //2. iterate thorugh the array and create objects based on user choice. ask user to enter the values also.
            //3. sabe the object in the array
            //4. iterate through the array and calculate everyone's salary and print the same

        }
        static void PrintSalary(Employee employee)
        {
            employee.CalculateSalary();
            Console.WriteLine(employee.TotalSalary);
        }
        static Employee Create()
        {
            Console.Write("name: ");
            string? empName = Console.ReadLine();

            Console.Write("id: ");
            int empId = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("basic payment: ");
            double empBasic = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("da payment: ");
            double empDa = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("hra payment: ");
            double empHra = double.Parse(Console.ReadLine() ?? "0");

            Employee employee = new Employee(id: empId, basicPayment: empBasic, daPayment: empDa, hraPayment: empHra, name: empName);

            return employee;
        }
    }
}
