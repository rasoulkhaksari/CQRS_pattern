using System;
namespace CQRS_Csharp.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}