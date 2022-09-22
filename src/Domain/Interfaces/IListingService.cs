using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IListingService
    {
        Task<ListingEntity> InsertAsync(ListingEntity entity);
        Task<ListingEntity> UpdateAsync(ListingEntity entity);
        Task<bool> DeleteAsync(int id);
        Task<ListingEntity> SelectAsync(int id);
        Task<IEnumerable<ListingEntity>> SelectAsync();
        Task<bool> ExistAsync(int id);
    }
}