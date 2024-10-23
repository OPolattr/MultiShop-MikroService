using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop_MikroService.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop_MikroService.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using MultiShop_MikroService.Order.Application.Features.CQRS.Handlers.AddressHandlers;
using MultiShop_MikroService.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;
using MultiShop_MikroService.Order.Application.Features.CQRS.Queries.AddressQueries;
using MultiShop_MikroService.Order.Application.Features.CQRS.Queries.OrderDetailQueries;

namespace MultiShop_MikroService.Order.WebApi.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class OrderDetailsController : ControllerBase
	{
		private readonly GetOrderDetailQueryHandler _queryHandler;
		private readonly GetOrderDetailByIdQueryHandler _getOrderDetailByIdQueryHandler;
		private readonly CreateOrderDetailCommandHandler _createOrderDetailCommandHandler;
		private readonly UpdateOrderDetailCommandHandler _updateOrderDetailCommandHandler;
		private readonly RemoveOrderDetailCommandHandler _removeOrderDetailCommandHandler;

		public OrderDetailsController(RemoveOrderDetailCommandHandler removeOrderDetailCommandHandler, UpdateOrderDetailCommandHandler updateOrderDetailCommandHandler, CreateOrderDetailCommandHandler createOrderDetailCommandHandler, GetOrderDetailByIdQueryHandler getOrderDetailByIdQueryHandler, GetOrderDetailQueryHandler queryHandler)
		{
			_removeOrderDetailCommandHandler = removeOrderDetailCommandHandler;
			_updateOrderDetailCommandHandler = updateOrderDetailCommandHandler;
			_createOrderDetailCommandHandler = createOrderDetailCommandHandler;
			_getOrderDetailByIdQueryHandler = getOrderDetailByIdQueryHandler;
			_queryHandler = queryHandler;
		}

		[HttpGet]
		public async Task<IActionResult> OrderDetailList()
		{
			var values = await _queryHandler.Handle();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetOrderDetailById(int id)
		{
			var values = await _getOrderDetailByIdQueryHandler.Handle(new GetOrderDetailByIdQuery(id));
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> CreateOrderDetail(CreateOrderDetailCommand command)
		{
			await _createOrderDetailCommandHandler.Handle(command);
			return Ok("Sipariş Detayı başarı ile eklendi");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateOrderDetail(UpdateOrderDetailCommand command)
		{
			await _updateOrderDetailCommandHandler.Handle(command);
			return Ok("Sipariş detayı başarı ile güncellendi");
		}

		[HttpDelete]
		public async Task<IActionResult> RemoveOrderDetail(int id)
		{
			await _removeOrderDetailCommandHandler.Handle(new RemoveOrderDetailCommand(id));
			return Ok("Sipariş detayı başarı ile silindi");

		}
	}
}
