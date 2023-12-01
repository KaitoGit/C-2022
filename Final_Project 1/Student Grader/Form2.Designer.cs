namespace Student_Grader
{
    partial class Form2
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
            this.lbAddStudent2 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbDateofBirth = new System.Windows.Forms.TextBox();
            this.tbDateofStart = new System.Windows.Forms.TextBox();
            this.btAddStudent3 = new System.Windows.Forms.Button();
            this.btExit2 = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbDateofBirth = new System.Windows.Forms.Label();
            this.lbDateofStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAddStudent2
            // 
            this.lbAddStudent2.AutoSize = true;
            this.lbAddStudent2.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddStudent2.Location = new System.Drawing.Point(21, 21);
            this.lbAddStudent2.Name = "lbAddStudent2";
            this.lbAddStudent2.Size = new System.Drawing.Size(437, 72);
            this.lbAddStudent2.TabIndex = 0;
            this.lbAddStudent2.Text = "Add Student";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(224, 113);
            this.tbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(141, 25);
            this.tbID.TabIndex = 1;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(224, 162);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(141, 25);
            this.tbName.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(224, 212);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(141, 25);
            this.tbLastName.TabIndex = 3;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(224, 263);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(141, 25);
            this.tbEmail.TabIndex = 4;
            // 
            // tbDateofBirth
            // 
            this.tbDateofBirth.Location = new System.Drawing.Point(224, 315);
            this.tbDateofBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDateofBirth.Name = "tbDateofBirth";
            this.tbDateofBirth.Size = new System.Drawing.Size(141, 25);
            this.tbDateofBirth.TabIndex = 5;
            // 
            // tbDateofStart
            // 
            this.tbDateofStart.Location = new System.Drawing.Point(224, 366);
            this.tbDateofStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDateofStart.Name = "tbDateofStart";
            this.tbDateofStart.Size = new System.Drawing.Size(141, 25);
            this.tbDateofStart.TabIndex = 6;
            // 
            // btAddStudent3
            // 
            this.btAddStudent3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddStudent3.Location = new System.Drawing.Point(38, 418);
            this.btAddStudent3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddStudent3.Name = "btAddStudent3";
            this.btAddStudent3.Size = new System.Drawing.Size(140, 33);
            this.btAddStudent3.TabIndex = 7;
            this.btAddStudent3.Text = "Add Student";
            this.btAddStudent3.UseVisualStyleBackColor = true;
            this.btAddStudent3.Click += new System.EventHandler(this.btAddStudent3_Click);
            // 
            // btExit2
            // 
            this.btExit2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit2.Location = new System.Drawing.Point(224, 418);
            this.btExit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit2.Name = "btExit2";
            this.btExit2.Size = new System.Drawing.Size(140, 33);
            this.btExit2.TabIndex = 8;
            this.btExit2.Text = "Exit";
            this.btExit2.UseVisualStyleBackColor = true;
            this.btExit2.Click += new System.EventHandler(this.btExit2_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(119, 122);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(38, 18);
            this.lbID.TabIndex = 9;
            this.lbID.Text = "ID:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(101, 171);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(58, 18);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "Name:";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.Location = new System.Drawing.Point(57, 221);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(108, 18);
            this.lbLastName.TabIndex = 11;
            this.lbLastName.Text = "Last Name:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(92, 272);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(68, 18);
            this.lbEmail.TabIndex = 12;
            this.lbEmail.Text = "Email:";
            // 
            // lbDateofBirth
            // 
            this.lbDateofBirth.AutoSize = true;
            this.lbDateofBirth.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateofBirth.Location = new System.Drawing.Point(21, 323);
            this.lbDateofBirth.Name = "lbDateofBirth";
            this.lbDateofBirth.Size = new System.Drawing.Size(148, 18);
            this.lbDateofBirth.TabIndex = 13;
            this.lbDateofBirth.Text = "Date of Birth:";
            // 
            // lbDateofStart
            // 
            this.lbDateofStart.AutoSize = true;
            this.lbDateofStart.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateofStart.Location = new System.Drawing.Point(30, 374);
            this.lbDateofStart.Name = "lbDateofStart";
            this.lbDateofStart.Size = new System.Drawing.Size(138, 18);
            this.lbDateofStart.TabIndex = 14;
            this.lbDateofStart.Text = "Date of Start";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(443, 480);
            this.Controls.Add(this.lbDateofStart);
            this.Controls.Add(this.lbDateofBirth);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btExit2);
            this.Controls.Add(this.btAddStudent3);
            this.Controls.Add(this.tbDateofStart);
            this.Controls.Add(this.tbDateofBirth);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lbAddStudent2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAddStudent2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbDateofBirth;
        private System.Windows.Forms.TextBox tbDateofStart;
        private System.Windows.Forms.Button btAddStudent3;
        private System.Windows.Forms.Button btExit2;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbDateofBirth;
        private System.Windows.Forms.Label lbDateofStart;
    }
}