using System;
using CQRS_Csharp.Models;

namespace CQRS_Csharp.Repositories
{

    public class EmployeeQueriesRepository : IEmployeeQueriesRepository
    {
        public Employee GetByID(int employeeID)
        {
            // Get the employee record from a data store  
            // Below is for demo purposes only
            return new Employee()
            {
                Id = 100,
                FirstName = "John",
                LastName = "Smith",
                BirthDate = new DateTime(1990, 1, 4),
                Street = "100 Boston Street",
                City = "Boston",
                PostalCode = "52005"
            };
        }
    }

}