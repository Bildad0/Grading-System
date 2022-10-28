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
    public partial class NewStudentForm : Form
    {
        public NewStudentForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResultEntryForm resultEntryForm = new ResultEntryForm();
            resultEntryForm.Show();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            using(var ctx =new DataBaseContext())
            {
                var student = new Student()
                {
                    StudentID= studentIdTextBox.Text.ToUpper().Trim(),
                    StudentName= firstNameTextBox.Text+ " "+lastNameTextBox.Text,
                    ClassName = ClassComboBox.Text,
                    YearOfStudy= int.Parse(YearOfStudytxtBox.Text)
                };

                ctx.Students.Add(student);
                ctx.SaveChanges();
                ResetFields();
                MessageBox.Show($"{firstNameTextBox.Text} saved");
            }
        }

        public void ResetFields()
        {
            studentIdTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            ClassComboBox.Text = "";
            YearOfStudytxtBox.Text = "";
        }

        private void StudentListBtn_Click(object sender, EventArgs e)
        {
            StudentView studentView = new StudentView();
            studentView.Show();
        }
    }
}
