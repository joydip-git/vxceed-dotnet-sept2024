namespace ProductManagementApp
{
    internal class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Name={Name}, Id={Id}, Price={Price}, Description={Description}";
        }
    }
}
