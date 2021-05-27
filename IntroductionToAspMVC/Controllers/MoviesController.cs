using System.Collections.Generic;
using AutoMapper;
using IntroductionToAspMVC.Services;
using IntroductionToAspMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using IntroductionToAspMVC.Models;
using IntroductionToAspMVC.ViewModels.Movies;

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
        public IActionResult Index()
        {
            ICollection<Movie> movies = _service.GetMovies();
            var viewModel = new MovieViewModel
            {
                Movies = _mapper.Map<ICollection<Movie>>(movies)
            };

            return View(viewModel);
        }

        //[Route("MovieInformation/{id}")]
        //[Route("Detail/{id}")]
        public IActionResult Detail(int id)
        {
            Movie movie = _service.GetMovies().FirstOrDefault(x => x.Id == id);
            MovieDetailViewModel viewModel = _mapper.Map<MovieDetailViewModel>(movie);

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MovieCreateViewModel vm)
        {
            bool isModelValid = TryValidateModel(vm);

            if (!isModelValid)
            {
                return View(vm);
            }

            Movie movieModel = _mapper.Map<Movie>(vm);
            _service.AddMovie(movieModel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            Movie movie = _service.GetMovie(id);

            if (movie == null)
            {
                return NotFound();
            }

            MovieEditViewModel vm = _mapper.Map<MovieEditViewModel>(movie);
            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(MovieEditViewModel vm)
        {
            bool isModelValid = TryValidateModel(vm);

            if (!isModelValid)
            {
                return View(vm);
            }

            Movie model = _mapper.Map<Movie>(vm);
            //_service.UpdateMovie(id, model);

            return RedirectToAction(nameof(Index));
        }
    }
}