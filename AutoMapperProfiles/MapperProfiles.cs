using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Sample_Istio_Review.Dtos;
using Sample_Istio_Review.Repositories;

namespace Sample_Istio_Review.AutoMapperProfiles
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<Review, ReviewDto>()
                .ForMember(dest => dest.Star, opt => opt.MapFrom<RatingConverter, string>(src=>src.Id));
        }
    }
}