namespace CarPartsInventory.Models;

public class Part
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Manufacturer { get; set; } = string.Empty;
    public int Quantity { get; set; }
}