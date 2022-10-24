using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_card
{
    public class StudentClass
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; }
       
        public Units Units { get; set; }
    }
}
