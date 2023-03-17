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
    public List<EngineerMachine> JoinMachines { get; set; }

  }
}