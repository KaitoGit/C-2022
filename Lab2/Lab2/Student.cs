using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Student
    {
        public string name;
        public string lastname;
        public string id;
        public int grade;

        public string giveMeInfo()
        {
            string result = "";
            result = $"Name:{name}\nLast Name:{lastname}\nID:{id}\nGrade:{grade}";
            return result;
        }
    }
}
