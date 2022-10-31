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

        [Required(ErrorMessage ="Student's id is required")]
        public string StudentID { get; set; }
        [Required(ErrorMessage ="Student's name is required")]
        public string StudentName { get; set; }
        public string ClassName { get; set; }
        public byte[] StudentImage { get; set; }
        [Required(ErrorMessage ="Required Field")]
        public int YearOfStudy { get; set; }

        [ForeignKey("StudentClass")]
        public int? ClassId { get; set; }

       
        public virtual StudentClass StudentClass { get; set; }
    }
}
