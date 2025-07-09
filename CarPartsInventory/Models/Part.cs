namespace CarPartsInventory.Models;

public class Part
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public int Quantity { get; set; }
}