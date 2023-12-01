using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grader
{
    public class Student
    {
        public static ArrayList idArr = new ArrayList();//全局变量arraylist来保证输出多个值//The global variable ArrayList is used to ensure that multiple values are output
        public static ArrayList nameArr = new ArrayList();
        public static ArrayList lastnameArr = new ArrayList();
        //public static ArrayList StudentArr=new ArrayList(); 

        //public static string name;//will be only one value output
        //public static string lastname;
        //public static string id;


        //public static string giveMeInfo()//lab2,会导致只有一个值,所以移动至form3再组合//It will result in only one value, so i move to form3 and combine
        //{
        //    string result = "";
        //    result = $"\n{id}:\n{name}\n{lastname}";
        //    return result;
        //    Student.StudentArr.Add(giveMeInfo());
        //}
    }
}
