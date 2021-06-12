using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace School2
{
    class SchoolContext: DbContext
    {
        public SchoolContext() : base()
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }

    internal class DbContext
    {
    }
}
