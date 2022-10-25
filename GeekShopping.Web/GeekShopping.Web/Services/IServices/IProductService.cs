using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProductService
    {
        
        Task<IEnumerable<ProductModel>> FindAllProducts(string token);
        Task<ProductModel> FindProductById(long id, string token);
        Task<ProductModel> Create(ProductModel model, string token);
        Task<ProductModel> Update(ProductModel model, string token);
        Task<bool> Delete(long id, string token);
    }
}
