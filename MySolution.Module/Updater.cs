using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp;
using MySolution.Module.D2;

namespace MySolution.Module {
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            if (ObjectSpace.GetObjects<Employee>().Count == 0) {
                var employee = ObjectSpace.CreateObject<Employee>();
                employee.FirstName = "Mary";
                employee.LastName = "Tellitson";
                var task = ObjectSpace.CreateObject<Task>();
                task.Subject = "Check reports";
                task.AssignedTo = employee;
            }
            ObjectSpace.CommitChanges();
        }
    }
}
