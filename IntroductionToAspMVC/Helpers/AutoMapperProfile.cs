using AutoMapper;
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