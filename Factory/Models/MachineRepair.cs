namespace Factory.Models
{
  public class MachineRepair
  {
    public int MachineRepairId { get; set; }
    public int MachineId { get; set; }
    public int RepairId { get; set; }
    public int EngineerId { get; set; }
    public Engineer Engineer { get; set; }
    public Machine Machine { get; set; }
    public Repair Repair { get; set; }
  }
}