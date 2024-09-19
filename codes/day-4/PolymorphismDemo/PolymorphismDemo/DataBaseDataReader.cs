namespace PolymorphismDemo
{
    internal class DataBaseDataReader : DataReader
    {
        public DataBaseDataReader()
        {

        }
        public DataBaseDataReader(string? path) : base(path)
        {

        }
        public override string? ReadData()
        {
            return "database data";
        }
    }
}
