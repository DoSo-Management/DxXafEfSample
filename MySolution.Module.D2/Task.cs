using System.ComponentModel;
//using DevExpress.Persistent.Base;

//using DevExpress.ExpressApp.DC;

namespace MySolution.Module.D2 {
    //[DefaultClassOptions, ImageName("BO_Task")]
    public class Task {
        [Browsable(false)]
        public int Id { get; protected set; }
        public string Subject { get; set; }
        //[FieldSize(FieldSizeAttribute.Unlimited)]
        public string Description { get; set; }
        public virtual Employee AssignedTo { get; set; }
    }
}
