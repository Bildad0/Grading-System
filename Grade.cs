﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_card
{
    public class Grade
    {
        [Key]
        public int GradeID { get; set; }
        public char GradeName { get; set; }
        public string Unit { get; set; }

        public ICollection<Units> Units { get; set; }
    }
}
