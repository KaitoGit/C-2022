
namespace lab8
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
            this.tname = new System.Windows.Forms.TextBox();
            this.tlastname = new System.Windows.Forms.TextBox();
            this.tdob = new System.Windows.Forms.TextBox();
            this.tage = new System.Windows.Forms.TextBox();
            this.tSid = new System.Windows.Forms.TextBox();
            this.tGrade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(258, 54);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(100, 28);
            this.tname.TabIndex = 0;
            // 
            // tlastname
            // 
            this.tlastname.Location = new System.Drawing.Point(258, 112);
            this.tlastname.Name = "tlastname";
            this.tlastname.Size = new System.Drawing.Size(100, 28);
            this.tlastname.TabIndex = 0;
            // 
            // tdob
            // 
            this.tdob.Location = new System.Drawing.Point(258, 163);
            this.tdob.Name = "tdob";
            this.tdob.Size = new System.Drawing.Size(100, 28);
            this.tdob.TabIndex = 0;
            // 
            // tage
            // 
            this.tage.Location = new System.Drawing.Point(258, 214);
            this.tage.Name = "tage";
            this.tage.Size = new System.Drawing.Size(100, 28);
            this.tage.TabIndex = 0;
            // 
            // tSid
            // 
            this.tSid.Location = new System.Drawing.Point(258, 268);
            this.tSid.Name = "tSid";
            this.tSid.Size = new System.Drawing.Size(100, 28);
            this.tSid.TabIndex = 0;
            // 
            // tGrade
            // 
            this.tGrade.Location = new System.Drawing.Point(258, 317);
            this.tGrade.Name = "tGrade";
            this.tGrade.Size = new System.Drawing.Size(100, 28);
            this.tGrade.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(63, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(63, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(63, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dob";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(63, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(63, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Student ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(63, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Grade";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tGrade);
            this.Controls.Add(this.tSid);
            this.Controls.Add(this.tage);
            this.Controls.Add(this.tdob);
            this.Controls.Add(this.tlastname);
            this.Controls.Add(this.tname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.TextBox tlastname;
        private System.Windows.Forms.TextBox tdob;
        private System.Windows.Forms.TextBox tage;
        private System.Windows.Forms.TextBox tSid;
        private System.Windows.Forms.TextBox tGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

