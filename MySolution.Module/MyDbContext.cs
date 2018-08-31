using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace MySolution.Module {
    public class MyDbContext : DbContext {
        public MyDbContext(string connectionString) : base(connectionString) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Employee2> Employee2S { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<DevExpress.ExpressApp.EF.Updating.ModuleInfo> ModuleInfo { get; set; }
    }
}
