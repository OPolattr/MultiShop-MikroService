using MultiShop_MikroService.basket.Dtos;

namespace MultiShop_MikroService.basket.Services
{
	public interface IBasketService
	{
		Task<BasketTotalDto> GetBasket(string userId);
		Task SaveBasket(BasketTotalDto basketTotalDto);
		Task DeleteBasket(string userId);
	}
}
