using EmployeeManagement.DataLayer;
using EmployeeManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.BusinessLayer.Services.Repository
{

    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _dbContext;

        public EmployeeRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            // Hardcoded employee details
            var employees = new List<Employee>
            {
                new Employee { EmployeeID = 1, EmployeeName = "John Doe", Salary = 50000 },
                new Employee { EmployeeID = 2, EmployeeName = "Jane Smith", Salary = 60000 },
                // Add more employees as needed
            };

            return employees;
        }
    }
}
