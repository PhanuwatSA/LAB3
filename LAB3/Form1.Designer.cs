namespace LAB3
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBirthyear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStudentid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMajor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Studentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.TextBox();
            this.Min = new System.Windows.Forms.TextBox();
            this.Numstudent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(98, 18);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 27);
            this.textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Birth year";
            // 
            // textBoxBirthyear
            // 
            this.textBoxBirthyear.Location = new System.Drawing.Point(98, 84);
            this.textBoxBirthyear.Name = "textBoxBirthyear";
            this.textBoxBirthyear.Size = new System.Drawing.Size(125, 27);
            this.textBoxBirthyear.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student id";
            // 
            // textBoxStudentid
            // 
            this.textBoxStudentid.Location = new System.Drawing.Point(98, 51);
            this.textBoxStudentid.Name = "textBoxStudentid";
            this.textBoxStudentid.Size = new System.Drawing.Size(125, 27);
            this.textBoxStudentid.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Major";
            // 
            // textBoxMajor
            // 
            this.textBoxMajor.Location = new System.Drawing.Point(98, 183);
            this.textBoxMajor.Name = "textBoxMajor";
            this.textBoxMajor.Size = new System.Drawing.Size(125, 27);
            this.textBoxMajor.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Grade";
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(98, 150);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(125, 27);
            this.textBoxGrade.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Height";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(98, 117);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(125, 27);
            this.textBoxHeight.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Studentid,
            this.Birthyear,
            this.Height,
            this.Grade,
            this.Major});
            this.dataGridView1.Location = new System.Drawing.Point(238, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(550, 274);
            this.dataGridView1.TabIndex = 13;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Studentid
            // 
            this.Studentid.DataPropertyName = "Studentid";
            this.Studentid.HeaderText = "Studentid";
            this.Studentid.MinimumWidth = 6;
            this.Studentid.Name = "Studentid";
            this.Studentid.Width = 125;
            // 
            // Birthyear
            // 
            this.Birthyear.DataPropertyName = "Birthyear";
            this.Birthyear.HeaderText = "Birthyear";
            this.Birthyear.MinimumWidth = 6;
            this.Birthyear.Name = "Birthyear";
            this.Birthyear.Width = 125;
            // 
            // Height
            // 
            this.Height.DataPropertyName = "Height";
            this.Height.HeaderText = "Height";
            this.Height.MinimumWidth = 6;
            this.Height.Name = "Height";
            this.Height.Width = 125;
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "Grade";
            this.Grade.HeaderText = "Grade";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.Width = 125;
            // 
            // Major
            // 
            this.Major.DataPropertyName = "Major";
            this.Major.HeaderText = "Major";
            this.Major.MinimumWidth = 6;
            this.Major.Name = "Major";
            this.Major.Width = 125;
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(501, 303);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(125, 27);
            this.Max.TabIndex = 14;
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(501, 336);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(125, 27);
            this.Min.TabIndex = 15;
            // 
            // Numstudent
            // 
            this.Numstudent.Location = new System.Drawing.Point(501, 369);
            this.Numstudent.Name = "Numstudent";
            this.Numstudent.Size = new System.Drawing.Size(125, 27);
            this.Numstudent.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Max Grade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Min Grade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Number of Student";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Numstudent);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMajor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxStudentid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBirthyear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxName;
        private Label label1;
        private Label label2;
        private TextBox textBoxBirthyear;
        private Label label3;
        private TextBox textBoxStudentid;
        private Label label4;
        private TextBox textBoxMajor;
        private Label label5;
        private TextBox textBoxGrade;
        private Label label6;
        private TextBox textBoxHeight;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Studentid;
        private DataGridViewTextBoxColumn Birthyear;
        private DataGridViewTextBoxColumn Height;
        private DataGridViewTextBoxColumn Grade;
        private DataGridViewTextBoxColumn Major;
        private TextBox Max;
        private TextBox Min;
        private TextBox Numstudent;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}