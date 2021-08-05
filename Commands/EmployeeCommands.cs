using CQRS_Csharp.Models;
using CQRS_Csharp.Repositories;

namespace CQRS_Csharp.Commands
{
    public class EmployeeCommands : IEmployeeCommands
    {
        private readonly IEmployeeCommandsRepository _repository;
        public EmployeeCommands(IEmployeeCommandsRepository repository)
        {
            this._repository = repository;
        }

        public void SaveEmployeeData(Employee employee)
        {
            this._repository.SaveEmployee(employee);
        }
    }
}