using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IReviewService
    {
        Task<ReviewEntity> InsertAsync(ReviewEntity entity);
        Task<ReviewEntity> UpdateAsync(ReviewEntity entity);
        Task<bool> DeleteAsync(int id);
        Task<ReviewEntity> SelectAsync(int id);
        Task<IEnumerable<ReviewEntity>> SelectAsync();
        Task<bool> ExistAsync(int id);
    }
}