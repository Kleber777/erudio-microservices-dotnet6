using AutoMapper;
using GeekShopping.CouponAPI.Data.ValueObjects;

namespace GeekShopping.CouponAPI.Model
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponVO, Coupon>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
