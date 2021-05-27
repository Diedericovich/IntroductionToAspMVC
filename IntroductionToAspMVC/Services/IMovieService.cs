using IntroductionToAspMVC.Models;
using System.Collections.Generic;

namespace IntroductionToAspMVC.Services
{
    public interface IMovieService
    {
        ICollection<Movie> GetMovies();
        void AddMovie(Movie movieModel);
        Movie GetMovie(int id);
    }
}