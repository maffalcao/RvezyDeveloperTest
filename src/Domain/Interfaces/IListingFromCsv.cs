using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IListingFromCsv
    {
        IList<Listing> GetPaged(string? propertyType = null, int pageSize = 1);
        Listing? GetById(int id);
    }
}