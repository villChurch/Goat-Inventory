using System;
using System.Collections.Generic;

namespace GoatInventory.Models;

public partial class Goat
{
    public long Id { get; set; }

    public string? BarnName { get; set; }

    public string? FullName { get; set; }

    public string? Sex { get; set; }

    public DateTime? DateOfBirth { get; set; }
    
    public DateTime? DateOfDeath { get; set; }
    
    public DateTime? DateOfSale { get; set; }

    public string? BreedType { get; set; }

    public bool? Sold { get; set; }

    public bool? Alive { get; set; }

    public string? Notes { get; set; }

    public int? PriceOfSale { get; set; }
    
    public string? ImageLink { get; set; }
}
