namespace GoatInventory.Models;

public partial class Breeding
{
    public long id;

    public long? goatId;

    public string? buck;

    public DateTime? date;

    public DateTime? dueDate;

    public string? notes;

    public bool? complete;

    public bool? successful;
}