namespace OutstandingPersonApp.Entities
{
    public abstract class Person
    {
        //automatic-property initializer
        public string? Name { get; set; } = null;
        public Person() { }

        public Person(string? name)
        {
            Name = name;
        }
        public abstract bool IsOutstanding();
        public override string ToString()
        {
            return $"Name:{Name} is a {this.GetType().Name} ";
        }
    }
}
