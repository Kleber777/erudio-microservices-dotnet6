using GeekShopping.CartAPI.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.CartAPI.Model
{
    [Table("cart_detail")]
    public class CartDetail : BaseEntity
    {
        
        public long CartHeaderId { get; set; }
        public long ProductId { get; set; }
        
        [Column("count")]
        public int Count { get; set; }

        [ForeignKey("cart_header_id")]
        public virtual CartHeader CartHeader { get; set; }
        
        [ForeignKey("product_id")]
        public virtual Product Product { get; set; }
    }
}
