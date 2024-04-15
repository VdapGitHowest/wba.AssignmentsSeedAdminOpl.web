using System.ComponentModel.DataAnnotations;
using wba.Assignments.core.entities;

namespace wba.Assignments.web.ViewModels
{
    public class ProjectsIndexViewModel 
    {
        public ICollection<ProjectsDetailViewModel> Projects { get; set; }

    }
}
