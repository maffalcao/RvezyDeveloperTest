using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Services
{
    public class CalendarService : ICalendarService
    {
        private IRepository<CalendarEntity> _repository;

        public CalendarService(IRepository<CalendarEntity> repository) =>
            _repository = repository;


        public async Task<bool> DeleteAsync(int id) =>
            await _repository.DeleteAsync(id);

        public async Task<bool> ExistAsync(int id) =>
            await _repository.ExistAsync(id);

        public async Task<CalendarEntity> InsertAsync(CalendarEntity entity) =>
            await _repository.InsertAsync(entity);

        public async Task<CalendarEntity> SelectAsync(int id) =>
            await _repository.SelectAsync(id);

        public async Task<IEnumerable<CalendarEntity>> SelectAsync() =>
            await _repository.SelectAsync();

        public async Task<CalendarEntity> UpdateAsync(CalendarEntity entity) =>
            await _repository.UpdateAsync(entity);
    }
}