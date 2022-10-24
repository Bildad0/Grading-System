using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_card
{
    public class Grade
    {
        public int GradeID { get; set; }
        public string GradeName { get; set; }
        public string Unit { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
