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
            int SearchTxt = int.Parse(searchText.Text);
            SearchStudent(SearchTxt);
        }

        public void SearchStudent(int id)
        {
            using(var ctx= new DataBaseContext())
            {
                //error!
                //Input string was not in a correct format
                Student student = ctx.Students.Find(id);
                var data = new Student()
                {
                    id=int.Parse(searchText.Text),
                    //StudentImage= studentImage.Image,
                    StudentID =studentIdTxtBox.Text,
                    StudentName=studentName.Text,
                    YearOfStudy= int.Parse(yearTextBox.Text),
                };
            }
        }
    }
}
