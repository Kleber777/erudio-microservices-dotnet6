using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProductService
    {
        
        Task<IEnumerable<ProductViewModel>> FindAllProducts(string token);
        Task<ProductViewModel> FindProductById(long id, string token);
        Task<ProductViewModel> Create(ProductViewModel model, string token);
        Task<ProductViewModel> Update(ProductViewModel model, string token);
        Task<bool> Delete(long id, string token);
    }
}
