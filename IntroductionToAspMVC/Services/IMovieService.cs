using IntroductionToAspMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Services
{
    public interface IMovieService
    {
        Task AddMovieAsync(Movie movie);
        Task DeleteMovieAsync(Movie model);
        Task<Movie> GetMovieAsync(int id);
        Task<IList<Movie>> GetMoviesAsync();
        Task UpdateMovieAsync(Movie model);
    }
}