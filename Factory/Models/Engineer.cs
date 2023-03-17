using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "You Must Enter A Name")]
    public string EngineerName { get; set; }
    public DateTime HireDate { get; set; }
    public List<EngineerMachine> JoinMachines { get; }
    
  }
}