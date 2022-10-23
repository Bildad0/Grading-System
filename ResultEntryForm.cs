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
    }
}
