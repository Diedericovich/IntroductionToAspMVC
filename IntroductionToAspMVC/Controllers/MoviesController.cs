using AutoMapper;
using IntroductionToAspMVC.Models;
using IntroductionToAspMVC.Services;
using IntroductionToAspMVC.ViewModels;
using IntroductionToAspMVC.ViewModels.Movies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Controllers
{
    //[Route("/films")]
    //[Route("/movies")]
    public class MoviesController : Controller
    {
        private readonly IMovieService _service;
        private readonly IMapper _mapper;

        public MoviesController(IMovieService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //[Route("Index")]
        public async Task<IActionResult> Index()
        {
            ICollection<Movie> movies = await _service.GetMoviesAsync();
            var viewModel = new MovieViewModel
            {
                Movies = _mapper.Map<ICollection<Movie>>(movies)
            };

            return View(viewModel);
        }

        //[Route("MovieInformation/{id}")]
        //[Route("Detail/{id}")]
        public async Task<IActionResult> Detail(int id)
        {
            Movie movie = await _service.GetMovieAsync(id);
            MovieDetailViewModel viewModel = _mapper.Map<MovieDetailViewModel>(movie);

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MovieCreateViewModel vm)
        {
            bool isModelValid = TryValidateModel(vm);

            if (!isModelValid)
            {
                return View(vm);
            }

            Movie movieModel = _mapper.Map<Movie>(vm);
            await _service.AddMovieAsync(movieModel);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            Movie movie = await _service.GetMovieAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            MovieEditViewModel vm = _mapper.Map<MovieEditViewModel>(movie);
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(MovieEditViewModel vm)
        {
            bool isModelValid = TryValidateModel(vm);

            if (!isModelValid)
            {
                return View(vm);
            }

            Movie model = _mapper.Map<Movie>(vm);
            await _service.UpdateMovieAsync(model);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult>Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            Movie model = await _service.GetMovieAsync(id);

            if (model == null)
            {
                return NotFound();
            }

            MovieDeleteViewModel vm = _mapper.Map<MovieDeleteViewModel>(model);

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(MovieDeleteViewModel vm)
        {
            if (vm == null)
            {
                return NotFound();
            }

            Movie model = _mapper.Map<Movie>(vm);
            await _service.DeleteMovieAsync(model);
            return RedirectToAction(nameof(Index));
        }
    }
}