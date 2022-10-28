using System.ComponentModel.DataAnnotations;

namespace GeekShopping.Web.Models
{
    public class ProductViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Describe { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
        
        [Range(1, 100)]
        public int Count { get; set; } = 1;
        public string SubStringName()
        {
            if (Name.Length < 24)
                return Name;
            return $"{ Name.Substring(0, 21)} ...";
        }
        public string SubStringDescription()
        {
            if (Describe.Length < 355)
                return Describe;
            return $"{Describe.Substring(0, 352)} ...";
        }
    }
}
