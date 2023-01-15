namespace LAB3
{
    public partial class Form1 : Form
    {
        List<Student> List = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get value from textbox
            String name = this.textBoxName.Text;
            String studentid = this.textBoxStudentid.Text;
            String birthyear = this.textBoxBirthyear.Text;
            String height = this.textBoxHeight.Text;
            String grade = this.textBoxGrade.Text;
            String major = this.textBoxMajor.Text;

            //convert string to in
            int iYear = Int32.Parse(birthyear);
            double iGrade = Double.Parse(grade);

            //create obj from Student
            Student newStudent = new Student(name, studentid, iYear, height, iGrade, major);

            //add new student to list
            this.List.Add(newStudent);




            BindingSource source = new BindingSource();
            source.DataSource = this.List;
            this.dataGridView1.DataSource = source;

            //clear textbox
            this.textBoxName.Text = " ";
            this.textBoxStudentid.Text = " ";
            this.textBoxBirthyear.Text = " ";
            this.textBoxHeight.Text = " ";
            this.textBoxGrade.Text = " ";
            this.textBoxMajor.Text = " ";



            //Maximum
            Max.Text = (from DataGridViewRow row in dataGridView1.Rows
                        where row.Cells[1].FormattedValue.ToString() != string.Empty
                        select Convert.ToDouble(row.Cells[4].FormattedValue)).Max().ToString();
            double maxstudent = 0;
            for (int i = 1; i <= dataGridView1.Rows.Count - 1; i++)
            {
                if (maxstudent < double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                {
                    maxstudent = double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
            }

            Max.Text = maxstudent.ToString();

            double[] cmax = new double[dataGridView1.Rows.Count];
            cmax = (from DataGridViewRow row in dataGridView1.Rows
                    where row.Cells[1].FormattedValue.ToString() != string.Empty
                    select Convert.ToDouble(row.Cells[4].FormattedValue)).ToArray();

            Max.Text = cmax.Max().ToString();



            //Minimum
            Min.Text = (from DataGridViewRow row in dataGridView1.Rows
                        where row.Cells[1].FormattedValue.ToString() != string.Empty
                        select Convert.ToDouble(row.Cells[4].FormattedValue)).Max().ToString();
            double minstudent = 0;
            for (int i = 1; i <= dataGridView1.Rows.Count - 1; i++)
            {
                if (minstudent < double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                {
                    minstudent = double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
            }

            Min.Text = minstudent.ToString();

            double[] cmin = new double[dataGridView1.Rows.Count];
            cmin = (from DataGridViewRow row in dataGridView1.Rows
                    where row.Cells[1].FormattedValue.ToString() != string.Empty
                    select Convert.ToDouble(row.Cells[4].FormattedValue)).ToArray();

            Min.Text = cmin.Min().ToString();

            int numstudent = dataGridView1.Rows.Count;
            Numstudent.Text = numstudent.ToString();
        }
    }
}