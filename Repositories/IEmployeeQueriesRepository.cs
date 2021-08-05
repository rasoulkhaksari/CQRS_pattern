using CQRS_Csharp.Models;

namespace CQRS_Csharp.Repositories
{
    public interface IEmployeeQueriesRepository
    {
        Employee GetByID(int employeeID);
    }

}