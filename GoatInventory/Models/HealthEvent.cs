namespace GoatInventory.Models;

public partial class HealthEvent
{
    public long Id { get; set; }

    public long GoatId { get; set; }

    public string? EventText { get; set; }

    public DateTime? EventDate { get; set; }
}
