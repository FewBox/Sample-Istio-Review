using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample_Istio_Review.Repositories
{
    public interface IRatingRepository
    {
        Task<Rating> FindOne(string id);
    }
}