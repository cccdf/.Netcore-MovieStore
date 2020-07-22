using Microsoft.EntityFrameworkCore;
using MovieStore.Core.Entities;
using MovieStore.Core.RepositoryInterfaces;
using MovieStore.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Infrastructure.Repositories
{
    public class PurchaseRepository:EFRepository<Purchase>, IPurchaseRepository

    {
        public PurchaseRepository(MovieStoreDbContext dbContext):base(dbContext)
        {

        }

        public async Task<ICollection<Purchase>> GetPurchasesByUserId(int userId)
        {
            return await _dbContext.Purchases.Include(p=>p.Movie).Where(p => p.UserId == userId).ToListAsync();
        }
    }
}
