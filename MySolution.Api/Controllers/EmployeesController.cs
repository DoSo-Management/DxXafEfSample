using MySolution.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySolution.D2.Data;
using MySolution.Module.D2;
using MySolution.Api.Models;
using MySolution.Service.VIewModels;

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
        public IEnumerable<EmployeeViewModel> Get()
        {
            var data = _employeeRepository.GetEmployees();

            return data.Select(s => new EmployeeViewModel
            {
                Id = s.Id,
                Birthday = s.Birthday,
                FirstName = s.FirstName,
                LastName = s.LastName,
                MiddleName = s.MiddleName
                //Tasks = s.Tasks.ToList()
            });
        }

        // GET api/<controller>/5
        public EmployeeViewModel Get(int id)
        {
            var s = _employeeRepository.GetEmployee(id);
            return new EmployeeViewModel
            {
                Id = s.Id,
                Birthday = s.Birthday,
                FirstName = s.FirstName,
                LastName = s.LastName,
                MiddleName = s.MiddleName
                //Tasks = s.Tasks.ToList()
            };
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
