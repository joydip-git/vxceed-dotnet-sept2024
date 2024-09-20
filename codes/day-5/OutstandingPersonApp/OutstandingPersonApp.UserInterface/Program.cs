using OutstandingPersonApp.Entities;

namespace OutstandingPersonApp.UserInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = GetArrayLength();
            Person?[] people = new Person[count];
            for (int i = 0; i < count; i++)
            {
                PrintMenu();
                int choice = GetChoice();
                Person? person = CreatePerson(choice);
                people[i] = person;
            }

            foreach (Person? person in people)
            {
                if (person != null)
                {
                    if (person.IsOutstanding())
                    {
                        //Console.WriteLine(person.ToString());
                        Console.WriteLine(person);
                    }
                }
            }

        }
        static void PrintMenu()
        {
            Console.WriteLine("---Menu---");
            Console.WriteLine("1. Professor\n2. Student");
        }
        static int GetChoice()
        {
            Console.Write("\nEnter choice[1/2]: ");
            return int.Parse(Console.ReadLine() ?? "1");
        }
        static int GetArrayLength()
        {
            Console.Write("\nHow many records? ");
            return int.Parse(Console.ReadLine() ?? "1");
        }
        static Person? CreatePerson(int choice)
        {
            Person? person;
            Console.Write("\nName: ");
            string? name = Console.ReadLine();
            switch (choice)
            {
                case 1:
                    Console.Write("Books: ");
                    int books = int.Parse(Console.ReadLine() ?? "0");
                    person = new Professor(name, books);
                    break;

                case 2:
                    Console.Write("Marks: ");
                    double marks = double.Parse(Console.ReadLine() ?? "0");
                    person = new Student(name, marks);
                    break;

                default:
                    person = null;
                    break;
            };
            return person;
        }
    }
}
