using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstExample
{
    class SchoolDBEntities: DbContext
    {
        public DbSet<Student> Students {  get; set; }
        public DbSet<Standard> Standards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;
                                        Database=SchoolEFCore;
                                        Trusted_Connection=True;
                                        MultipleActiveResultSets=True;");
        }
    }
}
