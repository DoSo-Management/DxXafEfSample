namespace MySolution.D2.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using MySolution.Module.D2;

    public partial class ServiceDbContext : DbContext
    {
        public ServiceDbContext()
            : base("name=Model4")
        {
        }

        public ServiceDbContext(string nameOrConnectionString) : base(nameOrConnectionString) { }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>()
            //.HasMany(e => e.Tasks)
            //.WithOptional(e => e.Employee)
            //.HasForeignKey(e => e.AssignedTo_Id);
        }
    }
}
