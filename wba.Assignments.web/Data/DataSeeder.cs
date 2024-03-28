using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using wba.Assignments.core.entities;

namespace wba.Assignments.web.Data
{
    public class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            //seeding data here

            //Employees
            var employees = new Employee[]
{
    new Employee{Id=1,Name="Peter Van Damme", Position="Developer",Department="IT", Created=DateTime.UtcNow },
        new Employee{Id=2,Name="Kris Meert", Position="Analyst",Department="IT", Created=DateTime.UtcNow },
            new Employee{Id=3,Name="Ann Verboost", Position="AI-specialist",Department="IT", Created=DateTime.UtcNow }
    ,    new Employee{Id=4,Name="Rudy Minneboom", Position="DPO",Department="IT", Created=DateTime.UtcNow }

};

            //Projects

            var projects = new Project[]
{
    new Project
    {
        Id = 1,
        Name = "Website Redesign",
        Description = "Redesigning the company website to improve user experience and add new features.",
        StartDate = new DateTime(2024, 4, 1),
        EndDate = new DateTime(2024, 9, 30)
    },
    new Project
    {
        Id = 2,
        Name = "Product Launch",
        Description = "Launching a new product in the market with extensive marketing campaigns.",
        StartDate = new DateTime(2024, 3, 15),
        EndDate = new DateTime(2024, 7, 31)
    },
    new Project
    {
        Id = 3,
        Name = "Internal Training Program",
        Description = "Implementing a training program for employees to enhance skills and productivity.",
        StartDate = new DateTime(2024, 5, 1),
        EndDate = new DateTime(2024, 11, 30)
    },
    // Add more projects as needed
};

            //EmployeeProject
            var employeeProjects = new[]
{
    new {AssignedEmployeesId=1,AssignedProjectsId=1 },
    new {AssignedEmployeesId=1,AssignedProjectsId=2 },
    new {AssignedEmployeesId=4,AssignedProjectsId=1 },
    new {AssignedEmployeesId=3,AssignedProjectsId=2 },
    //this gives an error
      new {AssignedEmployeesId=3,AssignedProjectsId=4 }

            };


            modelBuilder.Entity<Employee>().HasData(employees);
            modelBuilder.Entity<Project>().HasData(projects);
            modelBuilder.Entity($"{nameof(Employee)}{nameof(Project)}").HasData(employeeProjects);


        }
    }
}
