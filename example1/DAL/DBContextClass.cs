using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBContextClass : DbContext
    {
        public DBContextClass(DbContextOptions<DBContextClass> options) : base(options)
        {
        }

        protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb);database=EFExample;integrated security=true;");
            
        }
        public DbSet<Person> persons { get; set; }
    }
}
