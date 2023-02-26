using Mango.Web.Models;
using Mango.Web.Services.IServices;

namespace Mango.Web.Services
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<T> CreateProductAsync<T>(ProductDto productDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = StaticDetails.ApiType.POST,
                Data = productDto,
                ApiUrl = StaticDetails.ProductAPIBase + "/api/products",
                AccessToken = ""
            });
        }

        public async Task<T> DeleteProductAsync<T>(string productId)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = StaticDetails.ApiType.DELETE,
                ApiUrl = StaticDetails.ProductAPIBase + "/api/products/" + productId,
                AccessToken = ""
            });
        }

        public async Task<T> GetAllProductsAsync<T>()
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = StaticDetails.ApiType.GET,
                ApiUrl = StaticDetails.ProductAPIBase + "/api/products",
                AccessToken = ""
            });
        }

        public async Task<T> GetProductsByIdAsync<T>(string productId)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = StaticDetails.ApiType.GET,
                ApiUrl = StaticDetails.ProductAPIBase + "/api/products/" + productId,
                AccessToken = ""
            });
        }

        public async Task<T> UpdateProductAsync<T>(ProductDto productDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = StaticDetails.ApiType.PUT,
                Data = productDto,
                ApiUrl = StaticDetails.ProductAPIBase + "/api/products/" + productDto,
                AccessToken = ""
            });
        }
    }
}
