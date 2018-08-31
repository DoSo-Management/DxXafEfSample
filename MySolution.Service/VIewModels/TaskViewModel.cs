using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySolution.Api.Models
{
    public class TaskViewModel
    {
        public int Id { get; protected set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public int AssignedTo { get; set; }
    }
}