using IntroductionToAspMVC.Data;
using IntroductionToAspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Services
{
    public class MovieService : IMovieService
    {
        private IGenericRepo<Movie> _repo;

        public MovieService(IGenericRepo<Movie> repo)
        {
            _repo = repo;
        }

        public async Task<IList<Movie>> GetMoviesAsync()
        {
            return await _repo.GetEntitiesAsync();
        }

        public async Task AddMovieAsync(Movie movie)
        {
            await _repo.AddEntityAsync(movie);
        }

        public async Task<Movie> GetMovieAsync(int id)
        {
            var movie = await _repo.GetEntityAsync(id);
            return movie;
        }

        public async Task UpdateMovieAsync(Movie model)
        {
            await _repo.UpdateEntityAsync(model);
        }

        public async Task DeleteMovieAsync(Movie model)
        {
            await _repo.DeleteEntityAsync(model);
        }
    }
}