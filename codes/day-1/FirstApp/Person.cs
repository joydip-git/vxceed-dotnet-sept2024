using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Person
    {
        string name;
        long mobileNo;
        string address;
        string emailId;

        public Person() { }

        public Person(string name, long mobileNo, string address, string emailId)
        {
            this.name = name;
            this.mobileNo = mobileNo;
            this.address = address;
            this.emailId = emailId;
        }
    }
}
