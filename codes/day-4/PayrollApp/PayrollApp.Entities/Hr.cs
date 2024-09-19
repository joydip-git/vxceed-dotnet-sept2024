namespace PayrollApp.Entities
{
    public class Hr : Employee
    {
        private double gratuityPayment;
        public Hr()
        {

        }

        public Hr(int id, string? name, double basicPayment, double daPayment, double hraPayment, double gratuityPayment) : base(id, name, basicPayment, daPayment, hraPayment)
        {
            this.gratuityPayment = gratuityPayment;
        }

        public double GratuityPayment { get => gratuityPayment; set => gratuityPayment = value; }

        public override void CalculateSalary()
        {
            base.CalculateSalary();
            this.TotalSalary += this.gratuityPayment;
        }
    }
}
