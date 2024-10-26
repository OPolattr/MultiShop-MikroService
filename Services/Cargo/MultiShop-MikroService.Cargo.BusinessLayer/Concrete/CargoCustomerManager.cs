using MultiShop_MikroService.Cargo.BusinessLayer.Abstract;
using MultiShop_MikroService.Cargo.DataAccessLayer.Abstract;
using MultiShop_MikroService.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop_MikroService.Cargo.BusinessLayer.Concrete
{
	public class CargoCustomerManager : ICargoCustomerService
	{
		private readonly ICargoCustomerDal _customerDal;

		public CargoCustomerManager(ICargoCustomerDal customerDal)
		{
			_customerDal = customerDal;
		}

		public void TDelete(int id)
		{
			_customerDal.Delete(id);
		}

		public List<CargoCustomer> TGetAll()
		{
			return _customerDal.GetAll();
		}

		public CargoCustomer TGetById(int id)
		{
			return _customerDal.GetById(id);
		}

		public void TInsert(CargoCustomer entity)
		{
			_customerDal.Insert(entity);
		}

		public void TUpdate(CargoCustomer entity)
		{
			_customerDal.Update(entity);
		}
	}
}
