using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
	public class CarManager : ICarService
	{
		ICarDal _service;
		

	public	CarManager(ICarDal service)
		{
			_service = service;
		}
		public void Add(Car car)
		{
			_service.Add(car);
		}

		public void Delete(Car car)
		{
			_service.Delete(car);
		}

		public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
		{
			return _service.GetAll(filter);
		}

		public Car GetById(Expression<Func<Car, bool>> filter)
		{
			return _service.GetById(filter);
		}

		public List<CarDetailDto> GetCarDetails()
		{
			return _service.GetCarDetails();
		}

		public void Update(Car car)
		{
			_service.Update(car);
		}
	}
}
