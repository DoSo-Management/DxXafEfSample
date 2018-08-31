using System.Collections.Generic;
using System.Linq;
using MySolution.D2.Data;
using MySolution.Module.D2;

//using Employee = MySolution.D2.Data.Employee;


namespace MySolution.Service
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ServiceDbContext _context;

        public EmployeeRepository(ServiceDbContext context)
        {
            _context = context;
        }

        public Employee AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return _context.Employees.SingleOrDefault(i => i.Id == employee.Id);
        }

        public void DeleteEmployee(int Id)
        {
            var employee = _context.Employees.SingleOrDefault(i => i.Id == Id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }

        public Employee EditEmployee(Employee employee)
        {
            var originalEmployee = _context.Employees.SingleOrDefault(i => i.Id == employee.Id);
            if (originalEmployee != null)
            {
                _context.Entry(originalEmployee).CurrentValues.SetValues(employee);
                _context.SaveChanges();
            }

            return _context.Employees.SingleOrDefault(i => i.Id == originalEmployee.Id);
        }

        public Employee GetEmployee(int Id)
        {
            return _context.Employees.SingleOrDefault(i => i.Id == Id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees.AsEnumerable();
        }
    }
}
