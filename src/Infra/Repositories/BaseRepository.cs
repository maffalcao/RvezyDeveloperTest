using Domain.Entities;
using Domain.Interfaces;
using Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly MyContext _context;
        protected DbSet<T> _dataSet;
        public BaseRepository(MyContext context)
        {
            _context = context;
            _dataSet = context.Set<T>();
        }
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var result = await _dataSet.SingleOrDefaultAsync(p => p.Id.Equals(id));

                if (result == null)
                    return false;

                _dataSet.Remove(result);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public async Task<T> InsertAsync(T item)
        {
            try
            {
                _dataSet.Add(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public async Task<T> UpdateAsync(T item)
        {
            try
            {
                var result = await _dataSet.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));
                if (result == null)
                    return null;


                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();


            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public async Task<T> SelectAsync(int id)
        {
            try
            {
                var result = await _dataSet.SingleOrDefaultAsync(p => p.Id.Equals(id));
                return result;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<T>> SelectAsync()
        {
            return await _dataSet.ToListAsync();
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _dataSet.AnyAsync(p => p.Id == id);
        }

    }
}