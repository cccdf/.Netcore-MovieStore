using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStore.Core.Entities;

namespace MovieStore.Infrastructure.Data
{
    //install all the ef core libraries using nuget package manager
    //create a class the inherits from dbcontext class
    //connection string should includes server name, database name and any credentials
    //create an entity class, genre table
    //make sure to add your entity class asa dbset property inside your dbcontext class
    //in Ef we have thing called migration, use migration to create our database
    //we need to add migration commands to create the tables, database etc
    //Add-Migration <MigrationName> , make sure your migration names are meaningful, dont use name such as abc.
    //when running migration commands, make sure the project selected is the one project which has DbContext class
    //make sure you add reference for library that has DbContext to your startup project, in thi case MVC
    //tell mvc project that we are using Entity framework in startup file
    //add DbContext options as constructor parameter for our DbContext
    //after creating migration file and verifying it we need to use update-database command
    public class MovieStoreDbContext:DbContext
    {
        //have multiple Dbsets, all the dbsets you created are gonna reside in your dbcontext class

        public MovieStoreDbContext(DbContextOptions<MovieStoreDbContext> options):base(options)
        {

        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Trailer> Trailers { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<MovieCast> MovieCasts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(ConfigureMovie);
            modelBuilder.Entity<Trailer>(ConfigureTrailer);
            modelBuilder.Entity<MovieGenre>(ConfigureMovieGenre);
            modelBuilder.Entity<Cast>(entity =>
            {
                entity.ToTable("Cast");
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Name).HasMaxLength(128); 
                entity.Property(c => c.Gender).HasMaxLength(int.MaxValue);
                entity.Property(c => c.TmdbUrl).HasMaxLength(int.MaxValue);
                entity.Property(c => c.ProfilePath).HasMaxLength(2084);

            });
            modelBuilder.Entity<MovieCast>(entity =>
            {
                entity.ToTable("MovieCast");
                entity.HasKey(mc => new { mc.CastId,mc.MovieId,mc.Character});
                entity.Property(mc => mc.Character).HasMaxLength(450);
                entity.HasOne(mc => mc.Cast).WithMany(p=>p.MovieCasts).HasForeignKey(mc=>mc.CastId);
                entity.HasOne(mc => mc.Movie).WithMany(p => p.MovieCasts).HasForeignKey(mc => mc.MovieId);
            });
            modelBuilder.Entity<Review>(entity => {
                entity.ToTable("Review");
                entity.HasKey(r => new { r.MovieId, r.UserId });
                entity.Property(r => r.ReviewText).HasMaxLength(int.MaxValue);
                entity.Property(r=>r.Rating).HasColumnType("decimal(3, 2)");
                entity.HasOne(r => r.Movie).WithMany(r => r.Reviews).HasForeignKey(r => r.MovieId);
                entity.HasOne(r => r.User).WithMany(p => p.Reviews).HasForeignKey(r => r.UserId);

            });
            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");
                entity.Property(r => r.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");
                entity.HasKey(u => u.Id);
                entity.Property(u => u.FirstName).HasMaxLength(128);
                entity.Property(u => u.LastName).HasMaxLength(128);
                entity.Property(u => u.Email).HasMaxLength(256);
                entity.Property(u => u.HashedPassword).HasMaxLength(int.MaxValue);
                entity.Property(u => u.Salt).HasMaxLength(int.MaxValue);
                entity.Property(u => u.PhoneNumber).HasMaxLength(int.MaxValue);
                entity.Property(u => u.DateOfBirth).HasColumnType("datetime2");
               
            });
            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole");
                entity.HasKey(ur => new { ur.RoleId, ur.UserId });
                entity.HasOne(ur => ur.User).WithMany(ur => ur.UserRoles).HasForeignKey(u => u.UserId);
                entity.HasOne(ur => ur.Role).WithMany(ur => ur.UserRoles).HasForeignKey(r => r.RoleId);
            });
            modelBuilder.Entity<Favorite>(entity =>
            {
                entity.ToTable("Favorite");
                entity.HasKey(f => f.Id);

                entity.HasOne(f => f.User).WithMany(f => f.Favorites).HasForeignKey(f => f.UserId);
                //one use can have many favorite movies, and one movies can be many user's favorite. should be many to many(user and movies). so maybe add navi property favorite in movie. 
                entity.HasOne(f => f.Movie).WithMany(m => m.Favorites).HasForeignKey(f => f.MovieId);
            });
            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.ToTable("Purchase");
                entity.Property(p => p.TotalPrice).HasColumnType("decimal(5,2)");
                entity.Property(p => p.PurchaseDateTime).HasColumnType("datetime2");
                entity.HasOne(p => p.Customer).WithMany(p => p.Purchases).HasForeignKey(p => p.UserId);

            });
        }

        private void ConfigureMovieGenre(EntityTypeBuilder<MovieGenre> modelBuilder)
        {
            modelBuilder.ToTable("MovieGenre");
            modelBuilder.HasKey(mg => new { mg.MovieId, mg.GenreId });
            modelBuilder.HasOne(mg => mg.Movie).WithMany(g => g.MovieGenres).HasForeignKey(mg => mg.MovieId);
            modelBuilder.HasOne(mg => mg.Genre).WithMany(g => g.MovieGenres).HasForeignKey(mg => mg.GenreId);
        }

        private void ConfigureTrailer(EntityTypeBuilder<Trailer> modelBuilder)
        {
            modelBuilder.ToTable("Trailer");
            modelBuilder.HasKey(t => t.Id);
            modelBuilder.Property(t => t.Name).HasMaxLength(2084);
            modelBuilder.Property(t => t.TrailerUrl).HasMaxLength(2084);
           

        }

        private void ConfigureMovie(EntityTypeBuilder<Movie> modelBuilder)
        {
            //we can use fluent API config to model our tables

            modelBuilder.ToTable("Movie");
            modelBuilder.HasKey(m => m.Id);
            modelBuilder.Property(m => m.Title).IsRequired().HasMaxLength(256);
            modelBuilder.Property(m => m.Overview).HasMaxLength(4096);
            modelBuilder.Property(m => m.Tagline).HasMaxLength(512);
            modelBuilder.Property(m => m.ImdbUrl).HasMaxLength(2084);
            modelBuilder.Property(m => m.TmdbUrl).HasMaxLength(2084);
            modelBuilder.Property(m => m.PosterUrl).HasMaxLength(2084);
            modelBuilder.Property(m => m.BackdropUrl).HasMaxLength(2084);
            modelBuilder.Property(m => m.OriginalLanguage).HasMaxLength(64);
            modelBuilder.Property(m => m.Price).HasColumnType("decimal(5, 2)").HasDefaultValue(9.9m);
            modelBuilder.Property(m => m.CreatedDate).HasDefaultValueSql("getdate()");

            //we dont want to create rating column but we want c# rating propertiy in our entity so that we can show movie rating in the UI
            modelBuilder.Ignore(m => m.Rating);
            

        }

        public void Test()
        {
            var ll = new List<int>();
            ll.Where(x => x > 2);
            Genres.Where(b => b.Id == 2);
        }
    }
}
