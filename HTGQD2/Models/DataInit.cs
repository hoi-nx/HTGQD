using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HTGQD2.Models
{
    public class DataInit: DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            context.University.Add(new University()
            {
                UniversityName = "BKHN",
                Major = "CNTT",
                Evaluation = 3,
                ExpectedPoint = 26,
                ExPoint = 24,
                Fee = 350000,
                Location = 1,
                Volumn = 250
            });
            context.University.Add(new University()
            {
                UniversityName = "BKHCM",
                Major = "CNTT",
                Evaluation = 3,
                ExpectedPoint = 25,
                ExPoint = 23,
                Fee = 350000,
                Location = 3,
                Volumn = 250
            });
            context.University.Add(new University()
            {
                UniversityName = "BKDN",
                Major = "CNTT",
                Evaluation = 3,
                ExpectedPoint = 25,
                ExPoint = 23,
                Fee = 350000,
                Location = 2,
                Volumn = 250
            });
            context.SaveChanges();
            base.Seed(context);

        }
    }
}