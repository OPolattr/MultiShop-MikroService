﻿using Microsoft.EntityFrameworkCore;
using MultiShop_MikroService.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop_MikroService.Cargo.DataAccessLayer.Concrete
{
	public class CargoContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=localhost,1435;initial Catalog=MultiShopCargoDb;User=sa;Password=123456Aa*");
		}

		public DbSet<CargoCompany> CargoCompanies { get; set; }
		public DbSet<CargoDetail> CargoDetails { get; set; }
		public DbSet<CargoCustomer> CargoCustomers { get; set; }
		public DbSet<CargoOperation> CargoOperations { get; set; }
	}
}
