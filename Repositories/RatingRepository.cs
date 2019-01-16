using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FewBox.Core.Web.Dto;
using Microsoft.AspNetCore.Http;
using Sample_Istio_Review.Configs;

namespace Sample_Istio_Review.Repositories
{
    public class RatingRepository : IRatingRepository
    {
        private RatingApiConfig RatingApiConfig { get; set; }
        private IHttpContextAccessor HttpContextAccessor { get; set; }

        public RatingRepository(RatingApiConfig ratingApiConfig, IHttpContextAccessor httpContextAccessor)
        {
            this.RatingApiConfig = ratingApiConfig;
            this.HttpContextAccessor = httpContextAccessor;
        }
        public async Task<Rating> FindOne(string id)
        {
             using (var client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(3);
                foreach(var header in this.HttpContextAccessor.HttpContext.Request.Headers)
                {
                    if(header.Key == "enduser")
                    {
                        client.DefaultRequestHeaders.Add(header.Key, header.Value.ToString());
                        Console.WriteLine($"{header.Key}:{header.Value}");
                    }
                }
                PayloadMetaResponseDto<Rating> responseData;
                try
                {
                    var response = await client.GetAsync($"{this.RatingApiConfig.BaseUrl}/api/ratings/{id}");
                    response.EnsureSuccessStatusCode();
                    responseData = await response.Content.ReadAsAsync<PayloadMetaResponseDto<Rating>>();
                    if(responseData.IsSuccessful)
                    {
                        return responseData.Payload;
                    }
                }
                catch(Exception exception)
                {
                    Console.WriteLine($"{exception.Message}");
                }
                return null;
            }
        }
    }
}