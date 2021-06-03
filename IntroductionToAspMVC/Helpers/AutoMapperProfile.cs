using AutoMapper;
using IntroductionToAspMVC.Data.Weather;
using IntroductionToAspMVC.Models;
using IntroductionToAspMVC.ViewModels;
using IntroductionToAspMVC.ViewModels.Contacts;
using IntroductionToAspMVC.ViewModels.Movies;

namespace IntroductionToAspMVC.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<WeatherEntity, Models.Weather>()
                .ForMember(dst => dst.Location, opt => opt.MapFrom(src => src.name))
                .ForMember(dst => dst.Temperature, opt => opt.MapFrom(src => src.main.temp))
                .ForMember(dst => dst.MaxTemperature, opt => opt.MapFrom(src => src.main.temp_max))
                .ForMember(dst => dst.MinTemperature, opt => opt.MapFrom(src => src.main.temp_min))
                .ForMember(dst => dst.WeatherType, opt => opt.MapFrom(src => src.weather[0].description));


            CreateMap<Movie, MovieDetailViewModel>().ReverseMap();

            CreateMap<Movie, MovieCreateViewModel>().ReverseMap();

            CreateMap<Movie, MovieEditViewModel>().ReverseMap();

            CreateMap<Movie, MovieDeleteViewModel>().ReverseMap();

            CreateMap<Cursist, CursistViewModel>().ReverseMap();


            CreateMap<Contact, ContactViewModel>().ReverseMap();
            CreateMap<Contact, ContactDetailViewModel>()
                .ForMember(dst => dst.Bus, opt => opt.MapFrom(src => src.Address.Bus))
                .ForMember(dst => dst.Street, opt => opt.MapFrom(src => src.Address.Street))
                .ForMember(dst => dst.Number, opt => opt.MapFrom(src => src.Address.Number))
                .ForMember(dst => dst.PostalCode, opt => opt.MapFrom(src => src.Address.PostalCode))
                .ForMember(dst => dst.City, opt => opt.MapFrom(src => src.Address.City))
                .ReverseMap();
            CreateMap<Contact, ContactAddViewModel>()
                 .ForMember(dst => dst.Bus, opt => opt.MapFrom(src => src.Address.Bus))
                 .ForMember(dst => dst.Street, opt => opt.MapFrom(src => src.Address.Street))
                 .ForMember(dst => dst.Number, opt => opt.MapFrom(src => src.Address.Number))
                 .ForMember(dst => dst.PostalCode, opt => opt.MapFrom(src => src.Address.PostalCode))
                 .ForMember(dst => dst.City, opt => opt.MapFrom(src => src.Address.City))
                 .ReverseMap();
            CreateMap<Contact, ContactUpdateViewModel>()
                 .ForMember(dst => dst.Bus, opt => opt.MapFrom(src => src.Address.Bus))
                 .ForMember(dst => dst.Street, opt => opt.MapFrom(src => src.Address.Street))
                 .ForMember(dst => dst.Number, opt => opt.MapFrom(src => src.Address.Number))
                 .ForMember(dst => dst.PostalCode, opt => opt.MapFrom(src => src.Address.PostalCode))
                 .ForMember(dst => dst.City, opt => opt.MapFrom(src => src.Address.City))
                 .ForMember(dst => dst.AddressId, opt => opt.MapFrom(src => src.Address.Id))
                 .ReverseMap();
            CreateMap<Contact, ContactDeleteViewModel>().ReverseMap();

        }
    }
}