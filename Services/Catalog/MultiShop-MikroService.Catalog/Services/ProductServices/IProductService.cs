using MultiShop_MikroService.Catalog.Dtos.ProductDtos;

namespace MultiShop_MikroService.Catalog.Services.ProductServices
{
	public interface IProductService
	{
		Task<List<ResultProductDto>> GetAllProductAsync();
		Task CreateProductAsync(CreateProductDto createProductDto);
		Task UpdateProductAsync(UpdateProductDto updateProductDto);
		Task DeleteProductAsync(string id);
		Task<GetByIdProductDto> GetByIdProductAsync(string id);
	}
}
