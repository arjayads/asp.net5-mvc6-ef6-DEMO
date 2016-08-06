using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Track1.Models.Seed
{
    public class SchoolDBInitializer : CreateDatabaseIfNotExists<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            IList<Standard> standards = new List<Standard>();
            standards.Add(new Standard() { Name = "Stardard 1" });
            standards.Add(new Standard() { Name = "Stardard 2" });
            standards.Add(new Standard() { Name = "Stardard 3" });

            foreach (Standard std in standards)
                context.Standard.Add(std);

            base.Seed(context);
        }
    }
}