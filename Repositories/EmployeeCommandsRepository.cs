using CQRS_Csharp.Models;

namespace CQRS_Csharp.Repositories
{
    public class EmployeeCommandsRepository : IEmployeeCommandsRepository
    {
        public void SaveEmployee(Employee employee)
        {
            // Persist the employee record in a data store
            System.Console.WriteLine("Persist the employee record in a data store");
        }
    }

}