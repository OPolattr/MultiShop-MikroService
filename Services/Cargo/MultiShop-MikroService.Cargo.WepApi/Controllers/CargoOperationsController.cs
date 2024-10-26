﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop_MikroService.Cargo.BusinessLayer.Abstract;
using MultiShop_MikroService.Cargo.DtoLayer.Dtos.CargoDetailDtos;
using MultiShop_MikroService.Cargo.DtoLayer.Dtos.CargoOperationDtos;
using MultiShop_MikroService.Cargo.EntityLayer.Concrete;

namespace MultiShop_MikroService.Cargo.WepApi.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class CargoOperationsController : ControllerBase
	{
		private readonly ICargoOperationService _cargoOperationService;

		public CargoOperationsController(ICargoOperationService cargoOperationService)
		{
			_cargoOperationService = cargoOperationService;
		}

		[HttpGet]
		public IActionResult CargoOperationList()
		{
			var values = _cargoOperationService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateCargoOperation(CreateCargoOperationDto createCargoOperationDto)
		{
			CargoOperation CargoOperation = new CargoOperation()
			{
				Barcode = createCargoOperationDto.Barcode,
				Description = createCargoOperationDto.Description,
				OperationDate = createCargoOperationDto.OperationDate
			};
			_cargoOperationService.TInsert(CargoOperation);
			return Ok("Kargo İşlemi Başarıyla Oluşturuldu");
		}

		[HttpDelete]
		public IActionResult RemoveCargoOperation(int id)
		{
			_cargoOperationService.TDelete(id);
			return Ok("Kargo İşlemi Başarıyla Silindi");
		}

		[HttpGet("{id}")]
		public IActionResult GetCargoOperationById(int id)
		{
			var values = _cargoOperationService.TGetById(id);
			return Ok(values);
		}

		[HttpPut]
		public IActionResult UpdateCargoOperation(UpdateCargoOperationDto updateCargoOperationDto)
		{
			CargoOperation CargoOperation = new CargoOperation()
			{
				Barcode = updateCargoOperationDto.Barcode,
				CargoOperationId = updateCargoOperationDto.CargoOperationId,
				Description = updateCargoOperationDto.Description,
				OperationDate = updateCargoOperationDto.OperationDate
			};
			_cargoOperationService.TUpdate(CargoOperation);
			return Ok("Kargo İşlemi Başarıyla Güncellendi");
		}
	}
}
