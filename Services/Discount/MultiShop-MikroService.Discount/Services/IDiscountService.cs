using MultiShop_MikroService.Discount.Dtos;

namespace MultiShop_MikroService.Discount.Services
{
	public interface IDiscountService
	{
		Task<List<ResultDiscountCouponDto>> GetAllDiscountCouponAsync();
		Task CreateDiscountCouponAsync(CreateDiscountCouponDto createCouponDto);
		Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateCouponDto);
		Task DeleteDiscountCouponAsync(int id);
		Task<GetByIdDiscountCouponDto> GetByIdDiscountCouponAsync(int id);
	}
}
