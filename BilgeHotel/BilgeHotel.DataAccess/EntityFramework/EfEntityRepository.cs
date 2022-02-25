using BilgeHotel.DataAccess.Abstract;
using BilgeHotel.DataAccess.EntityFramework.Context;
using BilgeHotel.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.DataAccess.EntityFramework
{
    public class EfEntityRepository<T> : IRepository<T> where T :class,IEntity, new()
    {
        private readonly BilgeHotelDenemeContext _context;
        private readonly DbSet<T> _dbSet;
        public EfEntityRepository(BilgeHotelDenemeContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task<bool> Delete(T entity)
        {
            try
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _dbSet.SingleOrDefault(filter);
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return filter==null?_dbSet.ToList():_dbSet.Where(filter).ToList();
        }

        public async Task<bool> Insert(T entity)
        {
           
            try
            {
                _dbSet.Add(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {

                return false;
            }
        }

        public async Task<bool> Update(T entity)
        {
            try
            {
                _dbSet.Update(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
