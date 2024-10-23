﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop_MikroService.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop_MikroService.Order.Application.Features.CQRS.Handlers.AddressHandlers;
using MultiShop_MikroService.Order.Application.Features.CQRS.Queries.AddressQueries;

namespace MultiShop_MikroService.Order.WebApi.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class AddressesController : ControllerBase
	{
		private readonly GetAddressQueryHandler _getAddressQueryHandler;
		private readonly GetAddressByIdQueryHandler _getAddressByIdQueryHandler;
		private readonly CreateAddressCommandHandler _createAddressCommandHandler;
		private readonly UpdateAddressCommandHandler _updateAddressCommandHandler;
		private readonly RemoveAddressCommandHandler _removeAddressCommandHandler;

		public AddressesController(GetAddressQueryHandler getAddressQueryHandler, GetAddressByIdQueryHandler getAddressByIdQueryHandler, CreateAddressCommandHandler createAddressCommandHandler, RemoveAddressCommandHandler removeAddressCommandHandler, UpdateAddressCommandHandler updateAddressCommandHandler)
		{
			_getAddressQueryHandler = getAddressQueryHandler;
			_getAddressByIdQueryHandler = getAddressByIdQueryHandler;
			_createAddressCommandHandler = createAddressCommandHandler;
			_removeAddressCommandHandler = removeAddressCommandHandler;
			_updateAddressCommandHandler = updateAddressCommandHandler;
		}

		[HttpGet]
		public async Task<IActionResult> AddressList()
		{
			var values = await _getAddressQueryHandler.Handle();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetAddressById(int id)
		{
			var values = await _getAddressByIdQueryHandler.Handle(new GetAddressByIdQuery(id));
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> CreateAddress(CreateAddressCommand command)
		{
			await _createAddressCommandHandler.Handle(command);
			return Ok("Adres başarı ile eklendi");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateAddress(UpdateAddressCommand command)
		{
			await _updateAddressCommandHandler.Handle(command);
			return Ok("adres başarı ile güncellendi");
		}

		[HttpDelete]
		public async Task<IActionResult> RemoveAddress(int id)
		{
			await _removeAddressCommandHandler.Handle(new RemoveAddressCommand(id));
			return Ok("Adres başarı ile silindi");

		}
	}
}
