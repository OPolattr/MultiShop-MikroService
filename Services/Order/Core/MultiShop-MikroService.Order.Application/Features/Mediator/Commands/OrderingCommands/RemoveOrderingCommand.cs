﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop_MikroService.Order.Application.Features.Mediator.Commands.OrderingCommands
{
	public class RemoveOrderingCommand
	{
        public int Id { get; set; }

		public RemoveOrderingCommand(int id)
		{
			Id = id;
		}
	}
}