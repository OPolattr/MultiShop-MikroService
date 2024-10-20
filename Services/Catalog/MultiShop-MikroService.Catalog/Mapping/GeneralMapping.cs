using AutoMapper;
using MultiShop_MikroService.Catalog.Dtos.CategoryDtos;
using MultiShop_MikroService.Catalog.Dtos.ProductDetailDtos;
using MultiShop_MikroService.Catalog.Dtos.ProductDtos;
using MultiShop_MikroService.Catalog.Dtos.ProductImageDtos;
using MultiShop_MikroService.Catalog.Entities;

namespace MultiShop_MikroService.Catalog.Mapping
{
	public class GeneralMapping : Profile
	{
		public GeneralMapping() 
		{
			CreateMap<Category, ResultCategoryDto>().ReverseMap();
			CreateMap<Category, CreateCategoryDto>().ReverseMap();
			CreateMap<Category, UpdateCategoryDto>().ReverseMap();
			CreateMap<Category, GetByIdCategoryDto>().ReverseMap();

			CreateMap<Product, ResultProductDto>().ReverseMap();
			CreateMap<Product, CreateProductDto>().ReverseMap();
			CreateMap<Product, UpdateProductDto>().ReverseMap();
			CreateMap<Product, GetByIdProductDto>().ReverseMap();


			CreateMap<ProductDetail, ResultProductDetailDto>().ReverseMap();
			CreateMap<ProductDetail, CreateProductDetailDto>().ReverseMap();
			CreateMap<ProductDetail, UpdateProductDetailDto>().ReverseMap();
			CreateMap<ProductDetail, GetByIdProductDetailDto>().ReverseMap();


			CreateMap<ProductImage, ResultProductImageDto>().ReverseMap();
			CreateMap<ProductImage, CreateProductImageDto>().ReverseMap();
			CreateMap<ProductImage, UpdateProductImageDto>().ReverseMap();
			CreateMap<ProductImage, GetByIdProductImageDto>().ReverseMap();


		}
	}
}
