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
	public class CargoCompanyManager : ICargoCompanyService
	{
		private readonly ICargoCompanyDal _companyDal;

		public CargoCompanyManager(ICargoCompanyDal companyDal)
		{
			_companyDal = companyDal;
		}

		public void TDelete(int id)
		{
			_companyDal.Delete(id);
		}

		public List<CargoCompany> TGetAll()
		{
			return _companyDal.GetAll();
		}

		public CargoCompany TGetById(int id)
		{
			return _companyDal.GetById(id);
		}

		public void TInsert(CargoCompany entity)
		{
			_companyDal.Insert(entity);
		}

		public void TUpdate(CargoCompany entity)
		{
			_companyDal.Update(entity);
		}
	}
}
