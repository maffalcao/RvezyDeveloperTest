using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IListingFromCsvService
    {
        public Listing GetById(int id);
        public IList<Listing> GetPaged(string? propertyType = null, int pageNumber = 1);
    }
}