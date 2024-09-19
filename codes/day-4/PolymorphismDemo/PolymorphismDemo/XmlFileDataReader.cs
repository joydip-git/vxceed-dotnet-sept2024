namespace PolymorphismDemo
{
    internal class XmlFileDataReader : DataReader
    {
        public XmlFileDataReader()
        {

        }
        public XmlFileDataReader(string? path) : base(path)
        {

        }
        public override string? ReadData()
        {
            return "XML file data";
        }
    }
}
