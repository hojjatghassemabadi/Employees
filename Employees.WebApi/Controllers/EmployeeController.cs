using Employees.Application.Interfaces.contexts;
using Employees.Application.Interfaces.facads;
using Employees.Application.Services.Employees.Commands.RegisterEmployee;
using Employees.Application.Services.Employees.Querieis.GetEmployees;
using Microsoft.AspNetCore.Mvc;

namespace Employees.WebApi.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeFacad _employeeService;
        public EmployeeController(IEmployeeFacad employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet(Name = "GetEmployees")]
        public ResultDto Get()
        {
            var result = _employeeService.GetEmployeeService.Execute();
            return result;
        }
        [HttpPost(Name = "RegisterEmployee")]
        public ResultRegisterDto Post(RegisterEmployeeDto employee) { 
             return _employeeService.RegisterEmployeeService.Execute(employee);
        }
    }
}
