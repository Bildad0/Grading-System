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
            string SearchTxt = searchText.Text.Trim().ToUpper();
            SearchStudent(SearchTxt);
        }

        public void SearchStudent(string studentid)
        {
            using(var ctx= new DataBaseContext())
            {
                //error!
                //Input string was not in a correct format
                Student student = ctx.Students.Find(studentid);
                var data = new Student()
                {
                    StudentID= searchText.Text,
                    //StudentImage= studentImage.Image,
                    StudentName=studentName.Text,
                    YearOfStudy= int.Parse(yearTextBox.Text),
                };
            }
        }
    }
}
