using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IListingFromCsvService
    {
        public ListingEntity GetById(int id);
        public IList<ListingEntity> GetPaged(string? propertyType = null, int pageNumber = 1);
    }
}