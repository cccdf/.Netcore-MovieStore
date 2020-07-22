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
    public class UserRepository : EFRepository<User>, IUserRepository
    {
        public UserRepository(MovieStoreDbContext dbContext):base(dbContext)
        {

        }

        public async override Task<User> GetByIdAsync(int id)
        {
            return await _dbContext.Users.Include(u=>u.Purchases).Where(u=>u.Id == id).FirstOrDefaultAsync();
        }
        public async Task<User> GetUserByEmail(string email)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u=>u.Email == email);
        }
    }
}
