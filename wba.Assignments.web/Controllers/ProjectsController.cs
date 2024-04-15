using Microsoft.AspNetCore.Mvc;
using wba.Assignments.core.entities;
using wba.Assignments.web.Data;
using wba.Assignments.web.ViewModels;

namespace wba.Assignments.web.Controllers
{
    public class ProjectsController : Controller
    {
        AssignmentDBContext _assignmentDBContext;

        public ProjectsController(AssignmentDBContext assignmentDBContext)
        {
            _assignmentDBContext = assignmentDBContext;

        }
        public IActionResult Index()
        {
            var projects = _assignmentDBContext.Projects.ToList();

            ProjectsIndexViewModel projectsIndexViewModel = new ProjectsIndexViewModel
            {
                
             Projects= projects.Select(p => new ProjectsDetailViewModel
                    {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    EndDate = p.StartDate,
                    StartDate= p.EndDate
                }).ToList(),
            };

            return View(projectsIndexViewModel);

        }

        }
    }

