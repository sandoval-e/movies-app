using Microsoft.EntityFrameworkCore;
using movies.api.Models.Entities;

namespace movies.api.DAL
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

		public DbSet<User> Users { get; set; }
		public DbSet<Actor> Actors { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Movie> Movies {  get; set; }
		public DbSet<Rating> Ratings { get; set; }
		public DbSet<MovieActor> MoviesActors { get; set; }
		public DbSet<MovieGenre> MovieGenres { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<MovieActor>()
				.HasKey(ma => new { ma.MovieId, ma.ActorId });
			modelBuilder.Entity<MovieActor>()
				.HasOne(ma => ma.Movie)
				.WithMany(m => m.MovieActors)
				.HasForeignKey(ma => ma.MovieId);
			modelBuilder.Entity<MovieActor>()
				.HasOne(ma => ma.Actor)
				.WithMany(m => m.MovieActors)
				.HasForeignKey(ma => ma.ActorId);

			modelBuilder.Entity<MovieGenre>()
				.HasKey(mg => new { mg.MovieId, mg.GenreId });
			modelBuilder.Entity<MovieGenre>()
				.HasOne(mg => mg.Movie)
				.WithMany(m => m.MovieGenres)
				.HasForeignKey(mg => mg.MovieId);
			modelBuilder.Entity<MovieGenre>()
				.HasOne(mg => mg.Genre)
				.WithMany(m => m.MovieGenres)
				.HasForeignKey(mg => mg.GenreId);
			
		}
	}
}
