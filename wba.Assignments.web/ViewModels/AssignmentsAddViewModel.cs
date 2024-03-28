using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace wba.Assignments.web.ViewModels
{
    public class AssignmentsAddViewModel
    {
        //list of Projects
        [Required]
        [Display(Name = "Project")]
        public int SelectedProjectId { get; set; }
        public List<SelectListItem> Projects { get; set; }

        //list of Employees (multiple choice)
        [Required]
        [Display(Name = "Employees")]
        public List<int> SelectedEmployees { get; set; }
        public List<SelectListItem> Employees { get; set; }


    }
}
