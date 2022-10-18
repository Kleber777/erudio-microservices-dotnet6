using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model;
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly SqlServerContext _context;
        private readonly IMapper _mapper;

        //public ProductRepository()
        //{

        //}

        public ProductRepository(SqlServerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductsVO>> FindAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductsVO>>(products);
        }

        public async Task<ProductsVO> FindById(long id)
        {
            Product products = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync() ?? new Product();
            return _mapper.Map<ProductsVO>(products);
        }

        public async Task<ProductsVO> Create(ProductsVO vo)
        {
            Product product = _mapper.Map<Product>(vo);
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductsVO>(product);
        }
        public async Task<ProductsVO> Update(ProductsVO vo)
        {
            Product product = _mapper.Map<Product>(vo);
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductsVO>(product);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Product products = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync() ?? new Product();

                if (products.Id >= 0)
                {
                    _context.Products.Remove(products);
                    await _context.SaveChangesAsync();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {

                return false;
            }
        }


    }
}
