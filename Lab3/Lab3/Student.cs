using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Student
    {
        string name;
        string lastname;
        string DOB;//Day of Birth
        string id;
        public Student(string name,string lastname,string DOB)
        {
            this.name = name;
            this.lastname = lastname;
            this.DOB = DOB;
            createID();
        }

        private void createID()
        {
            // A => First letter of Name + First letter of lastname
            // B => DOB MMYY
            // C => Random number
            Random rnd = new Random();
            string a = this.name.Substring(0,1)+this.lastname.Substring(0,1);
            string b = this.DOB;
            string c = rnd.Next(100, 1000).ToString();
            this.id= a + b + c;
        }

        public string printData()
        {
            string result=$"Name:{this.name}\nLast Name:{this.lastname}\nDOB:{this.DOB}\nID:{this.id}";
            /*string result = "Name:" + this.name + 
                "\nLast Name:"+this.lastname+
                "\nDOB:"+this.DOB+
                "\nID:"+this.id;*/
            return result;
        }

    }
}
