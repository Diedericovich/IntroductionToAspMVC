using IntroductionToAspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IntroductionToAspMVC.Services
{
    public class MovieService : IMovieService
    {
        private List<Movie> movies = new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Title = "Jurassic Park",
                    ReleaseDate = new DateTime(1993,1,1),
                    Rating = 7.8,
                    Created = DateTime.Now
                },
                new Movie
                {
                    Id = 2,
                    Title = "Terminator 2",
                    ReleaseDate = new DateTime(1991,1,1),
                    Rating = 7.5,
                    Created = DateTime.Now
                },
                new Movie
                {
                    Id = 3,
                    Title = "The Thing",
                    ReleaseDate = new DateTime(1982,1,1),
                    Rating = 7.8,
                    Created = DateTime.Now
                },
            };

        public ICollection<Movie> GetMovies()
        {
            return movies;
        }

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public Movie GetMovie(int id)
        {
            var movie = movies.SingleOrDefault(x => x.Id == id);
            return movie;
        }
    }
}