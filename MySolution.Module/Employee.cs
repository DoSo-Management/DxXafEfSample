using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Persistent.Base;
using System.ComponentModel;

namespace MySolution.Module {
    [DefaultClassOptions, ImageName("BO_Employee")]
    public class Employee {
        [Browsable(false)]
        public int Id { get; protected set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public virtual List<Task> Tasks { get; set; }
    }
}
