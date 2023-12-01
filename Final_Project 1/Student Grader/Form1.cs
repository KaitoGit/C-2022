using System;
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
    
    public partial class Form1 : Form//没什么好说的非常简单//easy form
    {
        //example: “12345_Orange Team_Project 1.rar” sent to platon
        public Form1()
        {
            InitializeComponent();
        }

        private void btAddStudent_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); // Make Form2 Obj
            this.Hide(); // Make the this (form1) Hidden
            f2.ShowDialog(); // Show the form 2 as Top
            this.Close(); // Close this (form1)
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btGrade_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(); // Make Form3 Obj
            this.Hide(); // Make the this (form1) Hidden
            f3.ShowDialog(); // Show the form 3 as Top
            this.Close(); // Close this (form1)
            //form1加上了我们小组的名称//Form1 added the name of our group

        }
    }
}
