﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_card
{
   public class Units
    {
        [Key]
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public Grade Grade { get; set; }

        public ICollection<StudentClass> Classes { get; set; }
    }
}
