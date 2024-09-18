using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class Person
    {
        private int id;
        private string? name;

        public Person()
        {
            
        }

        public Person(int id, string? name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }

        public object this[int index]
        {
            set
            {
                if(index == 0)
                    id=(int)value;
                if(index == 1)
                    name=(string)value;
            }
            get
            {
                if (index == 0)
                    return id;
                else if (index == 1)
                    return name;
                else
                    return "no value";
            }
        }
        public object this[string key]
        {
            set
            {
                if (key == "id")
                    id = (int)value;
                if (key == "name")
                    name = (string)value;
            }
            get
            {
                if (key == "id")
                    return id;
                else if (key == "name")
                    return name;
                else
                    return "no value";
            }
        }
    }
}
