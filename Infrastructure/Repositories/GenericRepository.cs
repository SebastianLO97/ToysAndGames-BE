using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;

namespace Infrastructure.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> dbContext;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            dbContext = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return dbContext.ToList();
        }

        public T GetById(object id)
        {
            return dbContext.Find(id);
        }

        public T Create(T obj)
        {
            dbContext.Add(obj);
            return obj;
        }

        public T Update(T obj)
        {
            dbContext.Update(obj);
            return obj;
        }

        public void Delete(object id)
        {
            T existing = dbContext.Find(id);
            dbContext.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}