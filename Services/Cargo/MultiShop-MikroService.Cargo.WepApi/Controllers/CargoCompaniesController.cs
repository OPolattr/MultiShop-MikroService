using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop_MikroService.Cargo.BusinessLayer.Abstract;
using MultiShop_MikroService.Cargo.DtoLayer.Dtos.CargoCompanyDtos;
using MultiShop_MikroService.Cargo.EntityLayer.Concrete;

namespace MultiShop_MikroService.Cargo.WepApi.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class CargoCompaniesController : ControllerBase
	{
		private readonly ICargoCompanyService _companyService;

		public CargoCompaniesController(ICargoCompanyService companyService)
		{
			_companyService = companyService;
		}

		[HttpGet]
		public IActionResult CargoCompanyList()
		{
			var values = _companyService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateCargoCompany(CreateCargoCompanyDto createCargoCompanyDto)
		{
			CargoCompany cargoCompany = new CargoCompany()
			{
				CargoCompanyName = createCargoCompanyDto.CargoCompanyName
			};
			_companyService.TInsert(cargoCompany);
			return Ok("Kargo Şirketi Başarıyla Oluşturuldu");
		}

		[HttpDelete]
		public IActionResult RemoveCargoCompany(int id)
		{
			_companyService.TDelete(id);
			return Ok("Kargo Şirketi Başarıyla Silindi");
		}

		[HttpGet("{id}")]
		public IActionResult GetCargoCompanyById(int id)
		{
			var values = _companyService.TGetById(id);
			return Ok(values);
		}

		[HttpPut]
		public IActionResult UpdateCargoCompany(UpdateCargoCompanyDto updateCargoCompanyDto)
		{
			CargoCompany cargoCompany = new CargoCompany()
			{
				CargoCompanyId = updateCargoCompanyDto.CargoCompanyId,
				CargoCompanyName = updateCargoCompanyDto.CargoCompanyName
			};
			_companyService.TUpdate(cargoCompany);
			return Ok("Kargo Şirketi Başarıyla Güncellendi");
		}
	}
}
