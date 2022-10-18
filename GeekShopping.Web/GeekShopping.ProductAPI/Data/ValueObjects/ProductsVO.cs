namespace GeekShopping.ProductAPI.Data.ValueObjects
{
    public class ProductsVO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Describe { get; set; }
        public string CategoryName { get; set; }
         public string ImageUrl { get; set; }
    }
}
