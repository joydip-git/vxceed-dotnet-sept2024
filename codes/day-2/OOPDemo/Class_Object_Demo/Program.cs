using Entities;
using Entities.DataAccess;

namespace Class_Object_Demo
{
    class Program
    {
        //static void Main(string[] args)
        //static void Main()
        //static int Main(string[] args){return 0;}
        //static int Main(){return 0;}

        static void Main()
        {
            SqlDataAccess sqlDataAccess = new SqlDataAccess();

           Person anilPerson = new Person("anil", "Bangalore", "anil@gmail.com", 9090909090);
            //anilPerson.name = "";
            //anilPerson.address = "";
            anilPerson.Name = "anil kumar";
            string anilInfo = anilPerson.PrintInfo();
            Console.WriteLine(anilInfo);

            Person sunilPerson = new Person("sunil", "Chennai", "sunil@gmail.com", 9090909091);
            sunilPerson.MobileNo = 9090909092;
            string sunilInfo = sunilPerson.PrintInfo();
            Console.WriteLine(sunilInfo);

            //Console.WriteLine("all people works for: " + Person.GetCompany());
            Console.WriteLine("all people works for: " + Person.Company);

            Console.ReadLine();
        }
    }
}
