using MultiShop_MikroService.Catalog.Dtos.CategoryDtos;

namespace MultiShop_MikroService.Catalog.Services.CategoryServices
{
	public interface ICategoryService
	{
		Task<List<ResultCategoryDto>> GetAllCategoryAsync();
		Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
		Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
		Task DeleteCategoryAsync(string id);
		Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id);
	}
}
