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

        public Listing GetById(int id) =>
            _service.GetById(id);

        public IList<Listing> GetPaged(string? propertyType = null, int pageNumber = 1) =>
            _service.GetPaged(propertyType, pageNumber);
    }
}