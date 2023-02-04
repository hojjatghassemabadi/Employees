using Employees.Application.Interfaces.contexts;
using Employees.Application.Interfaces.facads;
using Employees.Application.Services.Employees.Commands.RegisterEmployee;
using Employees.Application.Services.Employees.Querieis.GetEmployees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Application.Services.Employees.FacadPattern
{
    public class FacadEmployees : IEmployeeFacad
    {
        private readonly IEmployeesContext _context;

        public FacadEmployees(IEmployeesContext context)
        {
            _context = context;
           
        }

        private RegisterEmployeeService _registerEmployeeService;
        public RegisterEmployeeService RegisterEmployeeService
        {
            get { return _registerEmployeeService = _registerEmployeeService ?? new RegisterEmployeeService(_context); }
        }
        private GetEmployeeService _getEmployeeService;
        public GetEmployeeService GetEmployeeService
        {
            get { return _getEmployeeService = _getEmployeeService ?? new GetEmployeeService(_context); }
        }
    }
}
