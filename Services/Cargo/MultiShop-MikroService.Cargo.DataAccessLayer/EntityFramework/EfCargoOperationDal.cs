﻿using MultiShop_MikroService.Cargo.DataAccessLayer.Abstract;
using MultiShop_MikroService.Cargo.DataAccessLayer.Concrete;
using MultiShop_MikroService.Cargo.DataAccessLayer.Repositories;
using MultiShop_MikroService.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop_MikroService.Cargo.DataAccessLayer.EntityFramework
{
	public class EfCargoOperationDal : GenericRepository<CargoOperation>, ICargoOperationDal
	{
		public EfCargoOperationDal(CargoContext context) : base(context)
		{
		}
	}
}
