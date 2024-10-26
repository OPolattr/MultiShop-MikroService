﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop_MikroService.basket.Dtos;
using MultiShop_MikroService.basket.LoginServices;
using MultiShop_MikroService.basket.Services;

namespace MultiShop_MikroService.basket.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BasketsController : ControllerBase
	{
		private readonly IBasketService _basketService;
		private readonly ILoginService _loginService;

		public BasketsController(ILoginService loginService, IBasketService basketService)
		{
			_loginService = loginService;
			_basketService = basketService;
		}

		[HttpGet]
		public async Task<IActionResult> GetBasketDetail()
		{
			var user = User.Claims;
			var values = await _basketService.GetBasket(_loginService.GetUserId);
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> SaveMyBasket(BasketTotalDto basketTotalDto)
		{
			basketTotalDto.UserId = _loginService.GetUserId;
			await _basketService.SaveBasket(basketTotalDto);
			return Ok("Sepetteki değişikler kaydedildi");
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteBasket()
		{
			await _basketService.DeleteBasket(_loginService.GetUserId);
			return Ok("Sepet başarıyla tamamıyla silindi");
		}
	}
}
