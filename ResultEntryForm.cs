using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Report_card
{
    public partial class ResultEntryForm : Form
    {
        public ResultEntryForm()
        {
            InitializeComponent();
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewStudentForm newStudentForm = new NewStudentForm();
            newStudentForm.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchStudent(searchText.Text.ToUpper());
            //LoadUnits();
        }


        //get list of units from the units dataset, load it to each textbost uner unit lable
        public void LoadUnits()
        {
            List<Units> unit = new List<Units>();
            using (var ctx = new DataBaseContext())
            {
                unit = ctx.Units.ToList();
            }

        }

        public void SearchStudent(string id)
        {
            using (var ctx = new DataBaseContext())
            {

                var query = from st in ctx.Students where st.StudentID == id select st;


                var student = query.FirstOrDefault();

                if (student == null)
                {
                    MessageBox.Show("No such User");
                }
                else if (student.ClassName == null)
                {
                    searchText.Text = student.StudentID.ToString();
                    studentIdTxtBox.Text = student.Id.ToString();
                    studentName.Text = student.StudentName.ToString();
                    yearTextBox.Text = student.YearOfStudy.ToString();
                    classTextbox.Text = "Null";
                }
                else
                {
                    searchText.Text = student.StudentID.ToString();
                    studentIdTxtBox.Text = student.Id.ToString();
                    studentName.Text = student.StudentName.ToString();
                    yearTextBox.Text = student.YearOfStudy.ToString();
                    classTextbox.Text = student.ClassName.ToString();
                }

            }
        }

        private void saveGradeBtn_Click(object sender, EventArgs e)
        {
            Grading();
            Clear();
        }

        public void Clear()
        {
            FirstUnitMarks.Text = "";
            secondUnitMarks.Text = "";
            ThirdUnitMarks.Text = "";
            FourthUnitMarks.Text = "";
            FifthUnitMarks.Text = "";
            SixthUnitMarks.Text = "";
            SeventhUnitMarks.Text = "";
            EightUnitMarks.Text = "";
        }

        //grading students
        public string Grading()
        {
            String Grade="";
            if (FirstUnitMarks.Text != null)
            {
                int Marks = int.Parse(FirstUnitMarks.Text);

                switch (Marks)
                {
                    case 39:
                        Grade = "E";
                        break;
                    case 50:
                        Grade ="D";
                        break;
                }
            }
            if (secondUnitMarks.Text != null)
            {
                int Marks = int.Parse(secondUnitMarks.Text);
                switch (Marks)
                {
                    case 39:
                        Grade = "E";
                        break;
                    case 50:
                        Grade = "D";
                        break;
                }
            }
            if (ThirdUnitMarks.Text != null)
            {
                int Marks = int.Parse(ThirdUnitMarks.Text);
                switch (Marks)
                {
                    case 39:
                        Grade = "E";
                        break;
                    case 50:
                        Grade = "D";
                        break;
                    case 60:
                        Grade = "C";
                        break;
                }
            }
            if (FourthUnitMarks.Text != null)
            {
                int Marks = int.Parse(FourthUnitMarks.Text);

                switch (Marks)
                {
                    case 39:
                        Grade = "E";
                        break;
                    case 50:
                        Grade = "D";
                        break;
                    case 60:
                        Grade = "C";
                        break;
                }
            }
            if (FifthUnitMarks.Text != null)
            {
                int Marks = int.Parse(FifthUnitMarks.Text);
                switch (Marks)
                {
                    case 39:
                        Grade = "E";
                        break;
                    case 50:
                        Grade = "D";
                        break;
                    case 60:
                        Grade = "C";
                        break;
                }
            }
            if (SixthUnitMarks.Text != null)
            {
                int Marks = int.Parse(SixthUnitMarks.Text);
                switch (Marks)
                {
                    case 39:
                        Grade = "E";
                        break;
                    case 50:
                        Grade = "D";
                        break;
                    case 60:
                        Grade = "C";
                        break;
                }
            }
            if (SeventhUnitMarks.Text != null)
            {
                int Marks = int.Parse(SeventhUnitMarks.Text);

                switch (Marks)
                {
                    case 39:
                        Grade = "E";
                        break;
                    case 50:
                        Grade = "D";
                        break;
                    case 60:
                        Grade = "C";
                        break;
                }
            }
            if (EightUnitMarks.Text != null)
            {
                int Marks = int.Parse(EightUnitMarks.Text);
                switch (Marks)
                {
                    case 39:
                        Grade = "E";
                        break;
                    case 50:
                        Grade = "D";
                        break;
                    case 60:
                        Grade = "C";
                        break;
                }
            }
            Console.WriteLine(Grade);
            return Grade;
            //the returned grade should be stored in the databse with the corresponding Unit.
        }
    }


}
