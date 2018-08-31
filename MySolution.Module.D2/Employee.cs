using System;
using System.Collections.Generic;
using System.ComponentModel;
//using DevExpress.Persistent.Base;

namespace MySolution.Module.D2 {
    //[DefaultClassOptions, ImageName("BO_Employee")]
    public class Employee {
        [Browsable(false)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? Birthday { get; set; }
        //public virtual List<Task> Tasks { get; set; }
    }
}
