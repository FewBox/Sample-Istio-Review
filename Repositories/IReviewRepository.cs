using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample_Istio_Review.Repositories
{
    public interface IReviewRepository
    {
        IList<Review> FindAll();
    }
}