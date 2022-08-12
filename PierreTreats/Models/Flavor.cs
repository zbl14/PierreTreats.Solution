using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PierreTreats.Models
{
  public class Flavor
  {

    public Flavor()
    {
      this.TreatFlavors = new HashSet<TreatFlavor>();
    }

    public int FlavorId { get; set; }
    [Required]
    public string Name { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<TreatFlavor> TreatFlavors { get; }
  }
}