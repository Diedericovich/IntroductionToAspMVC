using IntroductionToAspMVC.Models;
using System;
using System.Collections.Generic;

namespace IntroductionToAspMVC.Services
{
    public class MovieService : IMovieService
    {
        private List<Movie> list = new List<Movie>
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
                    Rating = 6.8,
                    Created = DateTime.Now
                },
            };

        public ICollection<Movie> GetMovies()
        {
            return list;
        }

        public void AddMovie(Movie movie)
        {
            list.Add(movie);
        }
    }
}