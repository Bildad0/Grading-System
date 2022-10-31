using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchStudent(searchText.Text.ToUpper());
        }

        public void SearchStudent(string id)
        {
            using(var ctx= new DataBaseContext())
            {

                var query = from st in ctx.Students where st.StudentID == id select st;


                var student = query.FirstOrDefault();

                if (student == null)
                {
                    MessageBox.Show("No such User");
                }
                else if(student.ClassName == null)
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
    }
}
