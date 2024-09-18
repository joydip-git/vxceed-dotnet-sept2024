namespace PayrollApp.Entities
{
    public class Employee
    {
        #region Data Members
        private readonly int id;
        private string? name;        
        private double basicPayment;
        private double daPayment;
        private double hraPayment;
        private double totalSalary;
        public const string COMPANY = "VXCEED";
        #endregion

        #region Constructors
        public Employee() { }

        public Employee(int id, string? name, double basicPayment, double daPayment, double hraPayment)
        {
            this.id = id;
            this.name = name;
            this.basicPayment = basicPayment;
            this.daPayment = daPayment;
            this.hraPayment = hraPayment;
        }
        #endregion

        #region Properties
        public int Id { get => id; }

        public string? Name
        { get => name; set => name = value; }

        public double BasicPayment
        { get => basicPayment; set => basicPayment = value; }

        public double DaPayment
        { get => daPayment; set => daPayment = value; }

        public double HraPayment
        { get => hraPayment; set => hraPayment = value; }

        public double TotalSalary { get => totalSalary; }
        #endregion

        #region Methods
        public void CalculateSalary()
        {
            //const int x = 100;
            totalSalary = basicPayment + daPayment + hraPayment;
        }
        #endregion
    }
}
