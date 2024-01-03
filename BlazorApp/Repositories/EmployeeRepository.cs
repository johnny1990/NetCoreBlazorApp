using BlazorApp.Contracts;
using BlazorApp.Data;
using BlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly NorthwindDbContext _northwindDbContext;

        public EmployeeRepository(NorthwindDbContext northwindDbContext)
        {
            _northwindDbContext = northwindDbContext;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            if(_northwindDbContext.Employees.ToListAsync() == null)
            {
                return null;
            }
            else
            return await _northwindDbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployee(int employeeId)
        {
            return await _northwindDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeID == employeeId);
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
           // _northwindDbContext.Employees.Add(employee);
            await _northwindDbContext.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
          //  _northwindDbContext.Employees.Update(employee);
            await _northwindDbContext.SaveChangesAsync();
            return employee;
        }

        public async Task DeleteEmployee(int employeeId)
        {
            var employeeToDelete = await _northwindDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeID == employeeId);
            if (employeeToDelete != null)
            {
                _northwindDbContext.Employees.Remove(employeeToDelete);
                await _northwindDbContext.SaveChangesAsync();
            }
        }
    }
}
