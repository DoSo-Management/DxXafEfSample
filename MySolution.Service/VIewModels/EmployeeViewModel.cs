using MySolution.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySolution.Service.VIewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? Birthday { get; set; }
        public List<TaskViewModel> Tasks { get; set; }
    }
}