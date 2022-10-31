using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_card
{
   public class Units
    {
       public Units()
        {
            this.Classes = new HashSet<StudentClass>();
        }
        [Key]
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public string Grade { get; set; }

        public ICollection<StudentClass> Classes { get; set; }
        public virtual Student Student { get; set; }
    }
}
