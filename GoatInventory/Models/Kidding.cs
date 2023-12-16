using System;
using System.Collections.Generic;

namespace GoatInventory.Models;

public partial class Kidding
{
    public long Id { get; set; }

    public long? GoatId { get; set; }

    public string? Sire { get; set; }

    public DateTime? Date { get; set; }

    public string? Notes { get; set; }
    
    public int does { get; set; }
    
    public int bucks { get; set; }
}
