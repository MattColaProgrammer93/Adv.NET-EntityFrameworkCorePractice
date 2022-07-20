using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCorePractice
{
    // EF Core Getting Started
    // https://docs.microsoft.com/en-us/ef/core/get-started/overview/install
    internal class AnimalContext : DbContext
    {
        public AnimalContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Database = The name for the database
            // Server = The server we are connecting to. LocalDB is included with VS
            // Trusted_Connection - indicates that our windows account should be used
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Matt-EFCorePractice;Trusted_Connection=True;");
        }
    }
}
