using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnsee_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(); // Make Form3 Obj
            this.Hide(); // Make the this (form1) Hidden
            f3.ShowDialog(); // Show the form 3 as Top
            this.Close(); // Close this (form1)
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); // Make Form2 Obj
            this.Hide(); // Make the this (form1) Hidden
            f2.ShowDialog(); // Show the form 2 as Top
            this.Close(); // Close this (form1)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(); // Make Form3 Obj
            this.Hide(); // Make the this (form1) Hidden
            f3.ShowDialog(); // Show the form 3 as Top
            this.Close(); // Close this (form1)
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void sidebarContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
