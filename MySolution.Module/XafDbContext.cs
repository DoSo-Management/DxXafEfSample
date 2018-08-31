using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using MySolution.D2.Data;
using MySolution.Module.D2;
using Task = MySolution.Module.D2.Task;

namespace MySolution.Module {
    public class XafDbContext : ServiceDbContext
    {
        public XafDbContext(string connectionString) : base(connectionString) { }
        //public DbSet<Employee> Employees { get; set; }
        public DbSet<Employee2> Employee2S { get; set; }
        //public DbSet<Task> Tasks { get; set; }
        public DbSet<DevExpress.ExpressApp.EF.Updating.ModuleInfo> ModuleInfo { get; set; }
    }
}
