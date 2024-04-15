using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using wba.Assignments.core.entities;
using wba.Assignments.web.Data;
using wba.Assignments.web.ViewModels;

namespace wba.Assignments.web.Controllers
{

    public class EmployeesController : Controller
    {

        AssignmentDBContext _assignmentDBContext;

        public EmployeesController(AssignmentDBContext assignmentDBContext)
        {
            _assignmentDBContext = assignmentDBContext;

        }

        public IActionResult Index()
        {
            var employees = _assignmentDBContext.Employees.ToList();


            EmployeeIndexViewModel employeeIndexviewModel = new EmployeeIndexViewModel
            {
                Employees = employees.Select(e => new EmployeeDetailViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Department = e.Department,
                    Position = e.Position
                }).ToList(),
            };

            return View(employeeIndexviewModel);

        }

        public IActionResult Details(int id)
        {
            //aanpassing met de lijst van de projecten
            //get the employee with the AssignedProjects

            var employee = _assignmentDBContext.Employees
                  .Include(e => e.AssignedProjects)
                .FirstOrDefault(e => e.Id == id);

            //Instance employeeDetailViewModel

            EmployeeDetailViewModel employeeDetailviewModel = new EmployeeDetailViewModel
            {
                Id = employee.Id,
                Name = employee.Name,
                Department = employee.Department,
                Position = employee.Position,
                //list of assigned projects

                AssignedProjects = employee.AssignedProjects.Select(
                    e => new ProjectsDetailViewModel
                    {
                        Name = e.Name,
                        Description = e.Description,
                        StartDate = e.StartDate
                    }).ToList()

            };

            return View(employeeDetailviewModel);

        }

        //Add new Employee

        [HttpGet]
        public IActionResult Add()
        {
            EmployeeAddViewModel employeeAddViewModel = new EmployeeAddViewModel();

            return View(employeeAddViewModel);

        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public IActionResult Add(EmployeeAddViewModel employeeAddViewModel)
        {

            Employee employee = new Employee
            {
                Created = DateTime.Today.ToUniversalTime(),
                Name = employeeAddViewModel.Name,
                Department = employeeAddViewModel.Department,
                Position = employeeAddViewModel.Position

            };

            _assignmentDBContext.Employees.Add(employee);
            _assignmentDBContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            //fetch the to delete empoyee

            Employee employee = _assignmentDBContext.Employees
                .FirstOrDefault(e => e.Id == id);

            //Remove this object from the DBcontext
            _assignmentDBContext.Employees.Remove(employee);
            //update the database with the new dbContext changes
            _assignmentDBContext.SaveChanges();

            return RedirectToAction("Index");
        }

        //Update Selected Employee

        [HttpGet]
        public IActionResult Update(int id)
        {
            //fetch Employee
            //needed to fill in the inputs of the from (GET)


            var employee = _assignmentDBContext.Employees
               .FirstOrDefault(e => e.Id == id);

            //map this to the viewmodel

            EmployeeUpdateViewModel employeeUpdateViewModel = new EmployeeUpdateViewModel
            {
                Id = employee.Id,
                Name = employee.Name,
                Department = employee.Department,
                Position = employee.Position
            };

            //give the viemodel to the view

            return View(employeeUpdateViewModel);

        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        //retreive the data from the filled in viewmodel (HTTGET)
        public IActionResult Update(EmployeeUpdateViewModel employeeUpdateViewModel)
        {
            //department en position update
            var updateEmployee = _assignmentDBContext.Employees
                 .FirstOrDefault(e => e.Id == employeeUpdateViewModel.Id);

            updateEmployee.Department = employeeUpdateViewModel.Department;
            updateEmployee.Position = employeeUpdateViewModel.Position;

            _assignmentDBContext.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
