using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wba.Assignments.core.entities
{
    public class Employee:BaseEntity
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }

        public ICollection<Project> AssignedProjects { get; set; }


    }
}
