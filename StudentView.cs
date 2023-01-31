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
    public partial class StudentView : Form
    {
        public StudentView()
        {
            InitializeComponent();
        }

        private void StudentView_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        public void Load_Data()
        {


            List<Student> students = new List<Student>();
            using(var ctx = new DataBaseContext())
            {
                 students = ctx.Students.Include(nameof(Student.StudentClass)).OrderByDescending(s=>s.YearOfStudy).ToList();
       
            }
            studentDataGridView.DataSource = students;
           
            //hide some data from view
            studentDataGridView.Columns["ClassId"].Visible = false;
            studentDataGridView.Columns["Units"].Visible = false;
            studentDataGridView.Columns["StudentClass"].Visible = false;
        }

        private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (studentDataGridView.Rows.Count >0)
            {
                foreach (DataGridViewRow row in studentDataGridView.SelectedRows)
                {

                }

            }
        }
    }
}
