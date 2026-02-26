using Microsoft.EntityFrameworkCore;
using Prakt12.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt12.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
            ("Server=(localdb)\\MSSQLLocalDB;Database=prakt12;TrustServerCertificate=True;");
        }
    }
}
