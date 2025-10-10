﻿using movies.api.Models.Entities;

namespace movies.api.DAL
{
	public static class DbSeeder
	{
		public static void Seed(AppDbContext dbContext)
		{
			if (!dbContext.Users.Any())
			{
				dbContext.Users.AddRange(
					new User { UserName = "SnowFlake", Email = "user@gmail.com" },
					new User { UserName = "GuiltySpart342", Email = "user2@gmail.com" },
					new User { UserName = "Skrillex", Email = "user3@gmail.com" },
					new User { UserName = "TheGodFather", Email = "user4@gmail.com" },
					new User { UserName = "FluffyCookie", Email = "user5@gmail.com" }
				);
			}

			if (!dbContext.Genres.Any())
			{
				dbContext.Genres.AddRange(
					new Genre { Name = "Drama" },
					new Genre { Name = "Biography" },
					new Genre { Name = "Music" },
					new Genre { Name = "Animal Adventure" },
					new Genre { Name = "Computer Animation" },
					new Genre { Name = "Epic" },
					new Genre { Name = "Comedy" },
					new Genre { Name = "Family" },
					new Genre { Name = "Sea Adventure" },
					new Genre { Name = "Body Horror" },
					new Genre { Name = "Action" },
					new Genre { Name = "Zombie" },
					new Genre { Name = "Romance" },
					new Genre { Name = "Love" }
				);
			}

			if (!dbContext.Actors.Any())
			{
				dbContext.Actors.AddRange(
					new Actor { FullName = "Rami Malek", PictureUrl = "https://goldenglobes.com/wp-content/uploads/2023/10/rami_malek_0601_mr._robot_13.jpg" },
					new Actor { FullName = "Lucy Boynton", PictureUrl = "https://image.tmdb.org/t/p/w500/wKNUTqAfi3QW2t2MwMotwOXKkZx.jpg" },
					new Actor { FullName = "Gwilym Lee", PictureUrl = "https://bookingagentinfo.com/wp-content/uploads/2023/05/mrgwilymlee-1.jpg" },
					new Actor { FullName = "Donald Glover", PictureUrl = "https://api.time.com/wp-content/uploads/2016/08/donald-glover.jpg?h=580" },
					new Actor { FullName = "Beyoncé", PictureUrl = "https://www.glam.com/img/gallery/beyonc-keeps-breaking-one-of-the-biggest-wedding-guest-rules/intro-1755015377.jpg" },
					new Actor { FullName = "Seth Rogen", PictureUrl = "https://ntvb.tmsimg.com/assets/assets/167023_v9_bc.jpg?w=360&h=480" },
					new Actor { FullName = "Albert brooks", PictureUrl = "https://image.tmdb.org/t/p/w500/8iDSGu5l93N7benjf6b3AysBore.jpg" },
					new Actor { FullName = "Ed O'Neill", PictureUrl = "https://ntvb.tmsimg.com/assets/assets/1282_v9_bc.jpg?w=360&h=480" },
					new Actor { FullName = "Gong Yoo", PictureUrl = "https://image.tmdb.org/t/p/w500/ocGoFb6TrK3uWGXt4WnuibUG1vD.jpg" },
					new Actor { FullName = "Jung Yu-mi", PictureUrl = "https://asianwiki.com/images/4/44/Jung_Yu-Mi_%281983%29-p01.jpg" },
					new Actor { FullName = "Ma Dong-seok", PictureUrl = "https://asianwiki.com/images/d/d2/Ma_Dong-Seok-TCOE-GV.jpg" },
					new Actor { FullName = "Rachel McAdams", PictureUrl = "https://ntvb.tmsimg.com/assets/assets/273505_v9_bd.jpg?w=360&h=480" },
					new Actor { FullName = "Channing Tatum", PictureUrl = "https://api.screendollars.com/wp-content/uploads/2021/10/Channing-Tatum-.png" },
					new Actor { FullName = "Sam Neill", PictureUrl = "https://ntvb.tmsimg.com/assets/assets/57645_v9_bd.jpg?w=360&h=480" }
				);
			}

			if (!dbContext.Movies.Any())
			{
				dbContext.Movies.AddRange(
					new Movie { Title = "Bohemian Rhapsody", ReleaseDate = new DateTime(2018, 11, 2), PictureUrl = "https://www.originalfilmart.com/cdn/shop/products/BohemianRhapsody_2018_french_original_film_art_600x.jpg?v=1610071563", Description = "With his impeccable vocal abilities, Freddie Mercury and his rock band, Queen, achieve superstardom. However, amidst his skyrocketing success, he grapples with his ego, sexuality and a fatal illness." },
					new Movie { Title = "The Lion King", ReleaseDate = new DateTime(2020, 12, 20), PictureUrl = "https://i.ebayimg.com/images/g/IWkAAOSwUTphZOzG/s-l1200.jpg", Description = "After the murder of his father, a young lion prince flees his kingdom only to learn the true meaning of responsibility and bravery." },
					new Movie { Title = "Finding Dory", ReleaseDate = new DateTime(2016, 6, 17), PictureUrl = "https://i.ebayimg.com/00/s/MTAyNFg2ODI=/z/LqAAAOSwc6ti7D4A/$_12.JPG?set_id=880000500F", Description = "Friendly but forgetful blue tang Dory begins a search for her long-lost parents and everyone learns a few things about the real meaning of family along the way." },
					new Movie { Title = "Train to Busan", ReleaseDate = new DateTime(2016, 5, 2), PictureUrl = "https://sorryneverheardofit.wordpress.com/wp-content/uploads/2016/10/1.png", Description = "While a zombie virus breaks out in South Korea, passengers struggle to survive on the train from Seoul to Busan." },
					new Movie { Title = "The Vow", ReleaseDate = new DateTime(2012, 2, 6), PictureUrl = "https://l450v.alamy.com/450v/cw41ww/the-vow-cw41ww.jpg", Description = "A car accident puts Paige in a coma, and when she wakes up with severe memory loss, her husband Leo works to win her heart again." }
				);
			}

			dbContext.SaveChanges();

			var bohemian = dbContext.Movies.FirstOrDefault(m => m.Title == "Bohemian Rhapsody");
			var lionKing = dbContext.Movies.FirstOrDefault(m => m.Title == "The Lion King");
			var findingDory = dbContext.Movies.FirstOrDefault(m => m.Title == "Finding Dory");
			var trainToBusan = dbContext.Movies.FirstOrDefault(m => m.Title == "Train to Busan");
			var theVow = dbContext.Movies.FirstOrDefault(m => m.Title == "The Vow");

			var music = dbContext.Genres.FirstOrDefault(g => g.Name == "Music");
			var drama = dbContext.Genres.FirstOrDefault(g => g.Name == "Drama");
			var family = dbContext.Genres.FirstOrDefault(g => g.Name == "Family");
			var animation = dbContext.Genres.FirstOrDefault(g => g.Name == "Computer Animation");
			var zombie = dbContext.Genres.FirstOrDefault(g => g.Name == "Zombie");
			var romance = dbContext.Genres.FirstOrDefault(g => g.Name == "Romance");
			var biography = dbContext.Genres.FirstOrDefault(g => g.Name == "Biography");
			var animalAdventure = dbContext.Genres.FirstOrDefault(g => g.Name == "Animal Adventure");
			var epic = dbContext.Genres.FirstOrDefault(g => g.Name == "Epic");
			var comedy = dbContext.Genres.FirstOrDefault(g => g.Name == "Comedy");
			var seaAdventure = dbContext.Genres.FirstOrDefault(g => g.Name == "Sea Adventure");
			var bodyHorror = dbContext.Genres.FirstOrDefault(g => g.Name == "Body Horror");
			var action = dbContext.Genres.FirstOrDefault(g => g.Name == "Action");
			var love = dbContext.Genres.FirstOrDefault(g => g.Name == "Love");

			var rami = dbContext.Actors.FirstOrDefault(a => a.FullName == "Rami Malek");
			var lucy = dbContext.Actors.FirstOrDefault(a => a.FullName == "Lucy Boynton");
			var gwilym = dbContext.Actors.FirstOrDefault(a => a.FullName == "Gwilym Lee");
			var donald = dbContext.Actors.FirstOrDefault(a => a.FullName == "Donald Glover");
			var beyonce = dbContext.Actors.FirstOrDefault(a => a.FullName == "Beyoncé");
			var seth = dbContext.Actors.FirstOrDefault(a => a.FullName == "Seth Rogen");
			var gong = dbContext.Actors.FirstOrDefault(a => a.FullName == "Gong Yoo");
			var jung = dbContext.Actors.FirstOrDefault(a => a.FullName == "Jung Yu-mi");
			var ma = dbContext.Actors.FirstOrDefault(a => a.FullName == "Ma Dong-seok");
			var rachel = dbContext.Actors.FirstOrDefault(a => a.FullName == "Rachel McAdams");
			var channing = dbContext.Actors.FirstOrDefault(a => a.FullName == "Channing Tatum");

			var user1 = dbContext.Users.FirstOrDefault(u => u.UserName == "SnowFlake");
			var user2 = dbContext.Users.FirstOrDefault(u => u.UserName == "GuiltySpart342");
			var user3 = dbContext.Users.FirstOrDefault(u => u.UserName == "Skrillex");
			var user4 = dbContext.Users.FirstOrDefault(u => u.UserName == "TheGodFather");
			var user5 = dbContext.Users.FirstOrDefault(u => u.UserName == "FluffyCookie");


			if (!dbContext.MovieActors.Any())
			{
				dbContext.MovieActors.AddRange(
					new MovieActor { MovieId = bohemian.Id, ActorId = rami.Id },
					new MovieActor { MovieId = bohemian.Id, ActorId = lucy.Id },
					new MovieActor { MovieId = bohemian.Id, ActorId = gwilym.Id },
					new MovieActor { MovieId = lionKing.Id, ActorId = donald.Id },
					new MovieActor { MovieId = lionKing.Id, ActorId = beyonce.Id },
					new MovieActor { MovieId = findingDory.Id, ActorId = seth.Id },
					new MovieActor { MovieId = trainToBusan.Id, ActorId = gong.Id },
					new MovieActor { MovieId = trainToBusan.Id, ActorId = jung.Id },
					new MovieActor { MovieId = trainToBusan.Id, ActorId = ma.Id },
					new MovieActor { MovieId = theVow.Id, ActorId = rachel.Id },
					new MovieActor { MovieId = theVow.Id, ActorId = channing.Id }
				);
			}

			if (!dbContext.MovieGenres.Any())
			{
				dbContext.MovieGenres.AddRange(
					new MovieGenre { MovieId = bohemian.Id, GenreId = music.Id },
					new MovieGenre { MovieId = bohemian.Id, GenreId = drama.Id },
					new MovieGenre { MovieId = bohemian.Id, GenreId = biography.Id },
					new MovieGenre { MovieId = lionKing.Id, GenreId = family.Id },
					new MovieGenre { MovieId = lionKing.Id, GenreId = animation.Id },
					new MovieGenre { MovieId = lionKing.Id, GenreId = epic.Id },
					new MovieGenre { MovieId = findingDory.Id, GenreId = animation.Id },
					new MovieGenre { MovieId = findingDory.Id, GenreId = family.Id },
					new MovieGenre { MovieId = trainToBusan.Id, GenreId = zombie.Id },
					new MovieGenre { MovieId = trainToBusan.Id, GenreId = drama.Id },
					new MovieGenre { MovieId = trainToBusan.Id, GenreId = action.Id },
					new MovieGenre { MovieId = theVow.Id, GenreId = romance.Id },
					new MovieGenre { MovieId = theVow.Id, GenreId = drama.Id }
				);
			}

			if (!dbContext.Ratings.Any())
			{
				dbContext.Ratings.AddRange(
					new Rating { MovieId = bohemian.Id, UserId = user1.Id, Score = 4, Comment = "Awesome as always" },
					new Rating { MovieId = lionKing.Id, UserId = user2.Id, Score = 4, Comment = "I loved it" },
					new Rating { MovieId = findingDory.Id, UserId = user1.Id, Score = 3, Comment = "Oh my god..." },
					new Rating { MovieId = trainToBusan.Id, UserId = user3.Id, Score = 5, Comment = "Thrilling and emotional" },
					new Rating { MovieId = theVow.Id, UserId = user4.Id, Score = 5, Comment = "Heartwarming story" },
					new Rating { MovieId = bohemian.Id, UserId = user5.Id, Score = 5, Comment = "Freddie Mercury is a legend" },
					new Rating { MovieId = lionKing.Id, UserId = user3.Id, Score = 4, Comment = "Great visuals and music" },
					new Rating { MovieId = findingDory.Id, UserId = user4.Id, Score = 2, Comment = "Cute but forgettable" },
					new Rating { MovieId = trainToBusan.Id, UserId = user2.Id, Score = 4, Comment = "Best zombie movie ever" },
					new Rating { MovieId = theVow.Id, UserId = user5.Id, Score = 3, Comment = "Emotional and touching" }
				);
			}

			dbContext.SaveChanges();

		}
	}
}
