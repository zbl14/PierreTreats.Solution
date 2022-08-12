using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PierreTreats.Models
{
  public class Treat
  {
    public Treat()
    {
      this.TreatFlavors = new HashSet<TreatFlavor>();
    }
    
    public int TreatId { get; set; }
    [Required]
    public string Name { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<TreatFlavor> TreatFlavors { get;}
  }
}