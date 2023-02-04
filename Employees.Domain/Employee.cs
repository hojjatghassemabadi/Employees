using Employees.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Domain
{
    public class Employee:BaseEntity
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Status { get; set; } = true;
    }
}
