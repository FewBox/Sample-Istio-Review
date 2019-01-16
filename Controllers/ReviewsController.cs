using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FewBox.Core.Web.Dto;
using Microsoft.AspNetCore.Mvc;
using Sample_Istio_Review.Dtos;
using Sample_Istio_Review.Repositories;

namespace Sample_Istio_Review.Controllers
{
    /// <summary>
    /// Reviews controller.
    /// </summary> 
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private IReviewRepository ReviewRepository{ get; set; }
        private IMapper Mapper { get; set; }
        
        public ReviewsController(IMapper mapper, IReviewRepository reviewRepository)
        {
            this.Mapper = mapper;
            this.ReviewRepository = reviewRepository;
        }

        /// <summary>
        /// Get all reviews.
        /// </summary> 
        [HttpGet]
        public PayloadMetaResponseDto<IList<ReviewDto>> Get()
        {
            return new PayloadMetaResponseDto<IList<ReviewDto>>
            {
                Payload = this.Mapper.Map<IList<Review>, IList<ReviewDto>>(this.ReviewRepository.FindAll())
            };
        }
    }
}
