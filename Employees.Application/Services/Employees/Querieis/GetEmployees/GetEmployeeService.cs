using Employees.Application.Interfaces.contexts;
using Employees.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Application.Services.Employees.Querieis.GetEmployees
{
    public class GetEmployeeService : IGetEmployeeService
    {
        private readonly IEmployeesContext _context;

        public GetEmployeeService(IEmployeesContext context)
        {
            _context = context;
        }

        public ResultDto Execute()
        {
            var result = _context.Employees.Where(e=>e.Status==true);
            if (result != null)
            {
                return new ResultDto
                {

                    RowCounts = result.Count(),
                    Employees = result.Select(e => new GetEmployeesDto { DateOfBrith = e.DateOfBirth, Name = e.Name }).ToList()
                };
            }
            else
            {
                throw new NullReferenceException();
            }
            
        }
    }
    
    
}
