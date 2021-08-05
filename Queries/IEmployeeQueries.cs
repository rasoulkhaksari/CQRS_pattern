using CQRS_Csharp.DTO;
namespace CQRS_Csharp.Queries
{
    public interface IEmployeeQueries
    {
        EmployeeDTO FindByID(int employeeID);
    }

}