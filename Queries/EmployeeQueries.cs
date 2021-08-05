using System;
using CQRS_Csharp.Repositories;
using CQRS_Csharp.DTO;

namespace CQRS_Csharp.Queries
{
    public class EmployeeQueries
    {
        private readonly IEmployeeQueriesRepository _repository;
        public EmployeeQueries(IEmployeeQueriesRepository repository)
        {
            this._repository = repository;
        }

        public EmployeeDTO FindByID(int employeeID)
        {
            var emp = this._repository.GetByID(employeeID);
            return new EmployeeDTO()
            {
                Id = emp.Id,
                FullName = string.Format("{0} {1}", emp.FirstName, emp.LastName),
                Address = string.Format("{0} {1} {2}", emp.Street, emp.City, emp.PostalCode),
                Age = Convert.ToInt32(Math.Abs(((DateTime.Now - emp.BirthDate).TotalDays) / 365)) - 1
            };
        }
    }

}