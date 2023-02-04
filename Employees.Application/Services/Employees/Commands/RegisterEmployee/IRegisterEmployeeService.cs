namespace Employees.Application.Services.Employees.Commands.RegisterEmployee
{
    public interface IRegisterEmployeeService
    {
        ResultRegisterDto Execute(RegisterEmployeeDto request);
    }
}
