using Microsoft.EntityFrameworkCore;
using Lozovii.University.Mevianart.Database.Interfaces;
using Lozovii.University.Mevianart.Models;

namespace Lozovii.University.Mevianart.Database.Services
{
    public class PhoneDBService : IDbEntityService<Phone>
    {
        private readonly MevianartDbContext _dbContext;
        private bool _disposed;

        public PhoneDBService(MevianartDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private async Task SaveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Phone> Create(Phone entity)
        {
            var entityFromDB = await _dbContext.Phones.AddAsync(entity);
            await SaveChanges();
            return entityFromDB.Entity;
        }

        public async Task Delete(Phone entity)
        {
            _dbContext.Phones.Remove(entity);
            await SaveChanges();
        }

        public async Task<Phone> GetById(int id)
        {
            var phone = await _dbContext.Phones.FindAsync(id);
            if (phone == null)
            {
                throw new ArgumentException("Phone not found", nameof(id));
            }
            return phone;
        }


        public async Task<Phone> Update(Phone entity)
        {
            var entityFromDB = _dbContext.Phones.Update(entity);
            await SaveChanges();

            return entityFromDB.Entity;
        }

        public IQueryable<Phone> GetAll()
        {
            return _dbContext.Phones;
        }

        public void Dispose()
        {
            if (_disposed)
                return;

            _dbContext.Dispose();
            _disposed = true;
        }

    }
}
