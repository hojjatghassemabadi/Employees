using Employees.Application.Interfaces.contexts;
using Employees.Application.Services.Employees.Querieis.GetEmployees;
using Employees.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Application.Services.Employees.Commands.RegisterEmployee
{

    public class RegisterEmployeeService : IRegisterEmployeeService
    {
        public readonly IEmployeesContext _context;

        public RegisterEmployeeService(IEmployeesContext context)
        {
            _context = context;
        }

        public ResultRegisterDto Execute(RegisterEmployeeDto request)
        {
            if (request == null)
            {
                return new ResultRegisterDto
                {
                    IsSuccess = false,
                    Message = "Register was not success"
                };
            }
            var employee = new Employee
            {
                DateOfBirth = request.DateOfBrith,
                Name = request.Name
            };
            _context.Employees.AddRange(employee);
            _context.SaveChanges();
            return new ResultRegisterDto
            {
                IsSuccess = true,
                Message = "Register was Successfull"
            };
        }
    }
}
