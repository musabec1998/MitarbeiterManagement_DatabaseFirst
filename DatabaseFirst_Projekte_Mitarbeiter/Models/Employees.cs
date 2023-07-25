using System;
using System.Collections.Generic;

namespace DatabaseFirst_Projekte_Mitarbeiter.Models
{
    public partial class Employees
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string ProjectRole { get; set; } = null!;
        public int? ProjectId { get; set; }

        public virtual Projects? Project { get; set; }
    }
}
