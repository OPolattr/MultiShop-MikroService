using MultiShop_MikroService.basket.Dtos;
using MultiShop_MikroService.basket.Settings;
using System.Text.Json;

namespace MultiShop_MikroService.basket.Services
{
	public class BasketService : IBasketService
	{
		private readonly RedisService _redisService;

		public BasketService(RedisService redisService)
		{
			_redisService = redisService;
		}

		public async Task DeleteBasket(string userId)
		{
			await _redisService.GetDb().KeyDeleteAsync(userId);
		}

		public async Task<BasketTotalDto> GetBasket(string userId)
		{
			var existBasket = await _redisService.GetDb().StringGetAsync(userId);
			return JsonSerializer.Deserialize<BasketTotalDto>(existBasket);
		}

		public async Task SaveBasket(BasketTotalDto basketTotalDto)
		{
			await _redisService.GetDb().StringSetAsync(basketTotalDto.UserId, JsonSerializer.Serialize(basketTotalDto));

		}
	}
}
