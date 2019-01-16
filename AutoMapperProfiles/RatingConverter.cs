using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Sample_Istio_Review.Dtos;
using Sample_Istio_Review.Repositories;

namespace Sample_Istio_Review.AutoMapperProfiles
{
    public class RatingConverter : IMemberValueResolver<Review, ReviewDto, string, int>
    {
        private IMapper Mapper { get; set; }
        private IRatingRepository RatingRepository { get; set; }
        public RatingConverter(IMapper mapper, IRatingRepository ratingRepository)
        {
            this.Mapper = mapper;
            this.RatingRepository = ratingRepository;
        }

        public int Resolve(Review source, ReviewDto destination, string sourceMember, int destMember, ResolutionContext context)
        {
            // return 1;
            Console.WriteLine($"Review Id: {sourceMember}");
            var rating = this.RatingRepository.FindOne(sourceMember).Result;
            return rating!=null? rating.Star : -1;
        }
    }
}