using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCorePractice
{
    /// <summary>
    /// A individual animal 
    /// </summary>
    public class Animal
    {
        [Key] // Tells the EF Core to make this a Primary Key (PK)
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Ability { get; set; }
    }
}
