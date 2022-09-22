using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ICalendarService
    {
        Task<CalendarEntity> InsertAsync(CalendarEntity entity);
        Task<CalendarEntity> UpdateAsync(CalendarEntity entity);
        Task<bool> DeleteAsync(int id);
        Task<CalendarEntity> SelectAsync(int id);
        Task<IEnumerable<CalendarEntity>> SelectAsync();
        Task<bool> ExistAsync(int id);
    }
}