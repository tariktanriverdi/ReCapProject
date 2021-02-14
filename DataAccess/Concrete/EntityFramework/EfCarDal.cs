
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfCarDal : EfEntityRepositoryBase<Car, MyDBContext>, ICarDal
	{
		public List<CarDetailDto> GetCarDetails()
		{
			using (MyDBContext context =new MyDBContext()) {
				var result = from c in context.Cars
							 join
	        b in context.Brands on c.BrandId equals b.Id
							 select new CarDetailDto { BrandName = b.BrandName, Id = c.Id ,Description=b.Description};
				return result.ToList();


			}
		}
	}
}
