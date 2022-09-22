using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Services
{
    public class ListingFromCsvService : IListingFromCsvService
    {
        private readonly IListingFromCsv _service;

        public ListingFromCsvService(IListingFromCsv service)
        {
            _service = service;
        }

        public ListingEntity GetById(int id) =>
            _service.GetById(id);

        public IList<ListingEntity> GetPaged(string? propertyType = null, int pageNumber = 1) =>
            _service.GetPaged(propertyType, pageNumber);
    }
}