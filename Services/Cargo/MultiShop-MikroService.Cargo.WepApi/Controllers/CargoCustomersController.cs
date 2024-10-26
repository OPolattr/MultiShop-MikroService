using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop_MikroService.Cargo.BusinessLayer.Abstract;
using MultiShop_MikroService.Cargo.DtoLayer.Dtos.CargoCustomerDtos;
using MultiShop_MikroService.Cargo.EntityLayer.Concrete;

namespace MultiShop_MikroService.Cargo.WepApi.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class CargoCustomersController : ControllerBase
	{

		private readonly ICargoCustomerService _customerService;

		public CargoCustomersController(ICargoCustomerService customerService)
		{
			_customerService = customerService;
		}

		[HttpGet]
		public IActionResult CargoCustomerList()
		{
			var values = _customerService.TGetAll();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public IActionResult GetCargoCustomerById(int id)
		{
			var value = _customerService.TGetById(id);
			return Ok(value);
		}

		[HttpPost]
		public IActionResult CreateCargoCustomer(CreateCargoCustomerDto createCargoCustomerDto)
		{
			CargoCustomer cargoCustomer = new CargoCustomer()
			{
				Address = createCargoCustomerDto.Address,
				City = createCargoCustomerDto.City,
				District = createCargoCustomerDto.District,
				Email = createCargoCustomerDto.Email,
				Name = createCargoCustomerDto.Name,
				Phone = createCargoCustomerDto.Phone,
				Surname = createCargoCustomerDto.Surname
			};
			_customerService.TInsert(cargoCustomer);
			return Ok("Kargo Müşteri Ekleme İşlemi Başarıyla Yapıldı");
		}

		[HttpDelete]
		public IActionResult RemoveCargoCustomer(int id)
		{
			_customerService.TDelete(id);
			return Ok("Kargo Müşteri Silme İşlemi Başarıyla Yapıldı");
		}

		[HttpPut]
		public IActionResult UpdateCargoCustomer(UpdateCargoCustomerDto updateCargoCustomerDto)
		{
			CargoCustomer cargoCustomer = new CargoCustomer()
			{
				Address = updateCargoCustomerDto.Address,
				CargoCustomerId = updateCargoCustomerDto.CargoCustomerId,
				City = updateCargoCustomerDto.City,
				District = updateCargoCustomerDto.District,
				Email = updateCargoCustomerDto.Email,
				Name = updateCargoCustomerDto.Name,
				Phone = updateCargoCustomerDto.Phone,
				Surname = updateCargoCustomerDto.Surname
			};
			_customerService.TUpdate(cargoCustomer);
			return Ok("Kargo Müşteri Güncelleme İşlemi Başarıyla Yapıldı");
		}
	}
}
