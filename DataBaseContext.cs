using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_card
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("GradingSystem")
        { 
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }

   
}
