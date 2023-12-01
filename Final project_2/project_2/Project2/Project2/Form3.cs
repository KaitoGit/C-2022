using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        ///////////////////////////////////////////////////////
                           ///All of these classes are created to be able to store a value in a listbox item
        public class AllTv
        {
            public string Display { get; set; }
            public string[] Value { get; set; }

            public override string ToString()
            {
                return Display;
            }
        }

        public class AllFridge
        {
            public string Display { get; set; }     
            public string[] Value { get; set; }

            public override string ToString()
            {
                return Display;
            }
        }
       
        public class AllStove
        {
            public string Display { get; set; }//assigning values via get set
            public string[] Value { get; set; }

            public override string ToString()
            {
                return Display;
            }
        }
        ///////////////////////////////////////////////////////
        private void Show_Click(object sender, EventArgs e)//showing which items do we have
        {

            listBoxProducts.Items.Clear();
            if (cb1.Text == "TV")
            {
                foreach (string[] tv in tv_list)//looping thorugh that items and then we are assigning values so we can display them
                {
                    listBoxProducts.Items.Add(new AllTv { Display = $"{tv[0]}: {tv[1]}", Value = tv});
                }
            }
            else if (cb1.Text == "Stove")
            {
                foreach (string[] stove in stove_list)
                {
                    listBoxProducts.Items.Add(new AllStove { Display = $"{stove[0]}: {stove[1]}", Value = stove });
                }
            }
            else if (cb1.Text == "Fridge")
            {
                foreach (string[] fridge in fridge_list)
                {
                    listBoxProducts.Items.Add(new AllFridge { Display = $"{fridge[0]}: {fridge[1]}", Value = fridge });
                }
            }
            else
            {
                MessageBox.Show("you need to choose one");
                cb1.BackColor = Color.Red;
            }
        }

        List<string[]> tv_list = new List<string[]>();
        List<string[]> fridge_list = new List<string[]>();
        List<string[]> stove_list = new List<string[]>();

        private void Form3_Load(object sender, EventArgs e)
        {
            string greet = "hello_mother";
            if (greet.Contains("_")) {
                Console.WriteLine(greet.Replace("_", "-"));
            }
            gbinformation.Visible = false;
            try
            {
                FileStream fs = new FileStream("Data.txt", FileMode.Open, FileAccess.Read);//rietrieving data from text file
                StreamReader sr = new StreamReader(fs);

                while (! sr.EndOfStream)//loop until last value
                {
                    string[] data = sr.ReadLine().Split('_');
                    if (data[data.Length - 1] == "TV")//checking which user chosen and showing those
                    {
                        tv_list.Add(data);
                    }
                    else if (data[data.Length - 1] == "Stove")
                    {
                        stove_list.Add(data);
                    }
                    else if (data[data.Length - 1] == "Fridge")
                    {
                        fridge_list.Add(data);
                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btninformation_Click(object sender, EventArgs e)
        {
            gbinformation.Visible = true;
            /////// After here your eyes will start bleeding
            try
            {//theese are further values of specific items we are assigning values to ui 
                if (cb1.Text == "TV")
                {
                    lbid.Text = $"ID: {((AllTv)listBoxProducts.SelectedItem).Value[2]}";
                    lbbrand.Text = $"Brand: {((AllTv)listBoxProducts.SelectedItem).Value[0]}";
                    lbmodel.Text = $"Model: {((AllTv)listBoxProducts.SelectedItem).Value[1]}";
                    lbprice.Text = $"Price: {((AllTv)listBoxProducts.SelectedItem).Value[6]}";
                    extra1.Text = $"Size: {((AllTv)listBoxProducts.SelectedItem).Value[3]}";
                    extra2.Text = $"Respond Time: {((AllTv)listBoxProducts.SelectedItem).Value[5]}";
                    extra3.Text = $"Smart: {((AllTv)listBoxProducts.SelectedItem).Value[4]}";
                }
                else if (cb1.Text == "Stove")
                {
                    lbid.Text = $"ID: {((AllStove)listBoxProducts.SelectedItem).Value[2]}";
                    lbbrand.Text = $"Brand: {((AllStove)listBoxProducts.SelectedItem).Value[0]}";
                    lbmodel.Text = $"Model: {((AllStove)listBoxProducts.SelectedItem).Value[1]}";
                    lbprice.Text = $"Price: {((AllStove)listBoxProducts.SelectedItem).Value[6]}";
                    extra1.Text = $"N of Heaters: {((AllStove)listBoxProducts.SelectedItem).Value[3]}";
                    extra2.Text = $"Oven: {((AllStove)listBoxProducts.SelectedItem).Value[5]}";
                    extra3.Text = $"Gas: {((AllStove)listBoxProducts.SelectedItem).Value[4]}";
                    
                }
                else if (cb1.Text == "Fridge")
                {
                    lbid.Text = $"ID: {((AllFridge)listBoxProducts.SelectedItem).Value[2]}";
                    lbbrand.Text = $"Brand: {((AllFridge)listBoxProducts.SelectedItem).Value[0]}";
                    lbmodel.Text = $"Model: {((AllFridge)listBoxProducts.SelectedItem).Value[1]}";
                    lbprice.Text = $"Price: {((AllFridge)listBoxProducts.SelectedItem).Value[6]}";
                    extra1.Text = $"Capacity: {((AllFridge)listBoxProducts.SelectedItem).Value[3]}";
                    extra2.Text = $"Electricity: {((AllFridge)listBoxProducts.SelectedItem).Value[4]}";
                    extra3.Text = $"Noise: {((AllFridge)listBoxProducts.SelectedItem).Value[5]}";
                }
                else
                {
                    MessageBox.Show("you need to choose one");
                    cb1.BackColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnback2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(); 
            this.Hide(); 
            f1.ShowDialog(); 
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); // Make Form2 Obj
            this.Hide(); // Make the this (form1) Hidden
            f2.ShowDialog(); // Show the form 2 as Top
            this.Close(); // Close this (form1)
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}
