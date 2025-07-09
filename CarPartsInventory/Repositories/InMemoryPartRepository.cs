using CarPartsInventory.Models;

namespace CarPartsInventory.Repositories;

public class InMemoryPartRepository : IPartRepository
{
    private readonly List<Part> _parts = [];

    public IEnumerable<Part> GetAll() => _parts;

    public Part Add(Part part)
    {
        part.Id = Guid.NewGuid();
        _parts.Add(part);
        return part;
    }

    public bool Delete(Guid id)
    {
        var part = _parts.FirstOrDefault(p => p.Id == id);
        if (part == null) return false;
        _parts.Remove(part);
        return true;
    }
}