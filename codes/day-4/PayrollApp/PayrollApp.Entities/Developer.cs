namespace PayrollApp.Entities
{
    public class Developer : Employee
    {
        private double incentivePayment;

        public Developer()
        {
            Console.WriteLine("developer default ctor");
        }

        public Developer(int id, string? name, double basicPayment, double daPayment, double hraPayment, double incentivePayment)
            : base(id, name, basicPayment, daPayment, hraPayment)
        {
            this.incentivePayment = incentivePayment;
            Console.WriteLine("developer param ctor");
        }

        public double IncentivePayment { get => incentivePayment; set => incentivePayment = value; }

        public override void CalculateSalary()
        {
            base.CalculateSalary();
            this.TotalSalary += this.incentivePayment;
        }
    }
}
