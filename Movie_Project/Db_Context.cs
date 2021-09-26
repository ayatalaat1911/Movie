using Microsoft.EntityFrameworkCore;
using Movie_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Project
{
    class Db_Context :DbContext
    {
        public Db_Context()
        {
        }

        public Db_Context(DbContextOptions<Db_Context> options)
        : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=.; initial catalog = MovieSystem;User ID=sa;Password=ZAmalek@1911 ;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add Length For Actor Entity
            modelBuilder.Entity<Actor>()
                .Property(a => a.FirstName).HasMaxLength(20);
            modelBuilder.Entity<Actor>()
                .Property(a => a.LastName).HasMaxLength(20);
            modelBuilder.Entity<Actor>()
                .Property(a => a.Gender).HasMaxLength(1);

            // Add Length For MovieCast Entity
            modelBuilder.Entity<MovieCast>()
                .Property(a => a.Role).HasMaxLength(30);

            
            //Relation between Movie & Actor Model
            modelBuilder.Entity<Actor>()
                .HasMany(A => A.Movies)
                .WithMany(A => A.Actors)
                .UsingEntity<MovieCast>
                (
                   j => j
                   .HasOne(a => a.Movie)
                   .WithMany(a => a.MovieCasts)
                   .HasForeignKey(a => a.MovieId),
                   j => j
                   .HasOne(a => a.Actor)
                   .WithMany(a => a.MovieCasts)
                   .HasForeignKey(a => a.ActorId),
                   j=>j
                   .HasKey(a=> new { a.ActorId,a.MovieId})
                );



            ///////////////////////////////////////////
            // Add Length For Director Entity
            modelBuilder.Entity<Director>()
                .Property(a => a.FirstName).HasMaxLength(20);
            modelBuilder.Entity<Director>()
                .Property(a => a.LastName).HasMaxLength(20);

            //Relation between Movie & Director Model
            modelBuilder.Entity<Director>()
                .HasMany(A => A.Movies)
                .WithMany(A => A.Directors)
                .UsingEntity<MovieDirection>
                (
                   j => j
                   .HasOne(a => a.Movie)
                   .WithMany(a => a.MovieDirections)
                   .HasForeignKey(a => a.MovieId),
                   j => j
                   .HasOne(a => a.Director)
                   .WithMany(a => a.MovieDirections)
                   .HasForeignKey(a => a.DirectorId),
                   j => j
                   .HasKey(a => new { a.DirectorId, a.MovieId })
                );


            ///////////////////////////////////////////
            // Add Length For Reviewer Entity
            modelBuilder.Entity<Reviewer>()
                .Property(a => a.Name).HasMaxLength(30);

            //Relation between Movie & Reviewer Model
            modelBuilder.Entity<Reviewer>()
                .HasMany(A => A.Movies)
                .WithMany(A => A.Reviewers)
                .UsingEntity<Rating>
                (
                   j => j
                   .HasOne(a => a.Movie)
                   .WithMany(a => a.Ratings)
                   .HasForeignKey(a => a.MovieId),
                   j => j
                   .HasOne(a => a.Reviewer)
                   .WithMany(a => a.Ratings)
                   .HasForeignKey(a => a.ReviewerId),
                   j => j
                   .HasKey(a => new { a.ReviewerId, a.MovieId })
                );


            ///////////////////////////////////////////
            // Add Length For Genre Entity
            modelBuilder.Entity<Genre>()
                .Property(a => a.Title).HasMaxLength(20);

            //Relation between Movie & Genre Model
            modelBuilder.Entity<Genre>()
                .HasMany(A => A.Movies)
                .WithMany(A => A.Genres)
                .UsingEntity<MovieGenre>
                (
                   j => j
                   .HasOne(a => a.Movie)
                   .WithMany(a => a.MovieGenres)
                   .HasForeignKey(a => a.MovieId),
                   j => j
                   .HasOne(a => a.Genre)
                   .WithMany(a => a.MovieGenres)
                   .HasForeignKey(a => a.GenreId),
                   j => j
                   .HasKey(a => new { a.GenreId, a.MovieId })
                );

            ////////////////////////////////////////////////
            // Add Length For Movie Entity
            modelBuilder.Entity<Movie>()
                .Property(a => a.Title).HasMaxLength(50);
            modelBuilder.Entity<Movie>()
                .Property(a => a.Language).HasMaxLength(50);
            modelBuilder.Entity<Movie>()
                .Property(a => a.MovieCountry).HasMaxLength(5);


        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieCast> MovieCasts { get; set; }
        public DbSet<MovieDirection> MovieDirections { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

    }
}
