using MediatR;
using MultiShop_MikroService.Order.Application.Features.Mediator.Commands.OrderingCommands;
using MultiShop_MikroService.Order.Application.Interfaces;
using MultiShop_MikroService.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop_MikroService.Order.Application.Features.Mediator.Handlers.OrderingHandlers
{
	public class UpdateOrderingCommandHandler : IRequestHandler<UpdateOrderingCommand>
	{
		private readonly IRepository<Ordering> _repository;

		public UpdateOrderingCommandHandler(IRepository<Ordering> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateOrderingCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.OrderingId);
			values.OrderDate = request.OrderDate;
			values.UserId = request.UserId;
			values.TotalPrice = request.TotalPrice;
			await _repository.UpdateAsync(values);
		}
	}
}
