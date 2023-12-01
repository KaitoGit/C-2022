using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sid = tSid.Text;
            int age = Convert.ToInt32(tage.Text);
            Student student = new Student(sid,age);
            student.Name = tname.Text;
            student.Lastname = tlastname.Text;
            student.Dob = tdob.Text;
            student.Age = Convert.ToInt32(tage.Text);
            MessageBox.Show(student.printStudentInfo());
        }
    }
}
