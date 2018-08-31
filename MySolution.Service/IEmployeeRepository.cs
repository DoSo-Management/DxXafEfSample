using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySolution.D2.Data;
using MySolution.Module;
using MySolution.Module.D2;

namespace MySolution.Service
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();

        Employee GetEmployee(int Id);

        Employee EditEmployee(Employee employee);

        Employee AddEmployee(Employee employee);

        void DeleteEmployee(int Id);
    }
}
