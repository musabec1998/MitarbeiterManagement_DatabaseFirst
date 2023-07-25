using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseFirst_Projekte_Mitarbeiter.Models
{
    [ModelMetadataType(typeof(Metadata))]
    public partial class Employees
    {
        public string FullName { get { return LastName + ", " + FirstName; } }

        private sealed class Metadata
        {
            [Required]
            [Display(Name = "Vorname:")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Nachname:")]
            public string LastName { get; set; }

            [Display(Name = "Aufgabe:")]
            public string ProjectRole { get; set; }

            [Display(Name = "Projekt:")]
            public Projects Project { get; set; }

            [Display(Name = "Projekt:")]
            public int? ProjectId { get; set; }
        }
    }
}
