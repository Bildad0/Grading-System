using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_card
{
   public class Student
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentClass { get; set; }
        public byte[] StudentImage { get; set; }
        public int YearOfStudy { get; set; }

        public Grade Grade { get; set; }
    }
}
