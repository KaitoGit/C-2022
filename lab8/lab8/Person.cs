using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Person
    {
        string name, lastname, dob;
        int age;
        public Person() { }//要想在子表用:必须加这个
        public Person(string name, string lastname, string dob, int age)
        {
            this.name = name;
            this.lastname = lastname;
            this.dob = dob;
            this.age = age;

        }

        public string printInfo()
        {
            string result = "Name:"+name;
            result += "\nLast Name:" + lastname;
            result += "\nDate of Birth::" + dob;
            result += "\nAge:" + age.ToString();
            return result;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }

        }
    }
}
