using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //throw new InvalidCastException();
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = a * a;
                //int[] temp = new int[2];
                //temp[100] = a;
                MessageBox.Show($"The result is {b}");


            }
            catch (Exception ex)
            {
                textBox1.BackColor = Color.Red;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                textBox1.Clear();
                //MessageBox.Show("Process has been finished");
            }
        }
    }
}
