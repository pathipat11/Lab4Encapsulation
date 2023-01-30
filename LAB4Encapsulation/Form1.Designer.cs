namespace LAB4Encapsulation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbBirthYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tblistofPerson = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGPA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAvg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNameMin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNameMax = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(60, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(188, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.Gainsboro;
            this.tbName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(111, 40);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(150, 31);
            this.tbName.TabIndex = 2;
            // 
            // tbBirthYear
            // 
            this.tbBirthYear.BackColor = System.Drawing.Color.Gainsboro;
            this.tbBirthYear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbBirthYear.Location = new System.Drawing.Point(111, 98);
            this.tbBirthYear.Name = "tbBirthYear";
            this.tbBirthYear.Size = new System.Drawing.Size(150, 31);
            this.tbBirthYear.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "BirthYear :";
            // 
            // tblistofPerson
            // 
            this.tblistofPerson.BackColor = System.Drawing.Color.Gainsboro;
            this.tblistofPerson.Location = new System.Drawing.Point(106, 260);
            this.tblistofPerson.Multiline = true;
            this.tblistofPerson.Name = "tblistofPerson";
            this.tblistofPerson.Size = new System.Drawing.Size(150, 145);
            this.tblistofPerson.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contacts :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Age :";
            // 
            // tbTotal
            // 
            this.tbTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.tbTotal.Location = new System.Drawing.Point(106, 206);
            this.tbTotal.Multiline = true;
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(150, 31);
            this.tbTotal.TabIndex = 12;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.IndianRed;
            this.Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete.Location = new System.Drawing.Point(188, 245);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(111, 80);
            this.Delete.TabIndex = 13;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "GPA :";
            // 
            // tbGPA
            // 
            this.tbGPA.BackColor = System.Drawing.Color.Gainsboro;
            this.tbGPA.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbGPA.Location = new System.Drawing.Point(111, 161);
            this.tbGPA.Name = "tbGPA";
            this.tbGPA.Size = new System.Drawing.Size(150, 31);
            this.tbGPA.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "GPA Max :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "GPA Min :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "GPA Avg :";
            // 
            // tbAvg
            // 
            this.tbAvg.BackColor = System.Drawing.Color.Gainsboro;
            this.tbAvg.Location = new System.Drawing.Point(106, 152);
            this.tbAvg.Name = "tbAvg";
            this.tbAvg.Size = new System.Drawing.Size(150, 31);
            this.tbAvg.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Name :";
            // 
            // tbNameMin
            // 
            this.tbNameMin.BackColor = System.Drawing.Color.Gainsboro;
            this.tbNameMin.Location = new System.Drawing.Point(359, 137);
            this.tbNameMin.Name = "tbNameMin";
            this.tbNameMin.Size = new System.Drawing.Size(150, 31);
            this.tbNameMin.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(285, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Name :";
            // 
            // tbNameMax
            // 
            this.tbNameMax.BackColor = System.Drawing.Color.Gainsboro;
            this.tbNameMax.Location = new System.Drawing.Point(359, 58);
            this.tbNameMax.Name = "tbNameMax";
            this.tbNameMax.Size = new System.Drawing.Size(150, 31);
            this.tbNameMax.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbMax);
            this.groupBox1.Controls.Add(this.tbNameMin);
            this.groupBox1.Controls.Add(this.tbMin);
            this.groupBox1.Controls.Add(this.tblistofPerson);
            this.groupBox1.Controls.Add(this.tbNameMax);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbTotal);
            this.groupBox1.Controls.Add(this.tbAvg);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(319, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 426);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Information";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(331, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 25);
            this.label13.TabIndex = 30;
            this.label13.Text = "GPA MAX";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(331, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "GPA MIN";
            // 
            // tbMax
            // 
            this.tbMax.BackColor = System.Drawing.Color.Gainsboro;
            this.tbMax.Location = new System.Drawing.Point(106, 42);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(150, 31);
            this.tbMax.TabIndex = 28;
            // 
            // tbMin
            // 
            this.tbMin.BackColor = System.Drawing.Color.Gainsboro;
            this.tbMin.Location = new System.Drawing.Point(106, 99);
            this.tbMin.Multiline = true;
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(150, 31);
            this.tbMin.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 482);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbGPA);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBirthYear);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox tbName;
        private TextBox tbBirthYear;
        private Label label2;
        private Label label3;
        private TextBox tblistofPerson;
        private Label label5;
        private Label label6;
        private TextBox tbTotal;
        private Button Delete;
        private Label label4;
        private TextBox tbGPA;
        private Label label7;
        private TextBox tbGpaMax;
        private Label label8;
        private TextBox tbGpaMin;
        private Label label10;
        private TextBox tbAvg;
        private Label label9;
        private TextBox tbNameMin;
        private Label label11;
        private TextBox tbNameMax;
        private GroupBox groupBox1;
        private TextBox tbMax;
        private TextBox tbMin;
        private Label label13;
        private Label label12;
    }
}