
namespace Project2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.gbinformation = new System.Windows.Forms.GroupBox();
            this.extra3 = new System.Windows.Forms.Label();
            this.extra2 = new System.Windows.Forms.Label();
            this.extra1 = new System.Windows.Forms.Label();
            this.lbprice = new System.Windows.Forms.Label();
            this.lbmodel = new System.Windows.Forms.Label();
            this.lbbrand = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.btninformation = new System.Windows.Forms.Button();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbinformation.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb1
            // 
            this.cb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "TV",
            "Fridge",
            "Stove"});
            this.cb1.Location = new System.Drawing.Point(723, 41);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(139, 37);
            this.cb1.TabIndex = 0;
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnshow.ForeColor = System.Drawing.Color.White;
            this.btnshow.Location = new System.Drawing.Point(723, 108);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(139, 50);
            this.btnshow.TabIndex = 1;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.Show_Click);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.listBoxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxProducts.ForeColor = System.Drawing.Color.White;
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 29;
            this.listBoxProducts.Location = new System.Drawing.Point(878, 27);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(310, 265);
            this.listBoxProducts.TabIndex = 2;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // gbinformation
            // 
            this.gbinformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.gbinformation.Controls.Add(this.extra3);
            this.gbinformation.Controls.Add(this.extra2);
            this.gbinformation.Controls.Add(this.extra1);
            this.gbinformation.Controls.Add(this.lbprice);
            this.gbinformation.Controls.Add(this.lbmodel);
            this.gbinformation.Controls.Add(this.lbbrand);
            this.gbinformation.Controls.Add(this.lbid);
            this.gbinformation.ForeColor = System.Drawing.Color.White;
            this.gbinformation.Location = new System.Drawing.Point(544, 298);
            this.gbinformation.Name = "gbinformation";
            this.gbinformation.Size = new System.Drawing.Size(644, 374);
            this.gbinformation.TabIndex = 3;
            this.gbinformation.TabStop = false;
            this.gbinformation.Text = "Information";
            // 
            // extra3
            // 
            this.extra3.AutoSize = true;
            this.extra3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.extra3.Location = new System.Drawing.Point(327, 323);
            this.extra3.Name = "extra3";
            this.extra3.Size = new System.Drawing.Size(0, 29);
            this.extra3.TabIndex = 3;
            // 
            // extra2
            // 
            this.extra2.AutoSize = true;
            this.extra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.extra2.Location = new System.Drawing.Point(327, 238);
            this.extra2.Name = "extra2";
            this.extra2.Size = new System.Drawing.Size(0, 29);
            this.extra2.TabIndex = 2;
            // 
            // extra1
            // 
            this.extra1.AutoSize = true;
            this.extra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.extra1.Location = new System.Drawing.Point(327, 153);
            this.extra1.Name = "extra1";
            this.extra1.Size = new System.Drawing.Size(0, 29);
            this.extra1.TabIndex = 1;
            // 
            // lbprice
            // 
            this.lbprice.AutoSize = true;
            this.lbprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbprice.Location = new System.Drawing.Point(44, 323);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(0, 29);
            this.lbprice.TabIndex = 0;
            // 
            // lbmodel
            // 
            this.lbmodel.AutoSize = true;
            this.lbmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbmodel.Location = new System.Drawing.Point(44, 238);
            this.lbmodel.Name = "lbmodel";
            this.lbmodel.Size = new System.Drawing.Size(0, 29);
            this.lbmodel.TabIndex = 0;
            // 
            // lbbrand
            // 
            this.lbbrand.AutoSize = true;
            this.lbbrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbbrand.Location = new System.Drawing.Point(44, 153);
            this.lbbrand.Name = "lbbrand";
            this.lbbrand.Size = new System.Drawing.Size(0, 29);
            this.lbbrand.TabIndex = 0;
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbid.Location = new System.Drawing.Point(44, 61);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(0, 29);
            this.lbid.TabIndex = 0;
            // 
            // btninformation
            // 
            this.btninformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btninformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btninformation.ForeColor = System.Drawing.Color.White;
            this.btninformation.Location = new System.Drawing.Point(595, 164);
            this.btninformation.Name = "btninformation";
            this.btninformation.Size = new System.Drawing.Size(267, 52);
            this.btninformation.TabIndex = 5;
            this.btninformation.Text = "Show Information";
            this.btninformation.UseVisualStyleBackColor = false;
            this.btninformation.Click += new System.EventHandler(this.btninformation_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sideBar.Controls.Add(this.panel2);
            this.sideBar.Controls.Add(this.btnHome);
            this.sideBar.Controls.Add(this.button1);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(250, 703);
            this.sideBar.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 137);
            this.panel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(20, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 36);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(88, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Menu";
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 146);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(247, 70);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "  Main Menu";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 70);
            this.button1.TabIndex = 7;
            this.button1.Text = "  Add Products";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1202, 703);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.btninformation);
            this.Controls.Add(this.gbinformation);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.cb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Products";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gbinformation.ResumeLayout(false);
            this.gbinformation.PerformLayout();
            this.sideBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.GroupBox gbinformation;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.Label lbmodel;
        private System.Windows.Forms.Label lbbrand;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Button btninformation;
        private System.Windows.Forms.Label extra3;
        private System.Windows.Forms.Label extra2;
        private System.Windows.Forms.Label extra1;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button button1;
    }
}