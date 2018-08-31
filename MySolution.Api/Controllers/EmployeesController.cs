using MySolution.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySolution.D2.Data;
using MySolution.Module.D2;

namespace MySolution.Api.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // GET api/<controller>
        public IEnumerable<Employee> Get()
        {
            var data = _employeeRepository.GetEmployees();
            return data;
        }

        // GET api/<controller>/5
        public Employee Get(int id)
        {
            return _employeeRepository.GetEmployee(id);
        }

        // POST api/<controller>
        public Employee Post([FromBody]Employee value)
        {
            return _employeeRepository.AddEmployee(value);
        }

        // PUT api/<controller>/5
        public Employee Put([FromBody]Employee value)
        {
            return _employeeRepository.EditEmployee(value);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            _employeeRepository.DeleteEmployee(id);
        }
    }
}
