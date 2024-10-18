﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop_MikroService.Order.Application.Features.CQRS.Queries.AddressQueries
{
	public class GetAddressByIdQuery
	{
        public int Id { get; set; }

		public GetAddressByIdQuery(int ıd)
		{
			Id = ıd;
		}
	}
}
