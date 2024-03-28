namespace wba.Assignments.web.ViewModels
{
    public class EmployeeDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
      public ICollection<ProjectsDetailViewModel> AssignedProjects { get; set; }

    }
}
