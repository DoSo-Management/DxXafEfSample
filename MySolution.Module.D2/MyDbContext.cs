using System.Data.Entity;

namespace MySolution.Module.D2 {
    public class MyDbContextN : DbContext {
        public MyDbContextN(string connectionString) : base(connectionString) { }
        public DbSet<Employee> Employees { get; set; }
        //public DbSet<Employee2> Employee2S { get; set; }
        public DbSet<Task> Tasks { get; set; }
        //public DbSet<DevExpress.ExpressApp.EF.Updating.ModuleInfo> ModuleInfo { get; set; }
    }
}
