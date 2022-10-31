using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_card
{
    class DataBaseInitializer: CreateDatabaseIfNotExists<DataBaseContext>
    {
        protected override void Seed(DataBaseContext context)
        {
            IList<StudentClass> DefaultClasses = new List<StudentClass>
            {
                new StudentClass() { ClassName = "JFT-2015" },
                new StudentClass() { ClassName = "JFT-2016" },
                new StudentClass() { ClassName = "JFT-2017" },
                new StudentClass() { ClassName = "JFT-2018" },
                new StudentClass() { ClassName = "JFT-2019" },
                new StudentClass() { ClassName = "JFT-2020" },
                new StudentClass() { ClassName = "JFT-2021" },
                new StudentClass() { ClassName = "JFT-2022" },
                new StudentClass() { ClassName = "JFT-2023" }
            };

            context.StudentClasses.AddRange(DefaultClasses);
            base.Seed(context);
        }
    }
}
