using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form2 : Form
    {
        //Fields Area
        Random rnd = new Random();
        int[] myArray;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(tbNum.Text);
            myArray = new int[size];
            FillTheArray();
            FillUnsortedList();
            FillSortedList();
            //Random rnd = new Random();
            //int[] myArray = new int[size];

            ////Filled the array
            //for (int i = 0; i < size; i++) 
            //{
            //    myArray[i] = rnd.Next(0,5000);
            //}

            //Add all elements to the unsoreted list
            //foreach (int n in myArray)
            //{
            //    lsbUnsorted.Items.Add(n);
            //}
        }

        private void FillSortedList()
        {
            //Sort and add it to sorted list
            Array.Sort(myArray);
            foreach (int n in myArray)
            {
                lsbSorted.Items.Add(n.ToString());
            }
        }
        private void FillUnsortedList()
        {
            //Add all elements to the unsoreted list
            foreach (int n in myArray)
            {
                lsbUnsorted.Items.Add(n.ToString());
            }
        }
        private void FillTheArray()
        {
            //Filled the array
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rnd.Next(0, 5000);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();//Make Form1 Object
            this.Hide();//Make the this(form1)Hidden
            f1.ShowDialog();//Show the form 1 as Top
            this.Close();//Close this
        }
    }
}
