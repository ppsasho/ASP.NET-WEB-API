using System;
using System.Collections.Generic;

namespace DataAccess.Domain
{
    public partial class Note
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public string? Color { get; set; }
        public int Tag { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
