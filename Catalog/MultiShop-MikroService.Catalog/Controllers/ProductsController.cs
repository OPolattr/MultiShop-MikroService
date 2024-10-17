﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop_MikroService.Catalog.Dtos.ProductDtos;
using MultiShop_MikroService.Catalog.Services.ProductServices;
using MultiShop_MikroService.Catalog.Services.ProductServices;

namespace MultiShop_MikroService.Catalog.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly IProductService _productService;

		public ProductsController(IProductService productService)
		{
			_productService = productService;
		}

		[HttpGet]
		public async Task<IActionResult> ProductList()
		{
			var values = _productService.GetAllProductAsync();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetProductById(string id)
		{
			var values = _productService.GetByIdProductAsync(id);
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
		{
			await _productService.CreateProductAsync(createProductDto);
			return Ok("Ürün başarı ile eklendi");
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteProduct(string id)
		{
			await _productService.DeleteProductAsync(id);
			return Ok("Ürün başarı ile silindi");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
		{
			await _productService.UpdateProductAsync(updateProductDto);
			return Ok("Ürün Güncellendi");
		}
	}
}
