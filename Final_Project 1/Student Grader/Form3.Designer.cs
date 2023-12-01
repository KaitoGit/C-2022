namespace Student_Grader
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btGrade2 = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.btBackToMenu = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbna4 = new System.Windows.Forms.Label();
            this.lbna3 = new System.Windows.Forms.Label();
            this.lbna2 = new System.Windows.Forms.Label();
            this.lbna1 = new System.Windows.Forms.Label();
            this.warn1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(37, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(438, 502);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student List";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(37, 58);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(360, 400);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btGrade2);
            this.groupBox2.Controls.Add(this.btReset);
            this.groupBox2.Controls.Add(this.tb6);
            this.groupBox2.Controls.Add(this.tb5);
            this.groupBox2.Controls.Add(this.tb4);
            this.groupBox2.Controls.Add(this.tb3);
            this.groupBox2.Controls.Add(this.tb2);
            this.groupBox2.Controls.Add(this.tb1);
            this.groupBox2.Location = new System.Drawing.Point(520, 145);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(484, 502);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grades";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(309, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Final Exam (out of 100)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Project 4 (out of 40)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Project 3 (out of 20)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Project 2 (out of 20)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Project 1 (out of 20)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Atendance(out of 20)";
            // 
            // btGrade2
            // 
            this.btGrade2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btGrade2.Font = new System.Drawing.Font("SimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGrade2.Location = new System.Drawing.Point(24, 415);
            this.btGrade2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGrade2.Name = "btGrade2";
            this.btGrade2.Size = new System.Drawing.Size(163, 66);
            this.btGrade2.TabIndex = 7;
            this.btGrade2.Text = "Grade";
            this.btGrade2.UseVisualStyleBackColor = false;
            this.btGrade2.Click += new System.EventHandler(this.btGrade2_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btReset.Font = new System.Drawing.Font("SimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(298, 415);
            this.btReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(163, 66);
            this.btReset.TabIndex = 6;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // tb6
            // 
            this.tb6.Enabled = false;
            this.tb6.Location = new System.Drawing.Point(361, 360);
            this.tb6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(100, 28);
            this.tb6.TabIndex = 5;
            // 
            // tb5
            // 
            this.tb5.Enabled = false;
            this.tb5.Location = new System.Drawing.Point(361, 300);
            this.tb5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(100, 28);
            this.tb5.TabIndex = 4;
            // 
            // tb4
            // 
            this.tb4.Enabled = false;
            this.tb4.Location = new System.Drawing.Point(361, 239);
            this.tb4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(100, 28);
            this.tb4.TabIndex = 3;
            // 
            // tb3
            // 
            this.tb3.Enabled = false;
            this.tb3.Location = new System.Drawing.Point(361, 181);
            this.tb3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(100, 28);
            this.tb3.TabIndex = 2;
            // 
            // tb2
            // 
            this.tb2.Enabled = false;
            this.tb2.Location = new System.Drawing.Point(361, 125);
            this.tb2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 28);
            this.tb2.TabIndex = 1;
            // 
            // tb1
            // 
            this.tb1.Enabled = false;
            this.tb1.Location = new System.Drawing.Point(361, 67);
            this.tb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 28);
            this.tb1.TabIndex = 0;
            this.tb1.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            // 
            // btBackToMenu
            // 
            this.btBackToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btBackToMenu.Font = new System.Drawing.Font("SimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackToMenu.Location = new System.Drawing.Point(1035, 571);
            this.btBackToMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBackToMenu.Name = "btBackToMenu";
            this.btBackToMenu.Size = new System.Drawing.Size(332, 74);
            this.btBackToMenu.TabIndex = 2;
            this.btBackToMenu.Text = "Back To Menu";
            this.btBackToMenu.UseVisualStyleBackColor = false;
            this.btBackToMenu.Click += new System.EventHandler(this.btBackToMenu_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbna4);
            this.groupBox3.Controls.Add(this.lbna3);
            this.groupBox3.Controls.Add(this.lbna2);
            this.groupBox3.Controls.Add(this.lbna1);
            this.groupBox3.Location = new System.Drawing.Point(1035, 164);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(332, 342);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // lbna4
            // 
            this.lbna4.AutoSize = true;
            this.lbna4.Font = new System.Drawing.Font("SimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbna4.Location = new System.Drawing.Point(36, 242);
            this.lbna4.Name = "lbna4";
            this.lbna4.Size = new System.Drawing.Size(151, 33);
            this.lbna4.TabIndex = 3;
            this.lbna4.Text = "Status: ";
            // 
            // lbna3
            // 
            this.lbna3.AutoSize = true;
            this.lbna3.Font = new System.Drawing.Font("SimSun", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbna3.Location = new System.Drawing.Point(196, 242);
            this.lbna3.Name = "lbna3";
            this.lbna3.Size = new System.Drawing.Size(66, 33);
            this.lbna3.TabIndex = 2;
            this.lbna3.Text = "N/A";
            // 
            // lbna2
            // 
            this.lbna2.AutoSize = true;
            this.lbna2.Font = new System.Drawing.Font("SimHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbna2.Location = new System.Drawing.Point(132, 173);
            this.lbna2.Name = "lbna2";
            this.lbna2.Size = new System.Drawing.Size(66, 33);
            this.lbna2.TabIndex = 1;
            this.lbna2.Text = "N/A";
            // 
            // lbna1
            // 
            this.lbna1.AutoSize = true;
            this.lbna1.Font = new System.Drawing.Font("SimSun", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbna1.Location = new System.Drawing.Point(109, 74);
            this.lbna1.Name = "lbna1";
            this.lbna1.Size = new System.Drawing.Size(111, 56);
            this.lbna1.TabIndex = 0;
            this.lbna1.Text = "N/A";
            // 
            // warn1
            // 
            this.warn1.AutoSize = true;
            this.warn1.Font = new System.Drawing.Font("SimHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warn1.Location = new System.Drawing.Point(99, 38);
            this.warn1.Name = "warn1";
            this.warn1.Size = new System.Drawing.Size(1095, 48);
            this.warn1.TabIndex = 4;
            this.warn1.Text = "Do not enter characters other than numbers!";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1440, 703);
            this.Controls.Add(this.warn1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btBackToMenu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button btBackToMenu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbna1;
        private System.Windows.Forms.Label lbna3;
        private System.Windows.Forms.Label lbna2;
        private System.Windows.Forms.Button btGrade2;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label warn1;
        private System.Windows.Forms.Label lbna4;
    }
}