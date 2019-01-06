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
                    new ReviewDto { Content = "Review 1", Base64SvgStar = 
                    "data:image/svg+xml;base64,PHN2ZyBoZWlnaHQ9JzMwMHB4JyB3aWR0aD0nMzAwcHgnICBmaWxsPSIjMDAwMDAwIiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHhtbG5zOnhsaW5rPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5L3hsaW5rIiB2ZXJzaW9uPSIxLjEiIHg9IjBweCIgeT0iMHB4IiB2aWV3Qm94PSIwIDAgMjQgMjQiIGVuYWJsZS1iYWNrZ3JvdW5kPSJuZXcgMCAwIDI0IDI0IiB4bWw6c3BhY2U9InByZXNlcnZlIj48cGF0aCBkPSJNMjIuNDc2LDkuNTg5Yy0wLjA1OS0wLjE4Mi0wLjIxNi0wLjMxMy0wLjQwMy0wLjM0MWwtNi42NS0wLjk2NWwtMi45NzQtNi4wMjdjLTAuMTY4LTAuMzQtMC43MjktMC4zNC0wLjg5NiwwTDguNTc4LDguMjgzICBsLTYuNjUsMC45NjVDMS43NCw5LjI3NSwxLjU4Myw5LjQwNywxLjUyNCw5LjU4OWMtMC4wNTksMC4xODEtMC4wMSwwLjM4LDAuMTI3LDAuNTEzbDQuODEyLDQuNjkxbC0xLjEzNiw2LjYyMSAgYy0wLjAzMiwwLjE4OCwwLjA0NSwwLjM3OCwwLjE5OSwwLjQ4OWMwLjA4NywwLjA2MywwLjE5LDAuMDk2LDAuMjk0LDAuMDk2YzAuMDgsMCwwLjE1OS0wLjAxOSwwLjIzMi0wLjA1OEwxMiwxOC44MTVsNS45NDksMy4xMjYgIGMwLjE2OCwwLjA5LDAuMzczLDAuMDc0LDAuNTI2LTAuMDM4YzAuMTU0LTAuMTExLDAuMjMxLTAuMzAyLDAuMTk5LTAuNDg5bC0xLjEzOC02LjYyMWw0LjgxMi00LjY5MSAgQzIyLjQ4NSw5Ljk2OSwyMi41MzQsOS43NywyMi40NzYsOS41ODl6IE0xNi42NTEsMTQuMjZjLTAuMTE4LDAuMTE1LTAuMTcyLDAuMjgxLTAuMTQ1LDAuNDQzbDEuMDExLDUuODgybC01LjI4NS0yLjc3NiAgYy0wLjE0NS0wLjA3Ni0wLjMyLTAuMDc2LTAuNDY1LDBsLTUuMjgzLDIuNzc2bDEuMDA5LTUuODgyYzAuMDI3LTAuMTYzLTAuMDI2LTAuMzI4LTAuMTQ1LTAuNDQzbC00LjI3NC00LjE2N2w1LjkwOC0wLjg1NyAgYzAuMTYyLTAuMDI0LDAuMzA0LTAuMTI2LDAuMzc2LTAuMjczTDEyLDMuNjA3bDIuNjQyLDUuMzU0YzAuMDcyLDAuMTQ3LDAuMjE0LDAuMjQ5LDAuMzc2LDAuMjczbDUuOTA4LDAuODU3TDE2LjY1MSwxNC4yNnoiPjwvcGF0aD48L3N2Zz4=" },
                    new ReviewDto { Content = "Review 2", Base64SvgStar =
                    "data:image/svg+xml;base64,PHN2ZyBoZWlnaHQ9JzMwMHB4JyB3aWR0aD0nMzAwcHgnICBmaWxsPSIjMDAwMDAwIiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHhtbG5zOnhsaW5rPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5L3hsaW5rIiB2ZXJzaW9uPSIxLjEiIHg9IjBweCIgeT0iMHB4IiB2aWV3Qm94PSIwIDAgMjQgMjQiIGVuYWJsZS1iYWNrZ3JvdW5kPSJuZXcgMCAwIDI0IDI0IiB4bWw6c3BhY2U9InByZXNlcnZlIj48cGF0aCBkPSJNMjIuNDc2LDkuNTg5Yy0wLjA1OS0wLjE4Mi0wLjIxNi0wLjMxMy0wLjQwMy0wLjM0MWwtNi42NS0wLjk2NWwtMi45NzQtNi4wMjdjLTAuMTY4LTAuMzQtMC43MjktMC4zNC0wLjg5NiwwTDguNTc4LDguMjgzICBsLTYuNjUsMC45NjVDMS43NCw5LjI3NSwxLjU4Myw5LjQwNywxLjUyNCw5LjU4OWMtMC4wNTksMC4xODEtMC4wMSwwLjM4LDAuMTI3LDAuNTEzbDQuODEyLDQuNjkxbC0xLjEzNiw2LjYyMSAgYy0wLjAzMiwwLjE4OCwwLjA0NSwwLjM3OCwwLjE5OSwwLjQ4OWMwLjA4NywwLjA2MywwLjE5LDAuMDk2LDAuMjk0LDAuMDk2YzAuMDgsMCwwLjE1OS0wLjAxOSwwLjIzMi0wLjA1OEwxMiwxOC44MTVsNS45NDksMy4xMjYgIGMwLjE2OCwwLjA5LDAuMzczLDAuMDc0LDAuNTI2LTAuMDM4YzAuMTU0LTAuMTExLDAuMjMxLTAuMzAyLDAuMTk5LTAuNDg5bC0xLjEzOC02LjYyMWw0LjgxMi00LjY5MSAgQzIyLjQ4NSw5Ljk2OSwyMi41MzQsOS43NywyMi40NzYsOS41ODl6Ij48L3BhdGg+PC9zdmc+"}
                }
            };
        }
    }
}
