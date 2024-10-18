namespace GoatInventory.Models;

public partial class Pedigree
{
    public long Id { get; set; }

    public long? GoatId { get; set; }

    public string? Dam { get; set; }

    public string? Dd { get; set; }

    public string? Ds { get; set; }

    public string? Sire { get; set; }

    public string? Sd { get; set; }

    public string? Ss { get; set; }
}
