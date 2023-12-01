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
    public partial class Form3 : Form
    {
        //public string stationID = "";
        //ArrayList myArrayList = new ArrayList();//创建一个list

        
        public Form3()//2022/5/8 解决了最大的问题//the heart question
        {
            InitializeComponent();//窗口初始化,必须在最上面//Window initialization, must be at the top
            string result = "";//最开始我把这段放在student.cs,导致只能显示一个值,所以我用array替换它//At first, I put this paragraph in student CS, so that only one value can be displayed, so I replace it with array
            result = $"\n{Student.idArr}:\n{Student.nameArr}\n{Student.lastnameArr}";
            string str;
            int count = Student.idArr.Count;
            for (int i = 0; i < count; i++)//用来将处理后的值加入listbox//Used to add the processed value to listbox
            {
                str = $"\n{(string)Student.idArr[i]}:\n{(string)Student.nameArr[i]}\n{(string)Student.lastnameArr[i]}";
                listBox1.Items.Add(str);
            }
            
            

        }

        private void btBackToMenu_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(); // Make Form1 Obj
            this.Hide(); // Make the this (form2) Hidden
            f1.ShowDialog(); // Show the form 1 as Top
            this.Close(); // Close this (form2)
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
            tb3.Clear();
            tb4.Clear();
            tb5.Clear();
            tb6.Clear();
            //tb1.Text = tb2.Text = tb3.Text = tb4.Text = tb5.Text = tb6.Text = "";
        }

        private void btGrade2_Click(object sender, EventArgs e)
        {

            /*int number1 = 1;//因为int放在else里了,所以不需要赋值了//Because int is placed in else, there is no need to assign value
            int number2 = 1;
            int number3 = 1;
            int number4 = 1;
            int number5 = 1;
            int number6 = 1;*/
            if (tb1.Text == "")//先判断是否为空,目的是防止"int"报错//First judge whether it is empty to prevent "int" from reporting errors
            {
                MessageBox.Show("Attendance should be between 0 to 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb2.Text == "")
            {
                MessageBox.Show("Project 1 should be between 0 to 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb3.Text == "")
            {
                MessageBox.Show("Project 2 should be between 0 to 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb4.Text == "")
            {
                MessageBox.Show("Project 3 should be between 0 to 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb5.Text == "")
            {
                MessageBox.Show("Project 4 should be between 0 to 40", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb6.Text == "")
            {
                MessageBox.Show("Final Exam should be between 0 to 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else//不是空值则判断//2nd, if it is not empty
            {
                int number1 = Convert.ToInt32(tb1.Text);//这时再输入值防止空值//then int n Prevent null values
                int number2 = Convert.ToInt32(tb2.Text);
                int number3 = Convert.ToInt32(tb3.Text);
                int number4 = Convert.ToInt32(tb4.Text);
                int number5 = Convert.ToInt32(tb5.Text);
                int number6 = Convert.ToInt32(tb6.Text);
                if (number1 < 0 || number1 > 20)//很简单//easy
                MessageBox.Show("Attendance should be between 0 to 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (number2 < 0 || number2 > 20)
                    MessageBox.Show("Project 1 should be between 0 to 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (number3 < 0 || number3 > 20)
                    MessageBox.Show("Project 2 should be between 0 to 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (number4 < 0 || number4 > 20)
                    MessageBox.Show("Project 3 should be between 0 to 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (number5 < 0 || number5 > 40)
                    MessageBox.Show("Project 4 should be between 0 to 40", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (number6 < 0 || number6 > 100)
                    MessageBox.Show("Final Exam should be between 0 to 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else //接下来//then 3rd
                {
                    int c = Convert.ToInt32(number1 * 0.5 + number2 * 0.5 + number3 * 0.5 + number4 * 0.5 + number5 * 0.5 + number6 * 0.4);
                    lbna2.Text = $"\n{c}/100";//(百分制)我不知道为什么总会向下移动,这两天我会弄清,可能是字体?//(percentile system) I don't know why it always moves down. I'll find out in these days. Maybe it's the font?
                    if (c == 0)//5分制和颜色//5 and color
                    {
                        lbna1.Text = "NKL";
                        lbna3.Text = " FAIL";
                        this.lbna3.ForeColor = Color.Red;
                    }
                    if (c > 0 && c < 49)//注意连续性//Pay attention to continuity
                    {
                        lbna1.Text = "2";
                        lbna3.Text = "FAIL";
                        this.lbna3.ForeColor = Color.Red;
                    }
                    if (c > 49 && c < 59)
                    {
                        lbna1.Text = "2.5";
                        lbna3.Text = "FAIL";
                        this.lbna3.ForeColor = Color.Red;
                    }
                    if (c > 59 && c < 69)
                    {
                        lbna1.Text = "3";
                        lbna3.Text = "PASS";
                        this.lbna3.ForeColor = Color.Green;
                    }
                    if (c > 69 && c < 79)
                    {
                        lbna1.Text = "4";
                        lbna3.Text = "PASS";
                        this.lbna3.ForeColor = Color.Green;
                    }
                    if (c > 79 && c < 89)
                    {
                        lbna1.Text = "4.5";
                        lbna3.Text = "PASS";
                        this.lbna3.ForeColor = Color.Green;
                    }
                    if (c > 89 && c < 101)
                    {
                        lbna1.Text = "5";
                        lbna3.Text = "PASS";
                        this.lbna3.ForeColor = Color.Green;
                    }
                    tb1.Clear();//成功了才清除,易于修改错误,视频中也是这样
                    tb2.Clear();//It can be cleared only after success, which is easy to modify the error, and the same is true in the video
                    tb3.Clear();//如果想做到点击就clear,移动到外部
                    tb4.Clear();//if u want to clear after click,plz move to outside but in this buttun
                    tb5.Clear();
                    tb6.Clear();
                }
            }
        }
        private void tb1_TextChanged(object sender, EventArgs e)
        {
            

        }
        


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1 != null )
            {
                tb1.Enabled = true;//一开始我把按钮都设置为关闭,以实现不空则开
                tb2.Enabled = true;//At first, I set the buttons to off to enable on when not empty
                tb3.Enabled = true;
                tb4.Enabled = true;
                tb5.Enabled = true;
                tb6.Enabled = true;
            }
            else
            {
                tb1.Enabled = false;
                tb2.Enabled = false;
                tb3.Enabled = false;
                tb4.Enabled = false;
                tb5.Enabled = false;
                tb6.Enabled = false;
            }
            
        }
    }
}
