namespace wba.Assignments.web.ViewModels
{
    public class ProjectsDetailViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<EmployeeDetailViewModel> AssignedEmployees { get; set; }


    }
}
