using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using DevExpress.Persistent.Base;
using System.ComponentModel;
//using DevExpress.ExpressApp.DC;

namespace MySolution.Module {
    //[DefaultClassOptions, ImageName("BO_Task")]
    public class Task {
        [Browsable(false)]
        public int Id { get; protected set; }
        public string Subject { get; set; }
        //[FieldSize(FieldSizeAttribute.Unlimited)]
        public String Description { get; set; }
        public virtual Employee AssignedTo { get; set; }
    }
}
