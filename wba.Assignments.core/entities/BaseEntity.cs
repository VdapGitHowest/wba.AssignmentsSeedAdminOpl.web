using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wba.Assignments.core.entities
{
    public class BaseEntity
    {
        public DateTime Created { get; set; }
        public DateTime? Deleted { get; set; }

    }
}
