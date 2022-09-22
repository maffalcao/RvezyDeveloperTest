using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Services
{
    public class ReviewService : IReviewService
    {
        private IRepository<ReviewEntity> _repository;

        public ReviewService(IRepository<ReviewEntity> repository) =>
            _repository = repository;


        public async Task<bool> DeleteAsync(int id) =>
            await _repository.DeleteAsync(id);

        public async Task<bool> ExistAsync(int id) =>
            await _repository.ExistAsync(id);

        public async Task<ReviewEntity> InsertAsync(ReviewEntity entity) =>
            await _repository.InsertAsync(entity);

        public async Task<ReviewEntity> SelectAsync(int id) =>
            await _repository.SelectAsync(id);

        public async Task<IEnumerable<ReviewEntity>> SelectAsync() =>
            await _repository.SelectAsync();

        public async Task<ReviewEntity> UpdateAsync(ReviewEntity entity) =>
            await _repository.UpdateAsync(entity);
    }
}