using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Grader
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            //this.listData1 = new ArrayList();
            //Student s = new Student();//这种方法而不是array会导致form3只有一个值//This approach instead of array will cause form3 to have only one value
            //s.name = tbName.Text;
            //s.lastname = tbLastName.Text;
            //s.id = tbID.Text;
        }

        private void btExit2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(); // Make Form1 Obj
            this.Hide(); // Make the this (form2) Hidden
            f1.ShowDialog(); // Show the form 1 as Top
            this.Close(); // Close this (form2)
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }
        private void btAddStudent3_Click(object sender, EventArgs e)
        {
            if (tbID.Text.Length != 5)//判断长度//Judgment length
                MessageBox.Show("The ID is ONLY 5 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tbName.Text.Length < 1)//剩下几项不空就行//not empty is ok
                MessageBox.Show("Please enter the first name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tbLastName.Text.Length < 1)
                MessageBox.Show("Please enter the Last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tbEmail.Text.Length < 1)
                MessageBox.Show("Please enter the Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tbDateofBirth.Text.Length < 1)//可以用date来改,但是没必要//You can use the date to change it, but it is not necessary
                MessageBox.Show("Please enter the Date of Birth", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tbDateofStart.Text.Length < 1)
                MessageBox.Show("Please enter the Date of Start", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                MessageBox.Show("Student Added");
                Student.idArr.Add(tbID.Text);//使用数组来将textbox所获得的值导入Students这个全局变量以实现共享//Use an array to import the value obtained by the textbox into the global variable Students for sharing
                Student.nameArr.Add(tbName.Text);
                Student.lastnameArr.Add(tbLastName.Text);
                //Student.nameArr = tbName.Text;//如果只是全局变量会导致只有一个值,这3行//If just the global variable will result in only one value, these 3 lines
                //Student.lastnameArr = tbLastName.Text;
                //Student.idArr = tbID.Text;
                //Save the student to the file 
                //Form3 Form3=new Form3(this);
                //myArrayList.Add(s.giveMeInfo());//try
                //this.Hide(); // Make the this (form2) Hidden
                //f3.String1 = s.giveMeInfo();//S学生信息
                //f3.ShowDialog();//不要显示,仅测试使用,易于直接出form3//Don't show, just when test i can easy to directly output form3
                //MessageBox.Show("Student Added");
                tbID.Clear();
                tbName.Clear();
                tbLastName.Clear();
                tbEmail.Clear();
                tbDateofBirth.Clear();
                tbDateofStart.Clear();
                //tbID.Text = tbName.Text = tbLastName.Text = tbEmail.Text = tbDateofBirth.Text = tbDateofStart.Text = "";
            }
     
        }
    }
}
