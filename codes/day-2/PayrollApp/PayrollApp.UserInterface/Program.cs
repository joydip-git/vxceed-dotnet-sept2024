using PayrollApp.Entities;

namespace PayrollApp.UserInterface
{
    internal class Program
    {
        static void Main()
        {
            Employee employee = Create();
            employee.CalculateSalary();
            Console.WriteLine(employee.Name + " with " + employee.Id + "got " + employee.TotalSalary + " as total salary");
        }

        //method to create an employee instance with values from user
        static Employee Create()
        {
            Employee employee = new Employee();

            Console.Write("name: ");
            employee.Name = Console.ReadLine();

            Console.Write("id: ");
            employee.Id = int.Parse(Console.ReadLine());

            Console.Write("basic payment: ");
            employee.BasicPayment = double.Parse(Console.ReadLine());

            Console.Write("da payment: ");
            employee.DaPayment = double.Parse(Console.ReadLine());

            Console.Write("hra payment: ");
            employee.HraPayment = double.Parse(Console.ReadLine());

            return employee;
        }
    }
}
