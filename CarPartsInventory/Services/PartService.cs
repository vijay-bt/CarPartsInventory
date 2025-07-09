using CarPartsInventory.Models;
using CarPartsInventory.Repositories;

namespace CarPartsInventory.Services;

public class PartService : IPartService
{
    private readonly IPartRepository _repo;
    public PartService(IPartRepository repo) => _repo = repo;

    public IEnumerable<Part> Search(string? name) =>
        _repo.GetAll().Where(p => string.IsNullOrEmpty(name) ||
                                  p.Name.Contains(name, StringComparison.OrdinalIgnoreCase));

    public Part Add(Part part) => _repo.Add(part);

    public bool Remove(Guid id) => _repo.Delete(id);
}