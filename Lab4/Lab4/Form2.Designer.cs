namespace Lab4
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
            this.lsbUnsorted = new System.Windows.Forms.ListBox();
            this.lsbSorted = new System.Windows.Forms.ListBox();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbUnsorted
            // 
            this.lsbUnsorted.FormattingEnabled = true;
            this.lsbUnsorted.ItemHeight = 24;
            this.lsbUnsorted.Location = new System.Drawing.Point(347, 149);
            this.lsbUnsorted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbUnsorted.Name = "lsbUnsorted";
            this.lsbUnsorted.Size = new System.Drawing.Size(249, 388);
            this.lsbUnsorted.TabIndex = 0;
            // 
            // lsbSorted
            // 
            this.lsbSorted.FormattingEnabled = true;
            this.lsbSorted.ItemHeight = 24;
            this.lsbSorted.Location = new System.Drawing.Point(36, 149);
            this.lsbSorted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbSorted.Name = "lsbSorted";
            this.lsbSorted.Size = new System.Drawing.Size(261, 388);
            this.lsbSorted.TabIndex = 1;
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(36, 59);
            this.tbNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(181, 35);
            this.tbNum.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStart.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(286, 59);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(310, 35);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(242, 567);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(187, 62);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 641);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.lsbSorted);
            this.Controls.Add(this.lsbUnsorted);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbUnsorted;
        private System.Windows.Forms.ListBox lsbSorted;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBack;
    }
}