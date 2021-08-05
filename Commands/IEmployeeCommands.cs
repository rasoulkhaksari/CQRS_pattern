using CQRS_Csharp.Models;
namespace CQRS_Csharp.Commands
{
    public interface IEmployeeCommands
    {
        void SaveEmployeeData(Employee employee);
    }

}