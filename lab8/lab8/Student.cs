using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Student:Person
    {
        string sId;
        int grade;
        public Student(string sId,int grade)
        {
            this.sId = sId;
            this.grade = grade;
        }

        public string SId
        {
            get { return sId; }
            set
            {
                if(value.Length==5)
                {
                    sId = value;
                }
                else
                {
                    sId = value.Substring(0, 5);
                }
            }
        }

        public string printStudentInfo()
        {
            string result = this.printInfo();
            result += "\nStudent id:" + sId;
            result += "\nGrade:" + grade;
            return result;
        }

        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }
    }
}
