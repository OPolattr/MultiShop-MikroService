﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop_MikroService.Catalog.Dtos.ProductDetailDtos;
using MultiShop_MikroService.Catalog.Services.ProductDetailServices;

namespace MultiShop_MikroService.Catalog.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductDetailsController : ControllerBase
	{
		private readonly IProductDetailService _ProductDetailService;

		public ProductDetailsController(IProductDetailService ProductDetailService)
		{
			_ProductDetailService = ProductDetailService;
		}

		[HttpGet]
		public async Task<IActionResult> ProductDetailList()
		{
			var values = await _ProductDetailService.GetAllProductDetailAsync();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetProductDetailById(string id)
		{
			var values = await _ProductDetailService.GetByIdProductDetailAsync(id);
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> CreateProductDetail(CreateProductDetailDto createProductDetailDto)
		{
			await _ProductDetailService.CreateProductDetailAsync(createProductDetailDto);
			return Ok("Ürün detayı başarı ile eklendi");
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteProductDetail(string id)
		{
			await _ProductDetailService.DeleteProductDetailAsync(id);
			return Ok("Ürün Detayı başarı ile silindi");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateProductDetail(UpdateProductDetailDto updateProductDetailDto)
		{
			await _ProductDetailService.UpdateProductDetailAsync(updateProductDetailDto);
			return Ok("Ürün Detayı Güncellendi");
		}
	}
}
