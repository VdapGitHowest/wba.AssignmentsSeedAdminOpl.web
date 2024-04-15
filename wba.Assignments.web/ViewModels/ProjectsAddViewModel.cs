
using System.ComponentModel.DataAnnotations;
using wba.Assignments.core.entities;

namespace wba.Assignments.web.ViewModels
{
    public class ProjectsAddViewModel : BaseEntity
    {
        //with dataAnnotation

        // public int Id { get; set; }
        [Required(ErrorMessage = "Naam Verplicht")]
        [Display(Name="Projectnaam")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Omschrijving Verplicht")]
        [Display(Name = "Projectomschrijving")]
        public string Description { get; set; }

        //can't be in the past
        [Required(ErrorMessage = "Startdatum Verplicht")]
        [Display(Name = "Project-Start")]
        public DateTime StartDate { get; set; }
        //can't be in the past
        //can't be before StartDate
        [Required(ErrorMessage = "Einddatum Verplicht")]
        [Display(Name = "Project-Eind")]
        public DateTime EndDate { get; set; }

    }
}
