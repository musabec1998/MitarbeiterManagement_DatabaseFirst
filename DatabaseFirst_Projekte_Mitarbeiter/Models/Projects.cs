using System;
using System.Collections.Generic;

namespace DatabaseFirst_Projekte_Mitarbeiter.Models
{
    public partial class Projects
    {
        public Projects()
        {
            Employees = new HashSet<Employees>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public double Budget { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
