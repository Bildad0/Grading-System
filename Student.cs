using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_card
{
   public class Student
    {
        [Key]
        public int id { get; set; }

        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string ClassName { get; set; }
        public byte[] StudentImage { get; set; }
        public int YearOfStudy { get; set; }

        public StudentClass Class { get; set; }
    }
}
