using Dapper;
using Microsoft.EntityFrameworkCore;
using MultiShop_MikroService.Discount.Context;
using MultiShop_MikroService.Discount.Dtos;

namespace MultiShop_MikroService.Discount.Services
{
	public class DiscountService : IDiscountService
	{
		private readonly DapperContext _dapperContext;

		public DiscountService(DapperContext dapperContext)
		{
			_dapperContext = dapperContext;
		}

		public async Task CreateDiscountCouponAsync(CreateDiscountCouponDto createCouponDto)
		{
			string query = "insert into Coupons (CouponCode,CouponRate,CouponIsActive,CouponValidDate) values (@couponCode,@couponRate,@couponIsActive,@couponValidDate)";
			var parameters = new DynamicParameters();
			parameters.Add("@couponCode", createCouponDto.CouponCode);
			parameters.Add("@couponRate", createCouponDto.CouponRate);
			parameters.Add("@couponIsActive", createCouponDto.CouponIsActive);
			parameters.Add("@couponValidDate", createCouponDto.CouponValidDate);
			using(var connection = _dapperContext.CreateConnection())
			{
				await connection.ExecuteAsync(query, parameters);
			}
		}

		public async Task DeleteDiscountCouponAsync(int id)
		{
			string query = "Delete From Coupons where CouponId=@couponId";
			var parameters = new DynamicParameters();
			parameters.Add("couponId", id);
			using (var connection = _dapperContext.CreateConnection())
			{
				await connection.ExecuteAsync(query, parameters);
			}
		}

		public async Task<List<ResultDiscountCouponDto>> GetAllDiscountCouponAsync()
		{
			string query = "Select * From Coupons";
			using (var connection = _dapperContext.CreateConnection())
			{
				var values = await connection.QueryAsync<ResultDiscountCouponDto>(query);
				return values.ToList();
			}
		}

		public async Task<GetByIdDiscountCouponDto> GetByIdDiscountCouponAsync(int id)
		{
			string query = "Select * From Coupons Where CouponId=@couponId";
			var parameters = new DynamicParameters();
			parameters.Add("@couponId", id);
			using (var connection = _dapperContext.CreateConnection())
			{
				var values = await connection.QueryFirstOrDefaultAsync<GetByIdDiscountCouponDto>(query, parameters);
				return values;
			}
		}

		public async Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateCouponDto)
		{
			string query = "Update Coupons Set CouponCode=@code,CouponRate=@rate,CouponIsActive=@isActive,CouponValidDate=@validDate where CouponId=@couponId";
			var parameters = new DynamicParameters();
			parameters.Add("@code", updateCouponDto.CouponCode);
			parameters.Add("@rate", updateCouponDto.CouponRate);
			parameters.Add("@isActive", updateCouponDto.CouponIsActive);
			parameters.Add("@validDate", updateCouponDto.CouponValidDate);
			parameters.Add("@couponId", updateCouponDto.CouponId);
			using (var connection = _dapperContext.CreateConnection())
			{
				await connection.ExecuteAsync(query, parameters);
			}
		}
	}
}
