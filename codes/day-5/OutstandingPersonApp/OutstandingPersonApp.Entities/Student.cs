namespace OutstandingPersonApp.Entities
{
    public class Student : Person
    {
        public double Marks { get; set; }
        public Student() { }
        public Student(string? name, double marks) : base(name)
        {
            Marks = marks;
        }
        public override bool IsOutstanding()
        {
            return Marks > 85;
        }
        public override string ToString()
        {
            return $"{base.ToString()} Marks:{Marks}";
        }
    }
}
