namespace Student_Grader
{
    partial class Form1
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
            this.lbStudentGrader = new System.Windows.Forms.Label();
            this.lbMainMenu = new System.Windows.Forms.Label();
            this.btAddStudent = new System.Windows.Forms.Button();
            this.btGrade = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.inf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbStudentGrader
            // 
            this.lbStudentGrader.AutoSize = true;
            this.lbStudentGrader.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentGrader.Location = new System.Drawing.Point(12, 23);
            this.lbStudentGrader.Name = "lbStudentGrader";
            this.lbStudentGrader.Size = new System.Drawing.Size(548, 72);
            this.lbStudentGrader.TabIndex = 0;
            this.lbStudentGrader.Text = "Student Grader";
            // 
            // lbMainMenu
            // 
            this.lbMainMenu.AutoSize = true;
            this.lbMainMenu.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMainMenu.Location = new System.Drawing.Point(164, 114);
            this.lbMainMenu.Name = "lbMainMenu";
            this.lbMainMenu.Size = new System.Drawing.Size(186, 36);
            this.lbMainMenu.TabIndex = 1;
            this.lbMainMenu.Text = "Main Menu";
            // 
            // btAddStudent
            // 
            this.btAddStudent.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddStudent.Location = new System.Drawing.Point(169, 195);
            this.btAddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddStudent.Name = "btAddStudent";
            this.btAddStudent.Size = new System.Drawing.Size(160, 43);
            this.btAddStudent.TabIndex = 2;
            this.btAddStudent.Text = "AddStudent";
            this.btAddStudent.UseVisualStyleBackColor = true;
            this.btAddStudent.Click += new System.EventHandler(this.btAddStudent_Click);
            // 
            // btGrade
            // 
            this.btGrade.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGrade.Location = new System.Drawing.Point(169, 278);
            this.btGrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGrade.Name = "btGrade";
            this.btGrade.Size = new System.Drawing.Size(160, 43);
            this.btGrade.TabIndex = 3;
            this.btGrade.Text = "Grade";
            this.btGrade.UseVisualStyleBackColor = true;
            this.btGrade.Click += new System.EventHandler(this.btGrade_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.LightCoral;
            this.btExit.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.Black;
            this.btExit.Location = new System.Drawing.Point(169, 358);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(160, 43);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // inf
            // 
            this.inf.AutoSize = true;
            this.inf.Font = new System.Drawing.Font("Segoe Script", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inf.Location = new System.Drawing.Point(144, 421);
            this.inf.Name = "inf";
            this.inf.Size = new System.Drawing.Size(206, 25);
            this.inf.TabIndex = 5;
            this.inf.Text = "@2022 C# programmers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(510, 455);
            this.Controls.Add(this.inf);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btGrade);
            this.Controls.Add(this.btAddStudent);
            this.Controls.Add(this.lbMainMenu);
            this.Controls.Add(this.lbStudentGrader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStudentGrader;
        private System.Windows.Forms.Label lbMainMenu;
        private System.Windows.Forms.Button btAddStudent;
        private System.Windows.Forms.Button btGrade;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label inf;
    }
}

