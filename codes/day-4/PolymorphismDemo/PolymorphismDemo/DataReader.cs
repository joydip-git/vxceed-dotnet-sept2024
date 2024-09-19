using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal abstract class DataReader
    {
        private string? path;
        public DataReader()
        {
            
        }

        public DataReader(string? path)
        {
            this.path = path;
        }

        public string? Path { get => path; set => path = value; }

        //public abstract string? Name { set; get; }
        public abstract string? ReadData();
    }
}
