using PayrollApp.Entities;

namespace PayrollApp.UserInterface
{
    internal class Program
    {
        static void Main()
        {

            //Employee? employee = Create();
            
            //Create(out Employee employee);

            Employee? employee = null;
            Create(ref employee);
            employee?.CalculateSalary();
            Console.WriteLine($"{employee?.Name} working for {Employee.COMPANY} having Id:{employee?.Id} got {employee?.TotalSalary} as salary");

        }

        //method to create an employee instance with values from user
        //static Employee Create()
        //static Employee Create(out Employee employee)
        static Employee Create(ref Employee? employee)
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

            //Employee employee = new Employee(id: empId, basicPayment: empBasic, daPayment: empDa, hraPayment: empHra, name: empName);
            employee = new Employee(id: empId, basicPayment: empBasic, daPayment: empDa, hraPayment: empHra, name: empName);

            return employee;
        }
    }
}
