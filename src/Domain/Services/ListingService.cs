using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Services
{
    public class ListingService : IListingService
    {
        private IRepository<ListingEntity> _repository;

        public ListingService(IRepository<ListingEntity> repository) =>
            _repository = repository;


        public async Task<bool> DeleteAsync(int id) =>
            await _repository.DeleteAsync(id);

        public async Task<bool> ExistAsync(int id) =>
            await _repository.ExistAsync(id);

        public async Task<ListingEntity> InsertAsync(ListingEntity entity) =>
            await _repository.InsertAsync(entity);

        public async Task<ListingEntity> SelectAsync(int id) =>
            await _repository.SelectAsync(id);

        public async Task<IEnumerable<ListingEntity>> SelectAsync() =>
            await _repository.SelectAsync();

        public async Task<ListingEntity> UpdateAsync(ListingEntity entity) =>
            await _repository.UpdateAsync(entity);
    }
}