using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using wba.Assignments.core.entities;
using wba.Assignments.web.Data;
using wba.Assignments.web.ViewModels;

namespace wba.Assignments.web.Controllers
{
    public class AssignmentsController : Controller
    {

        AssignmentDBContext _assignmentDBContext;

        public AssignmentsController(AssignmentDBContext assignmentDBContext)
        {
            _assignmentDBContext = assignmentDBContext;
        }

        public IActionResult Index()
        {
            return View();
        }



        //Add new Employees to the an existing project
        //list existing projects (list)
        //list existing employees (list)
        //Update the database


        [HttpGet]
        public IActionResult Add()
        {
            AssignmentsAddViewModel assignmentsAddViewModel = new AssignmentsAddViewModel();

            //list projects
            var projects = _assignmentDBContext.Projects.ToList();

            var projectList = projects.Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.Name
            }).ToList();


            //list employees
            var employees = _assignmentDBContext.Employees.ToList();

            var employeesList = employees.Select(e => new SelectListItem
            {
                Value = e.Id.ToString(),
                Text = e.Name
            }).ToList();

            //list existing projects (list)
            //list existing employees (list)

            assignmentsAddViewModel.Projects = projectList;
            assignmentsAddViewModel.Employees = employeesList;

            return View(assignmentsAddViewModel);

        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]


        public IActionResult Add(AssignmentsAddViewModel assignmentsAddViewModel)
        {

            //add the employees to the selectedProject

            // get the project

            var project = _assignmentDBContext.Projects.FirstOrDefault(p => p.Id ==
            assignmentsAddViewModel.SelectedProjectId);

            //get the selected employee IDs
            var selectedEmployeeIds = assignmentsAddViewModel.SelectedEmployees;

            //new instance of AssignedEmployees

            project.AssignedEmployees = new List<Employee>();

            // Clear existing assigned projects (if needed)
            project.AssignedEmployees.Clear();

            //loop in selectedEmployeeIds
            //define a employee with the index
            //add to the AssignedEmployeesCollection
            foreach (int id in selectedEmployeeIds)
            {
                var employee = _assignmentDBContext.Employees.Find(id);
                project.AssignedEmployees.Add(employee);
            }

            // Save changes to persist the associations in the junction table
            _assignmentDBContext.SaveChanges();

            return RedirectToAction("Index");


        }
    }
}


