namespace PolymorphismDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataReader? dbReader = null;
            dbReader = new DataBaseDataReader("");

            DataReader? fileReader = null;
            fileReader = new XmlFileDataReader("");

            Console.WriteLine(dbReader.ReadData());
            Console.WriteLine(fileReader.ReadData());
        }
    }
}
