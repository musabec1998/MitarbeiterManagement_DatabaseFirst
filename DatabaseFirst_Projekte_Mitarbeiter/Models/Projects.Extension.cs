using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseFirst_Projekte_Mitarbeiter.Models
{
    [ModelMetadataType(typeof(Metadata))]
    public partial class Projects
    {
        private sealed class Metadata
        {
            [Required]
            [Display(Name = "Projektname:")]
            public string Name { get; set; }

            [Required]
            [Display(Name = "Startdatum:")]
            [DataType(DataType.Date)]
            public DateTime StartDate { get; set; }

            [Required]
            [Display(Name = "Budget:")]
            [DataType(DataType.Currency)]
            public double Budget { get; set; }

            [Display(Name = "Mitarbeiter:")]
            public ICollection<Employees> Employees { get; set; }
        }
    }
}
