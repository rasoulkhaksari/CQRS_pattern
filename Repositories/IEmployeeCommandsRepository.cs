using CQRS_Csharp.Models;

namespace CQRS_Csharp.Repositories
{
    public interface IEmployeeCommandsRepository
    {
        void SaveEmployee(Employee employee);
    }
    
}