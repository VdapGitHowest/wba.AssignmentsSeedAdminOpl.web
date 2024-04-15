using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
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

        //Add new project
        //Add new Employee

        [HttpGet]
        public IActionResult Add()
        {
            ProjectsAddViewModel projectsAddViewModel = new ProjectsAddViewModel();

            projectsAddViewModel.StartDate = DateTime.Today;
            projectsAddViewModel.EndDate = DateTime.Today.AddDays(1);

            projectsAddViewModel.Created = DateTime.Today;
            
            return View(projectsAddViewModel);

        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public IActionResult Add(ProjectsAddViewModel projectsAddViewModel)
        {
            if(ModelState.IsValid)
            {
                if(projectsAddViewModel.StartDate>projectsAddViewModel.EndDate ||
                    projectsAddViewModel.StartDate<DateTime.Today) {

                    ModelState.AddModelError("", "Dates must be in the future");
                }
                else
                {

                

            Project project = new Project
            {
                Created = DateTime.Today.ToUniversalTime(),
                Description = projectsAddViewModel.Description,
                Name = projectsAddViewModel.Name,
                StartDate = projectsAddViewModel.StartDate,
                EndDate = projectsAddViewModel.EndDate,

            };

            _assignmentDBContext.Projects.Add(project);
            _assignmentDBContext.SaveChanges();

            return RedirectToAction("Index");
        }
            }
            return View();
        }

        //Delete selected project
        public IActionResult Delete(int id)
        {
            //fetch the to delete project
            Project project = _assignmentDBContext.Projects
                .FirstOrDefault(e => e.Id == id);

            //Remove this object from the DBcontext
            _assignmentDBContext.Projects.Remove(project);
            //update the database with the new dbContext changes
            _assignmentDBContext.SaveChanges();

            return RedirectToAction("Index");
        }

        //Update Selected project



        [HttpGet]
        public IActionResult Update(int id)
        {
            //fetch project
            //needed to fill in the inputs of the from (GET)


            var project = _assignmentDBContext.Projects
               .FirstOrDefault(e => e.Id == id);

            //map this to the viewmodel

            ProjectsUpdateViewModel projectsUpdateViewModel = new ProjectsUpdateViewModel
            {
                Name = project.Name,
                Description = project.Description,
                StartDate = project.StartDate,
                EndDate=project.EndDate
            };

            //give the viemodel to the view

            return View(projectsUpdateViewModel);

        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        //retreive the data from the filled in viewmodel (HTTGET)
        public IActionResult Update(ProjectsUpdateViewModel projectUpdateViewModel)
        {

            if (ModelState.IsValid)
            {

                if (projectUpdateViewModel.StartDate > projectUpdateViewModel.EndDate ||
                    projectUpdateViewModel.StartDate < DateTime.Today)
                {

                    ModelState.AddModelError("", "Dates must be in the future");

              
                }
                else
                {

                    //department en position update
                    var updateProject = _assignmentDBContext.Projects
                         .FirstOrDefault(p => p.Id == projectUpdateViewModel.Id);

                    updateProject.Name = projectUpdateViewModel.Name;
                    updateProject.Description = projectUpdateViewModel.Description;
                    updateProject.StartDate = projectUpdateViewModel.StartDate;
                    updateProject.EndDate = projectUpdateViewModel.EndDate;

                    _assignmentDBContext.SaveChanges();

                    return RedirectToAction("Index");
                }
                
            }

             return View();
            }


            
        }

    }


