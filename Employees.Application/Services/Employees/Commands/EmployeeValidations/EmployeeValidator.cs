using Employees.Application.Services.Employees.Commands.RegisterEmployee;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Application.Services.Employees.Commands.EmployeeValidations
{
    public class EmployeeValidator: AbstractValidator<RegisterEmployeeDto>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Please Enter Name");
            RuleFor(x => x.DateOfBrith).NotEmpty().NotNull().WithMessage(" Please Enter Date of Brith");
        }
        
    }
}
