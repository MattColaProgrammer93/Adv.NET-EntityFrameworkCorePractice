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

        /// <summary>
        /// The animal's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The animal's type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The animal's ability
        /// </summary>
        public string Ability { get; set; }
    }
}
