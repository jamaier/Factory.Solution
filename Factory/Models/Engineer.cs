using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "You Must Enter A Name")]
    public string Name { get; set; }
    public string Details { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "The Engineer Must Have A License For Service Purposes")]
    public string LicenseType { get; set; }
    public DateTime HireDate { get; set; }
    public int MachineId { get; set; }
    public Machine Machine { get; set; }
    public List<EngineerMachine> JoinMachine { get; }
    
  }
}