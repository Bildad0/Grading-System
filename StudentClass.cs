using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_card
{
    public class StudentClass
    {

        public StudentClass()
        {
            this.Students = new HashSet<Student>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? ClassId { get; set; }

        public string ClassName { get; set; }
     
        public Units Units { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
