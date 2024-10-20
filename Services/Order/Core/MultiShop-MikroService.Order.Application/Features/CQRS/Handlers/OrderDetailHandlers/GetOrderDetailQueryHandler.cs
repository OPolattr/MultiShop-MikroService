﻿using MultiShop_MikroService.Order.Application.Features.CQRS.Results.AddressResults;
using MultiShop_MikroService.Order.Application.Features.CQRS.Results.OrderDetailResults;
using MultiShop_MikroService.Order.Application.Interfaces;
using MultiShop_MikroService.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop_MikroService.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
	public class GetOrderDetailQueryHandler
	{
		private readonly IRepository<OrderDetail> _repository;

		public GetOrderDetailQueryHandler(IRepository<OrderDetail> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetOrderDetailQueryResult>> Handle()
		{
			var values = await _repository.GetAllAsync();
			return values.Select(x => new GetOrderDetailQueryResult
			{
				OrderDetailId = x.OrderDetailId,
				ProductId = x.ProductId,
				OrderingId = x.OrderingId,
				ProductName = x.ProductName,
				ProductAmount = x.ProductAmount,
				ProductPrice = x.ProductPrice,
				ProductTotalPrice = x.ProductTotalPrice
			}).ToList();
		}
	}
}
