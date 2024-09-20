namespace OutstandingPersonApp.Entities
{
    public class Professor : Person
    {
        public int BooksPublished { get; set; }
        public Professor() { }

        public Professor(string? name, int booksPublished) : base(name)
        {
            BooksPublished = booksPublished;
        }

        public override bool IsOutstanding()
        {
            return BooksPublished > 5 ? true : false;
        }
        public override string ToString()
        {
            return $"{base.ToString()} Books:{BooksPublished}";
        }
    }
}
