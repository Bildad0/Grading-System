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
                students = ctx.Students.ToList();
            }
            studentDataGridView.DataSource = students;
        }
    }
}
