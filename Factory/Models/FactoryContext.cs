using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public virtual DbSet<Engineer> Engineers { get; set; }
    public DbSet<Machine> Machines { get; set; }
    public DbSet<EngineerMachine> EngineerMachines { get; set; }
    // public DbSet<Repair> Repairs { get; set; }
    // public DbSet<MachineRepair> MachineRepair { get; set; }

    public FactoryContext(DbContextOptions options) : base(options) { }
  }
}