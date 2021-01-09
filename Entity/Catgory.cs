using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AptechMVCProject.Entity
{
  public class Catgory
  {
    public Catgory()
    {
    }
    [Key]
    public string CatId { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
  }
}
