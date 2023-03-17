using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "The Machine Must Have A Label")]
    public string MachineLabel { get; set; }
    public string MachineDescription { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "The Machine Must Have A License For Service Purposes")]
    public int LicenseType { get; set; }
    public Engineer Engineer { get; set; }
    public Repair Repair { get; set; }
    public List<EngineerMachine> JoinMachines { get; set; }
    public List<MachineRepair> JoinRepairs { get; }

  }
}