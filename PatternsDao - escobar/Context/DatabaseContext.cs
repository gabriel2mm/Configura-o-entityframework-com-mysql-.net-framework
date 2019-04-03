using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PatternsDao___escobar.Models;

namespace PatternsDao___escobar.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("MyContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntityAluno>().ToTable("Aluno");
        }
    }    
}
