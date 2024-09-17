namespace PayrollApp.Entities
{
    public class Employee
    {
        private int id;
        private string name;
        private double basicPayment;
        private double daPayment;
        private double hraPayment;
        private double totalSalary;

        public Employee() { }

        public Employee(int id, string name, double basicPayment, double daPayment, double hraPayment)
        {
            this.id = id;
            this.name = name;
            this.basicPayment = basicPayment;
            this.daPayment = daPayment;
            this.hraPayment = hraPayment;
        }

        public int Id { get => id; set => id = value; }

        public string Name
        { get => name; set => name = value; }

        public double BasicPayment
        { get => basicPayment; set => basicPayment = value; }

        public double DaPayment
        { get => daPayment; set => daPayment = value; }

        public double HraPayment
        { get => hraPayment; set => hraPayment = value; }

        public double TotalSalary { get => totalSalary; }

        public void CalculateSalary()
        {
            totalSalary = basicPayment + daPayment + hraPayment;
        }
    }
}
