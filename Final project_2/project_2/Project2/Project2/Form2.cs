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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.groupBox2.Enabled = false;
            this.groupBox2.Visible = false;
            this.groupBox3.Enabled = false;
            this.groupBox3.Visible = false;
            this.groupBox4.Enabled = false;
            this.groupBox4.Visible = false;
            //here we are making all of the special information section disabled so without user selecting what will he choose we won't be able to use that site
        }

        public void clearAllField() //  Function to clear parent class Fields.
        {
            cbtype.Text = String.Empty;
            tbid.Text = String.Empty;
            tbmodel.Text = String.Empty;
            tbbrand.Text = String.Empty;
            tbprice.Text = String.Empty;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(); // Make Form1 Obj
            this.Hide(); // Make the this (form2) Hidden
            f1.ShowDialog(); // Show the form 1 as Top
            this.Close(); // Close this (form2)
        }

        private void btnproceed_Click(object sender, EventArgs e)
        {
           

            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr is TextBox && ctr.Text=="")
                {
                    

                        MessageBox.Show("Plese don't try to add empty value", "Empty Bar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    
                };
            };
            try//finding errors if no error procced to further
            {                
                if (cbtype.Text == "TV")//here we are choosing which of the type did user chosen then we will eneble ares for that
                {
                    this.groupBox2.Visible = true;
                    this.groupBox2.Location = new Point(400, 300);
                    this.groupBox2.Enabled = true;
                    this.groupBox1.Enabled = false;
                }
                else if (cbtype.Text == "Fridge")
                {
                    this.groupBox3.Visible = true;
                    this.groupBox3.Location = new Point(400, 300);
                    this.groupBox3.Enabled = true;
                    this.groupBox1.Enabled = false;
                }
                else if (cbtype.Text == "Stove")
                {
                    this.groupBox4.Visible = true;
                    this.groupBox4.Location = new Point(400, 300);
                    this.groupBox4.Enabled = true;
                    this.groupBox1.Enabled = false;
                }
                else
                {//if user haven't chosen one
                    MessageBox.Show("you need to choose one");
                    cbtype.BackColor = Color.Red;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
      

            private void btnaddtv_Click(object sender, EventArgs e)
        {
           
            groupBox1.Enabled = true;
            foreach (Control ctr in groupBox2.Controls)
            {
                if (ctr is TextBox && ctr.Text == "")
                {


                    MessageBox.Show("Plese don't try to add empty value", "Empty Bar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                };
            };
            try
            {
                FileStream fs = new FileStream("Data.txt", FileMode.Append, FileAccess.Write);//rietrieving data from .txt
                StreamWriter sw = new StreamWriter(fs);
                ////////////////////////////{size}_{smart}_{respond_time}
                TV tv = new TV(tbsize.Text, Int32.Parse(tbtime.Text ), cbsmart.Checked  );
                tv.Type = cbtype.Text;
                tv.Id = tbid.Text;
                tv.Model = tbmodel.Text;
                tv.Brand = tbbrand.Text;
                tv.Price = tbprice.Text;
                /////////////////////////////object and addding data to it which the user wrote

                sw.WriteLine(tv.printTvInfo());
                sw.Close();// adding data to .txt file
                fs.Close();

                /////////////////////////////////////////////////
                clearAllField();
                tbsize.Text = String.Empty;    ////// <- Cleans the Fields
                tbtime.Text = String.Empty;
                cbsmart.CheckState = CheckState.Unchecked;
                this.groupBox2.Visible = false;
                /////////////////////////////////////////////////
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("New TV added to the products");
        }

        private void btnaddfridge_Click(object sender, EventArgs e)//same thing with previous code but if user wanted to add fridge
        {
            foreach (Control ctr in groupBox3.Controls)
            {
                if (ctr is TextBox && ctr.Text == "")
                {


                    MessageBox.Show("Plese don't try to add empty value", "Empty Bar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                };
            };
            groupBox1.Enabled = true;
            

            try
            {

                FileStream fs = new FileStream("Data.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                ////////////////////////////{capacity}_{electricity}_{noise}
                Fridge fridge = new Fridge(tbcapacity.Text, tbelectricity.Text, tbnoise.Text);
                fridge.Type = cbtype.Text;
                fridge.Id = tbid.Text;
                fridge.Model = tbmodel.Text;
                fridge.Brand = tbbrand.Text;
                fridge.Price = tbprice.Text;
                /////////////////////////////

                sw.WriteLine(fridge.printFridgeInfo());
                sw.Close();//
                fs.Close();

                /////////////////////////////////////////////////
                clearAllField();
                tbcapacity.Text = String.Empty;
                tbelectricity.Text = String.Empty; //// <- Cleans the Fields
                tbnoise.Text = String.Empty;
                groupBox3.Visible = false;
                /////////////////////////////////////////////////
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("New Fridge added to the products");
        }

        private void btnaddstove_Click(object sender, EventArgs e)//for stove
        {
            groupBox1.Enabled = true;
            foreach (Control ctr in groupBox4.Controls)
            {
                if (ctr is TextBox && ctr.Text == "")
                {


                    MessageBox.Show("Plese don't try to add empty value", "Empty Bar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                };
            };

            try
            {
                FileStream fs = new FileStream("Data.txt", FileMode.Append, FileAccess.Write);//the rest are same too
                StreamWriter sw = new StreamWriter(fs);
                ////////////////////////////{number}_{oven}_{gas}
                Stove stove = new Stove(tbheaters.Text,  cbgas.Checked, cboven.Checked);
                stove.Type = cbtype.Text;
                stove.Id = tbid.Text;
                stove.Model = tbmodel.Text;
                stove.Brand = tbbrand.Text;
                stove.Price = tbprice.Text;
                /////////////////////////////

                sw.WriteLine(stove.printStoveInfo());
                sw.Close();//
                fs.Close();

                /////////////////////////////////////////////////
                clearAllField();
                tbheaters.Text = String.Empty;
                                            //// <- Cleans the Fields
                cbgas.CheckState = CheckState.Unchecked;
                cboven.CheckState = CheckState.Unchecked;
                groupBox4.Visible = false;
                /////////////////////////////////////////////////
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("New Stove added to the products");
        }
        private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(); // Make Form3 Obj
            this.Hide(); // Make the this (form1) Hidden
            f3.ShowDialog(); // Show the form 3 as Top
            this.Close(); // Close this (form1)
        }
    }
}
