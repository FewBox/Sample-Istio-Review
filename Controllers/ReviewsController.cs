using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FewBox.Core.Web.Dto;
using Microsoft.AspNetCore.Mvc;
using Sample_Istio_Review.Dtos;

namespace Sample_Istio_Review.Controllers
{
    /// <summary>
    /// Reviews controller.
    /// </summary> 
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        /// <summary>
        /// Get all reviews.
        /// </summary> 
        [HttpGet]
        public PayloadMetaResponseDto<IList<ReviewDto>> Get()
        {
            return new PayloadMetaResponseDto<IList<ReviewDto>>
            {
                Payload = new List<ReviewDto>
                {
                    new ReviewDto { Content = "Review 1" },
                    new ReviewDto { Content = "Review 2" }
                }
            };
        }
    }
}
