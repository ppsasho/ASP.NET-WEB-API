using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<Note>? Notes { get; set; } = new List<Note>();
        [InverseProperty("User")]
        public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();
        [InverseProperty("User")]
        public virtual ICollection<Meal> Meals { get; set; } = new List<Meal>();
    }
}
