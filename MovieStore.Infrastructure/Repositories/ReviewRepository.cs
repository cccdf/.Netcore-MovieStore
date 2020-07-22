using MovieStore.Core.Entities;
using MovieStore.Core.RepositoryInterfaces;
using MovieStore.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Infrastructure.Repositories
{
    public class ReviewRepository:EFRepository<Review>, IReviewRepository
    {
        public ReviewRepository(MovieStoreDbContext dbContext) : base(dbContext)
        {

        }
    }
}
