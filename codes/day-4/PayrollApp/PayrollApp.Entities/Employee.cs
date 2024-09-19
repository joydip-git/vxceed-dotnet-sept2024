namespace PayrollApp.Entities
{
    public class Employee
    {
        #region Data Members
        protected readonly int id;
        protected string? name;
        protected double basicPayment;
        protected double daPayment;
        protected double hraPayment;
        protected double totalSalary;
        public const string COMPANY = "VXCEED";
        #endregion

        #region Constructors
        public Employee()
        {
            Console.WriteLine("employee default ctor");
        }

        public Employee(int id, string? name, double basicPayment, double daPayment, double hraPayment)
        {
            this.id = id;
            this.name = name;
            this.basicPayment = basicPayment;
            this.daPayment = daPayment;
            this.hraPayment = hraPayment;
            Console.WriteLine("employee param ctor");
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

        public double TotalSalary
        {
            get => totalSalary;
            protected set => totalSalary = value;
        }
        #endregion

        #region Methods
        public virtual void CalculateSalary()
        {
            //const int x = 100;
            totalSalary = basicPayment + daPayment + hraPayment;
        }
        #endregion
    }
}
