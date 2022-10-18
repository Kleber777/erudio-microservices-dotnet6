using GeekShopping.ProductAPI.Data.ValueObjects;

namespace GeekShopping.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductsVO>> FindAll();
        Task<ProductsVO> FindById(long id);
        Task<ProductsVO> Create(ProductsVO vo);
        Task<ProductsVO> Update(ProductsVO vo);
        Task<bool> Delete(long id);
    }
}
