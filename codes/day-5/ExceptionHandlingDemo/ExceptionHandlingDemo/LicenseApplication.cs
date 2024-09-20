namespace ExceptionHandlingDemo
{
    internal class LicenseApplication
    {
        public string? Name { get; set; } = null;
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    InvalidAgeException e = new("age must be greater than or equal to 18");
                    throw e;
                }
                else
                    age = value;
            }
        }
    }
}
