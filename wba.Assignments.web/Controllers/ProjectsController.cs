using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


        public IActionResult Details(int id)
        {
          
            var project = _assignmentDBContext.Projects
                  .Include(p => p.AssignedEmployees)
                .FirstOrDefault(p => p.Id == id);


           ProjectsDetailViewModel projectDetailviewModel = new ProjectsDetailViewModel
           {
                Id = project.Id,
                Name = project.Name,
                Description = project.Description,
                StartDate = project.StartDate,
                EndDate= project.EndDate,
                //list of assigned projects

                AssignedEmployees = project.AssignedEmployees.Select(
                    e => new EmployeeDetailViewModel
                    {
                        Name = e.Name,
                        Department = e.Department,
                        Position = e.Position,
                   
                    }).ToList()

            };

            return View(projectDetailviewModel);

        }
    }
    }

