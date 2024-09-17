namespace Class_Object_Demo
{
    class Person
    {
        string name;
        string address;
        string emailId;
        long mobileNo;

        //field initialization
        //static string company="Vxceed";

        static string company;

        //it is to assign values to static data members ONLY
        //never declare this ctor with any access specifier
        //this ctor is NEVER called explicitly while creating the instance, it is called implcitly by runtime (when the very first instance is created)
        //this ctor is called ONLY ONE TIME, no matter how many objects are being created and it is called when the very first instance is created
        //that's why even this constructor can never be parameterized

        static Person()
        {
            company = "vxceed";
            Console.WriteLine(company);
        }

        //default constructor
        public Person() { }

        //parameterized (overloaded) constructor
        public Person(string name, string address, string emailId, long mobileNo)
        {
            this.name = name;
            this.address = address;
            this.emailId = emailId;
            this.mobileNo = mobileNo;
        }

        //property
        public string Name
        {
            //public void Set_Name(string value) { this.name = value; }
            //set accessor
            set { this.name = value; }
            //public string Get_Name() { return this.Name; }
            //get accessor
            get { return this.name; }
        }

        public string Address
        {
            set => this.address = value;
            get => this.address;
        }

        public string EmailId
        {
            set => this.emailId = value;
            get => this.emailId;
        }

        public long MobileNo
        {
            set => this.mobileNo = value;
            get => this.mobileNo;
        }

        //public static string Company
        //{
        //    get => company;
        //}

        //a read-only property can be written in this manner too (expression-body syntax)
        public static string Company => company;


        //public string PrintInfo()
        //{
        //    return name + " " + address + " " + mobileNo + " " + emailId + " " + company;
        //}

        //a read-only method can be written in this manner too (expression-body syntax)
        public string PrintInfo() => name + " " + address + " " + mobileNo + " " + emailId + " " + company;

        //public static string GetCompany()
        //{
        //    return company;
        //}
    }
}
