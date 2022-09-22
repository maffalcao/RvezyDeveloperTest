using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IListingFromCsv
    {
        IList<ListingEntity> GetPaged(string? propertyType = null, int pageSize = 1);
        ListingEntity? GetById(int id);
    }
}