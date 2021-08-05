using System;
using CQRS_Csharp.Commands;
using CQRS_Csharp.Queries;
using CQRS_Csharp.Repositories;

namespace CQRS_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeCommand = new EmployeeCommands(new EmployeeCommandsRepository());
            employeeCommand.SaveEmployeeData(
                new Models.Employee
                {
                    Id = 200,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Street = "150 Toronto Street",
                    City = "Toronto",
                    PostalCode = "31005",
                    BirthDate = new DateTime(2002, 3, 4)
                }
            );
            Console.WriteLine("Employee data stored");
            var employeeQuery = new EmployeeQueries(new EmployeeQueriesRepository());
            var employee = employeeQuery.FindByID(100);
            Console.WriteLine($"Employee ID:{employee.Id}, Name:{employee.FullName}, Address:{employee.Address}, Age:{employee.Age}");
            Console.ReadKey();
        }
    }
}
