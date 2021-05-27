using AutoMapper;
using IntroductionToAspMVC.Models;
using IntroductionToAspMVC.ViewModels;
using IntroductionToAspMVC.ViewModels.Movies;

namespace IntroductionToAspMVC.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Movie, MovieDetailViewModel>().ReverseMap();

            CreateMap<Movie, MovieCreateViewModel>().ReverseMap();

            CreateMap<Movie, MovieEditViewModel>().ReverseMap();

            CreateMap<Movie, MovieDeleteViewModel>().ReverseMap();

            CreateMap<Cursist, CursistViewModel>().ReverseMap();
        }
    }
}