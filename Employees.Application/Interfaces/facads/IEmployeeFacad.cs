using Employees.Application.Services.Employees.Commands.RegisterEmployee;
using Employees.Application.Services.Employees.Querieis.GetEmployees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Application.Interfaces.facads
{
    public interface IEmployeeFacad
    {
        RegisterEmployeeService RegisterEmployeeService { get; }
        GetEmployeeService GetEmployeeService { get; }

    }
}
