using MultiShop_MikroService.Catalog.Dtos.ProductImageDtos;

namespace MultiShop_MikroService.Catalog.Services.ProductImageServices
{
	public interface IProductImageService
	{
		Task<List<ResultProductImageDto>> GetAllProductImageAsync();
		Task CreateProductImageAsync(CreateProductImageDto createProductImageDto);
		Task UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto);
		Task DeleteProductImageAsync(string id);
		Task<GetByIdProductImageDto> GetByIdProductImageAsync(string id);
	}
}
